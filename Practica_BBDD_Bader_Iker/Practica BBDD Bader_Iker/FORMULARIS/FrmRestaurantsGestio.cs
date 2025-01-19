using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    public partial class FrmRestaurantsGestio : Form
    {

        private RestaurantsDBEntitiesIker1 restaurantContext { get; set; }

        public FrmRestaurantsGestio(RestaurantsDBEntitiesIker1 xres)
        {
            InitializeComponent();
            restaurantContext = xres;
        }
        
        private void FrmRestaurantsGestio_Load(object sender, EventArgs e)
        {
            getDades();
            gridInit();
            omplirComboCiutats();
        }

        private void omplirComboCiutats()
        {
            var qryCiutats = from c in restaurantContext.Ciutats
                            orderby c.NomCiutat
                            select c;


            cbCiutats.DataSource = qryCiutats.ToList();
            cbCiutats.DisplayMember = "NomCiutat";
            cbCiutats.ValueMember = "NomCiutat";
            cbCiutats.SelectedIndex = 0;
        }

        private void gridInit()
        {

            //Restaurants
            dgRestaurants.Columns["nomRestaurant"].DisplayIndex = 0;
            dgRestaurants.Columns["nomRestaurant"].HeaderText = "Nom Restaurant";
            dgRestaurants.Columns["idRes"].HeaderText = "ID Restaurant";
            dgRestaurants.Columns["ciutat"].Visible = false;
            dgRestaurants.Columns["adresa"].Visible = false;
            dgRestaurants.Columns["codiPostal"].Visible = false;
            dgRestaurants.Columns["email"].Visible = false;
            dgRestaurants.Columns["telefon"].Visible = false;
            dgRestaurants.Columns["linkWeb"].Visible = false;
            dgRestaurants.Columns["linkMaps"].Visible = false;
        }
        

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            Restaurants r = restaurantContext.Restaurants.Find(dgRestaurants.SelectedRows[0].Cells["idRes"].Value);

            if (r != null)
            {
                restaurantContext.Restaurants.Remove(r);
                ferCanvis();
                getDades();
            }
        }

        private void btAfegir_Click(object sender, EventArgs e)
        {
            Restaurants r = new Restaurants();

            r.Nom = tbNom.Text;
            r.NomCiutat = cbCiutats.SelectedValue.ToString();
            r.Adresa = tbAdresa.Text;
            r.CodiPostal = tbCodiPostal.Text;
            r.eMail = tbEmail.Text;
            r.TelefonContacte = tbEmail.Text;
            r.LinkWeb = tbLinkWeb.Text;
            r.GoogleMapsLink = tbLinkMaps.Text;

            if (vDades())
            {                
                restaurantContext.Restaurants.Add(r);
                ferCanvis();   
                getDades();    
            }
        }


        private void dgRestaurants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNom.Text = dgRestaurants.SelectedRows[0].Cells["nomRestaurant"].Value.ToString();
            cbCiutats.SelectedValue = dgRestaurants.SelectedRows[0].Cells["ciutat"].Value.ToString();
            tbAdresa.Text = dgRestaurants.SelectedRows[0].Cells["adresa"].Value.ToString();
            tbCodiPostal.Text = dgRestaurants.SelectedRows[0].Cells["codiPostal"].Value.ToString();
            tbEmail.Text = dgRestaurants.SelectedRows[0].Cells["email"].Value.ToString();
            tbTelefon.Text = dgRestaurants.SelectedRows[0].Cells["telefon"].Value.ToString();
            tbLinkWeb.Text = dgRestaurants.SelectedRows[0].Cells["linkWeb"].Value.ToString();
            tbLinkMaps.Text = dgRestaurants.SelectedRows[0].Cells["linkMaps"].Value.ToString();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            
            tbNom.Text = "";
            cbCiutats.SelectedIndex = 0;
            tbAdresa.Text = "";
            tbCodiPostal.Text = "";
            tbEmail.Text = "";
            tbTelefon.Text = "";
            tbLinkWeb.Text = "";
            tbLinkMaps.Text = "";
        }

        private void btMod_Click(object sender, EventArgs e)
        {
            if (dgRestaurants.SelectedRows.Count > 0)
            {
                int idRestaurant = Convert.ToInt32(dgRestaurants.SelectedRows[0].Cells["idRes"].Value);

                Restaurants r = restaurantContext.Restaurants.Find(idRestaurant);

                if (r != null)
                {
                    r.Nom = tbNom.Text;
                    r.NomCiutat = cbCiutats.SelectedValue.ToString();
                    r.Adresa = tbAdresa.Text;
                    r.CodiPostal = tbCodiPostal.Text;
                    r.eMail = tbEmail.Text;
                    r.TelefonContacte = tbTelefon.Text;  
                    r.LinkWeb = tbLinkWeb.Text;
                    r.GoogleMapsLink = tbLinkMaps.Text;
                    seleccionarFila(idRestaurant);
                    if (vDades()) 
                    {
                        ferCanvis();  
                        getDades();   
                    }
                }
                else
                {
                    MessageBox.Show("No s'ha trobat el restaurant per actualitzar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un restaurant per actualitzar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void getDades()
        {

            var qryRestaurants = from r in restaurantContext.Restaurants
                                 orderby r.idRestaurant
                                 select new
                                 {
                                     idRes = r.idRestaurant,
                                     nomRestaurant = r.Nom,
                                     ciutat = r.NomCiutat,
                                     adresa = r.Adresa,
                                     codiPostal = r.CodiPostal,
                                     email = r.eMail,
                                     telefon = r.TelefonContacte,
                                     linkWeb = r.LinkWeb,
                                     linkMaps = r.MiniaturaWeb
                                 };

            dgRestaurants.DataSource = qryRestaurants.ToList();
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if (tbNom.Text.Trim().Length == 0)
            {
                MessageBox.Show("No pots haber camps en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private Boolean ferCanvis()
        {
            Boolean xb = false;
            try
            {
                restaurantContext.SaveChanges();
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.InnerException.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                foreach (var accio in restaurantContext.ChangeTracker.Entries())
                {
                    accio.State = EntityState.Detached;
                }

            }
            return xb;
        }



        private void seleccionarFila(int idres)
        {
            int i = 0;  
            Boolean xbTrobat = false;

            while (!xbTrobat && i < dgRestaurants.Rows.Count)
            {
                xbTrobat = ((int)dgRestaurants.Rows[i].Cells["idRes"].Value == idres);
                if (!xbTrobat)
                {
                    i++;
                }
            }

            if (xbTrobat && dgRestaurants.Rows.Count > 0)
            {
                dgRestaurants.ClearSelection(); 
                dgRestaurants.Rows[i].Selected = true;
                dgRestaurants.FirstDisplayedScrollingRowIndex = i;
            }
        }

    }
}
