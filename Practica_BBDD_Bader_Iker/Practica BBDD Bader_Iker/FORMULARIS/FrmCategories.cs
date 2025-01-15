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
    public partial class FrmCategories : Form
    {

        private RestaurantsDBEntities restaurantContext { get; set; }

        public FrmCategories(RestaurantsDBEntities xres)
        {
            InitializeComponent();
            restaurantContext = xres;
        }

        private void gridInit()
        {
            //dgCategories.Columns["idCategoria"].Visible = false;
            dgCategories.Columns["descripcioCategoria"].HeaderText = "Categoria";
            dgCategories.Columns["Restaurants"].Visible = false;
            dgRestaurants.Columns["nomRestaurant"].DisplayIndex = 0;
            dgRestaurants.Columns["idRes"].Visible = false;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            getDades();
            gridInit();
        }


        private void pbAdd_Click(object sender, EventArgs e)
        {
            Categories c = new Categories();

            if (vDades())
            {
                c.descripcioCategoria = tbCat.Text;
                restaurantContext.Categories.Add(c);
                ferCanvis();
                getDades();
            }
        }

        private void pbDel_Click(object sender, EventArgs e)
        {
            
            Categories c = restaurantContext.Categories.Find(dgCategories.SelectedRows[0].Cells["idCategoria"].Value);

            if (c != null)
            {
                restaurantContext.Categories.Remove(c);
                ferCanvis();
                getDades();
            }
        }

      
        private void btAfegir_Click(object sender, EventArgs e)
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


            var qryCategoies = from c in restaurantContext.Categories
                            orderby c.idCategoria
                            select c;


            //var qryResCategories = from r in restaurantContext.Restaurants
            //                    join rc in restaurantContext.RestaurantCategories on r.idRestaurant equals rc.IdRestaurant
            //                    join c in restaurantContext.Categories on rc.IdCategoria equals c.idCategoria
            //                    orderby r.Nom
            //                    select new
            //                    {
            //                        NomRestaurant = r.Nom,
            //                        DescripcioCategoria = c.DescripcioCategoria
            //                    };

           
            dgRestaurants.DataSource = qryRestaurants.ToList();
            dgCategories.DataSource = qryCategoies.ToList();
            //dgRestCat.DataSource = qryResCategories.ToList();
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if (tbCat.Text.Trim().Length == 0)
            {
                MessageBox.Show("No hi has posata nom a la categoria que vols afegir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
