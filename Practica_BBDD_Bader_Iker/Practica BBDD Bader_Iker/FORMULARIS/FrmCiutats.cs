using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    public partial class FrmCiutats : Form
    {
        private RestaurantsDBEntities10 restaurantContext { get; set; }
        Boolean bFirst = true;

        FrmADMCiutat frmADMCiutat = null;

        public FrmCiutats(RestaurantsDBEntities10 xres)
        {
            InitializeComponent();
            restaurantContext = xres;
        }
        private void FrmCiutats_Load(object sender, EventArgs e)
        {
            omplirComboPaisos();
            getDadesSenseFiltre();
            iniDgrid();
            bFirst = false;
            cbPais.Enabled = false;
        }

        private void cbxTots_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxTots.Checked)
            {
                getDadesSenseFiltre();
                cbPais.Enabled = false;
            }
            else
            {
                getDades(cbPais.SelectedValue.ToString());
                cbPais.Enabled = true;
            }
        }

        private void iniDgrid()
        {
            dgCiutats.Columns["ciutat"].HeaderText = "Ciutat";
            dgCiutats.Columns["pais"].HeaderText = "Pais";
        }

        private void omplirComboPaisos()
        {
            var qryPaisos = from p in restaurantContext.Paisos
                                orderby p.NomPais
                                select p;


            cbPais.DataSource = qryPaisos.ToList();
            cbPais.DisplayMember = "NomPais";
            cbPais.ValueMember = "NomPais";
            cbPais.SelectedIndex = 0;
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmADMCiutat = new FrmADMCiutat(restaurantContext, 'A');
            frmADMCiutat.ShowDialog();

            if (cbxTots.Checked)
            {
                getDadesSenseFiltre();
            }
            else
            {
                getDades(cbPais.SelectedValue.ToString());
            }

            if (frmADMCiutat.pais != "")
            {
                seleccionarFila(frmADMCiutat.ciutat);
            }
            frmADMCiutat = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgCiutats.Rows.Count > 0)
            {
                frmADMCiutat = new FrmADMCiutat(restaurantContext, 'D');

                frmADMCiutat.ciutat = dgCiutats.SelectedRows[0].Cells["ciutat"].Value.ToString().Trim();
                frmADMCiutat.pais = dgCiutats.SelectedRows[0].Cells["pais"].Value.ToString().Trim();

                frmADMCiutat.ShowDialog();

                if (cbxTots.Checked)
                {
                    getDadesSenseFiltre();
                }
                else
                {
                    getDades(cbPais.SelectedValue.ToString());
                }
                frmADMCiutat = null;
            }
            else
            {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionarFila(string ciutat)
        {
            int i = -1;
            Boolean xbTrobat = false;

            while (!xbTrobat && i < dgCiutats.Rows.Count)
            {
                i++;
                xbTrobat = (dgCiutats.Rows[i].Cells["ciutat"].Value.ToString() == ciutat);
            }
            if (dgCiutats.Rows.Count > 0)
            {
                dgCiutats.Rows[i].Selected = true;
                dgCiutats.FirstDisplayedScrollingRowIndex = i; // Desplaça el DataGridView a la fila seleccionada
            }
        }


        private void getDades(string ciutat)
        {
            // declarem una consulta dels Territoris de la Regió seleccionada
            var qryPaisos = from c in restaurantContext.Ciutats
                            where c.NomPais == ciutat
                            orderby c.NomCiutat
                            select c;

            // omplim el datagridview
            dgCiutats.DataSource = qryPaisos.ToList();
        }

        private void getDadesSenseFiltre()
        {
            var qryCiutat = from c in restaurantContext.Ciutats
                            orderby c.NomPais
                            select new
                            {
                                ciutat = c.NomCiutat,
                                pais = c.NomPais
                            };

            // omplim el datagridview
            // *** ALERTA!!! UNA LIMITACIÓ QUE TINDREM ÉS QUE EN EL DATAGRIDVIEW NO ES PODRÀ ORDENAR LA INFORMACIÓ FENT CLIC A LA CAPÇALERA DE LA COLUMNA
            //     AIXÒ ÉS PERQUÈ LA LLISTA GENERADA AMB qryTerritoris.ToList() NO ÉS UNA LLISTA DINÀMICA SINÓ ESTÀTICA ("ÀNÒNIMA")
            dgCiutats.DataSource = qryCiutat.ToList();
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst && cbPais.SelectedValue != null)
            {
                getDades((string)cbPais.SelectedValue);
            }
        }

       
    }
}

