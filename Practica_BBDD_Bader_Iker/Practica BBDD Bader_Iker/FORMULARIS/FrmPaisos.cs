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

        private RestaurantsDBEntities restaurantContext { get; set; }
        Boolean bFirst = true;

        public FrmPaisos(RestaurantsDBEntities xres)
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
            // ****ALERTA!!! ARA ELS NOMS DE LES COLUMNES DEL DATAGRIDVIEW NO SÓN ELS DELS CAMPS DE LA TAULA EN LA BD
            //     SINÓ QUE SÓN ELS QUE HEM UTILITZAT EN LA QUERY DINS DE getDades() o getDadesSenseFiltre()
            dgPaisos.Columns["pais"].HeaderText = "Pais";
            dgPaisos.Columns["continent"].HeaderText = "Continent";
        }

        private void omplirComboContinents()
        {
            var qryContinents = from c in restaurantContext.Continents
                             orderby c.NomContinent
                             select c;

            // omplim el combobox de regions
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
                getDades((string)cbContinents.SelectedValue);
                cbContinents.Enabled = true;
            }
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }

        private void pbDel_Click(object sender, EventArgs e)
        {

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
