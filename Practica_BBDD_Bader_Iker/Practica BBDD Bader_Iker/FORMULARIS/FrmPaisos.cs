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
    public partial class FrmPaisos : Form
    {

        private RestaurantsDBEntitiesIker restaurantContext { get; set; }
        Boolean bFirst = true;

        FrmADMPais frmADMPais = null;

        public FrmPaisos(RestaurantsDBEntitiesIker xres)
        {
            InitializeComponent();
            restaurantContext = xres;
        }

        private void FrmPaisos_Load(object sender, EventArgs e)
        {
            omplirComboContinents();
            getDadesSenseFiltre();
            iniDgrid();
            bFirst = false;
            cbContinents.Enabled = false;
        }

        private void iniDgrid()
        {
            dgPaisos.Columns["pais"].HeaderText = "Pais";
            dgPaisos.Columns["continent"].HeaderText = "Continent";
        }

        private void omplirComboContinents()
        {
            var qryContinents = from c in restaurantContext.Continents
                                orderby c.NomContinent
                                select c;


            cbContinents.DataSource = qryContinents.ToList();
            cbContinents.DisplayMember = "NomContinent";
            cbContinents.ValueMember = "NomContinent";
            cbContinents.SelectedIndex = 0;
        }

        private void cbxTots_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxTots.Checked)
            {
                getDadesSenseFiltre();
                cbContinents.Enabled = false;
            }
            else
            {
                getDades(cbContinents.SelectedValue.ToString());
                cbContinents.Enabled = true;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            frmADMPais = new FrmADMPais(restaurantContext, 'A');
            frmADMPais.ShowDialog();

            if (cbxTots.Checked)
            {
                getDadesSenseFiltre();
            }
            else
            {
                getDades(cbContinents.SelectedValue.ToString());
            }

            if (frmADMPais.pais != "")
            {
                seleccionarFila(frmADMPais.pais);
            }
            frmADMPais = null;
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgPaisos.Rows.Count > 0)
            {
                frmADMPais = new FrmADMPais(restaurantContext, 'D');

                frmADMPais.pais = dgPaisos.SelectedRows[0].Cells["pais"].Value.ToString().Trim();
                frmADMPais.continent = dgPaisos.SelectedRows[0].Cells["continent"].Value.ToString().Trim();

                frmADMPais.ShowDialog();

                if (cbxTots.Checked)
                {
                    getDadesSenseFiltre();
                }
                else
                {
                    getDades(cbContinents.SelectedValue.ToString());
                }
                frmADMPais = null;
            }
            else
            {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void seleccionarFila(string pais)
        {
            int i = -1;
            Boolean xbTrobat = false;

            while (!xbTrobat && i < dgPaisos.Rows.Count)
            {
                i++;
                xbTrobat = (dgPaisos.Rows[i].Cells["pais"].Value.ToString() == pais);
            }
            if (dgPaisos.Rows.Count > 0)
            {
                dgPaisos.Rows[i].Selected = true;
                dgPaisos.FirstDisplayedScrollingRowIndex = i; // Desplaça el DataGridView a la fila seleccionada
            }
        }


        private void getDades(string continent)
        {
            // declarem una consulta dels Territoris de la Regió seleccionada
            var qryPaisos = from p in restaurantContext.Paisos
                            where p.NomContinent == continent
                            orderby p.NomPais
                            select p;

            // omplim el datagridview
            dgPaisos.DataSource = qryPaisos.ToList();
        }

        private void getDadesSenseFiltre()
        {
            var qryPaisos = from p in restaurantContext.Paisos
                            orderby p.NomPais
                            select new
                            {
                                pais = p.NomPais,
                                continent = p.NomContinent
                            };

            // omplim el datagridview
            // *** ALERTA!!! UNA LIMITACIÓ QUE TINDREM ÉS QUE EN EL DATAGRIDVIEW NO ES PODRÀ ORDENAR LA INFORMACIÓ FENT CLIC A LA CAPÇALERA DE LA COLUMNA
            //     AIXÒ ÉS PERQUÈ LA LLISTA GENERADA AMB qryTerritoris.ToList() NO ÉS UNA LLISTA DINÀMICA SINÓ ESTÀTICA ("ÀNÒNIMA")
            dgPaisos.DataSource = qryPaisos.ToList();
        }

        private void cbContinents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!bFirst && cbContinents.SelectedValue != null)
            {
                getDades((string)cbContinents.SelectedValue);
            }
        }
    }
}
