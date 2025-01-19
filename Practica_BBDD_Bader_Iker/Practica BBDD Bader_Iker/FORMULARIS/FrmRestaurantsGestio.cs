using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    public partial class FrmRestaurantsGestio : Form
    {

        private RestaurantsDBEntities restaurantContext { get; set; }

        public FrmRestaurantsGestio(RestaurantsDBEntities xres)
        {
            InitializeComponent();
            restaurantContext = xres;
        }
        
        private void FrmRestaurantsGestio_Load(object sender, EventArgs e)
        {
            getDades();
            gridInit();
        }

        private void gridInit()
        {

            //Restaurants
            dgRestaurants.Columns["nomRestaurant"].DisplayIndex = 0;
            dgRestaurants.Columns["nomRestaurant"].HeaderText = "Nom Restaurant";
            dgRestaurants.Columns["idRes"].HeaderText = "ID Restaurant";
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

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }
        private void btFitxer_Click(object sender, EventArgs e)
        {

        }

        private void btMod_Click(object sender, EventArgs e)
        {

        }

        private void getDades()
        {

            var qryRestaurants = from r in restaurantContext.Restaurants
                                 orderby r.idRestaurant
                                 select new
                                 {
                                     idRes = r.idRestaurant,
                                     nomRestaurant = r.Nom
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

    }
}
