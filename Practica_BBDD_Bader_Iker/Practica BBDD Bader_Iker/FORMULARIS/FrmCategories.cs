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
            ///Categories
            dgCategories.Columns["idCategoria"].Visible = false;
            dgCategories.Columns["descripcioCategoria"].HeaderText = "Categoria";
            dgCategories.Columns["Restaurants"].Visible = false;
            ///Restaurants
            dgRestaurants.Columns["nomRestaurant"].DisplayIndex = 0;
            dgRestaurants.Columns["idRes"].Visible = false;
            ///Restaurants amb categories >:)            
            dgRestCat.Columns["idCategoria"].Visible = false;
            dgRestCat.Columns["idRestaurant"].Visible = false;
            dgRestCat.Columns["RestaurantName"].HeaderText = "Restaurant";
            dgRestCat.Columns["CategoryDescription"].HeaderText = "Categoria";
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
            try
            {
                int idRestaurant = Convert.ToInt32(dgRestaurants.SelectedRows[0].Cells["idRes"].Value);
                var restaurant = restaurantContext.Restaurants
                    .Include(r => r.Categories)
                    .FirstOrDefault(r => r.idRestaurant == idRestaurant);

                int idCategoria = Convert.ToInt32(dgCategories.SelectedRows[0].Cells["idCategoria"].Value);
                var categoria = restaurantContext.Categories
                    .FirstOrDefault(c => c.idCategoria == idCategoria);

                if (restaurant != null && categoria != null && !restaurant.Categories.Contains(categoria))
                {
                    restaurant.Categories.Add(categoria);
                    ferCanvis();
                    getDades();

                    MessageBox.Show("Categoria assignada correctament al restaurant.");
                }
                else
                {
                    MessageBox.Show("La categoria ja està assignada o hi ha hagut un error.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S'ha produït un error: " + ex.Message);
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fila seleccionada en el DataGridView
                if (dgRestCat.SelectedRows.Count > 0)
                {
                    // Obtener el id del restaurante y el id de la categoría desde las celdas seleccionadas
                    int idRestaurant = Convert.ToInt32(dgRestCat.SelectedRows[0].Cells["idRestaurant"].Value);
                    int idCategoria = Convert.ToInt32(dgRestCat.SelectedRows[0].Cells["idCategoria"].Value);

                    // Buscar el restaurante y la categoría en la base de datos
                    var restaurante = restaurantContext.Restaurants
                        .Include(r => r.Categories)
                        .FirstOrDefault(r => r.idRestaurant == idRestaurant);
                    var categoria = restaurantContext.Categories
                        .FirstOrDefault(c => c.idCategoria == idCategoria);

                    // Verificar si la relación existe y eliminarla
                    if (restaurante != null && categoria != null && restaurante.Categories.Contains(categoria))
                    {
                        restaurante.Categories.Remove(categoria);
                        ferCanvis();
                        getDades();

                        MessageBox.Show("Categoria eliminada correctament del restaurant.");
                    }
                    else
                    {
                        MessageBox.Show("No s'ha trobat la relació o ja no existeix.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona una fila per eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("S'ha produït un error: " + ex.Message);
            }
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


            var qryResCategories = from r in restaurantContext.Restaurants
                                from c in r.Categories
                                orderby r.idRestaurant, c.idCategoria
                                select new
                                {
                                    r.idRestaurant,
                                    RestaurantName = r.Nom,
                                    c.idCategoria,
                                    CategoryDescription = c.descripcioCategoria
                                };


            dgRestaurants.DataSource = qryRestaurants.ToList();
            dgCategories.DataSource = qryCategoies.ToList();
            dgRestCat.DataSource = qryResCategories.ToList();
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
