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
    public partial class FrmCategories : Form
    {

        private RestaurantsDBEntities restaurantContext { get; set; }

        public FrmCategories(RestaurantsDBEntities xres)
        {
            InitializeComponent();
            restaurantContext = xres;
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            getDades(); 
        }


        private void pbAdd_Click(object sender, EventArgs e)
        {

        }

        private void pbDel_Click(object sender, EventArgs e)
        {

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

       
    }
}
