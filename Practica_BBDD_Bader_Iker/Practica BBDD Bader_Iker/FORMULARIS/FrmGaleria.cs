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
    public partial class FrmGaleria : Form
    {
        private RestaurantsDBEntities restaurantContext { get; set; } = new RestaurantsDBEntities();
        private int restaurantId;
        private int currentImageIndex = 0;
        private System.Collections.Generic.List<GaleriaImatges> restaurantImages = new System.Collections.Generic.List<GaleriaImatges>();

        public FrmGaleria(RestaurantsDBEntities restaurantContext)
        {
            InitializeComponent();
            this.restaurantContext = restaurantContext;
        }

        private void FrmGaleria_Load(object sender, EventArgs e)
        {
            omplirComboRestaurants();
        }

        private void omplirComboRestaurants()
        {
            var qryRestaurants = from r in restaurantContext.Restaurants
                                 orderby r.Nom
                                 select r;

            cbRestaurants.DataSource = qryRestaurants.ToList();
            cbRestaurants.DisplayMember = "Nom";
            cbRestaurants.ValueMember = "idRestaurant";
            cbRestaurants.SelectedIndexChanged += cbRestaurants_SelectedIndexChanged;
            cbRestaurants.SelectedIndex = 0;
        }

        private void cbRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRestaurants.SelectedValue != null)
            {
                if (int.TryParse(cbRestaurants.SelectedValue.ToString(), out restaurantId))
                {
                    LoadRestaurantImages();
                }
                else
                {
                    MessageBox.Show("El valor seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadRestaurantImages()
        {
            var qryFotos = from f in restaurantContext.GaleriaImatges
                           where f.idRestaurant == restaurantId
                           orderby f.idImatge
                           select f;

            restaurantImages = qryFotos.ToList();
            currentImageIndex = 0;

            if (restaurantImages.Count > 0)
            {
                DisplayCurrentImage();
            }
            else
            {
                MessageBox.Show("Aquest restaurant no té imatges.");
                pbFoto.Image = null;
            }
        }

        private void DisplayCurrentImage()
        {
            if (restaurantImages.Count > 0 && currentImageIndex >= 0 && currentImageIndex < restaurantImages.Count)
            {
                var imageBase64 = restaurantImages[currentImageIndex].imatge;
                pbFoto.Image = ConvertBase64ToImage(imageBase64);
            }
        }

        private System.Drawing.Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new System.IO.MemoryStream(imageBytes))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                DisplayCurrentImage();
            }
        }

        private void btnSeguent_Click(object sender, EventArgs e)
        {
            if (currentImageIndex < restaurantImages.Count - 1)
            {
                currentImageIndex++;
                DisplayCurrentImage();
            }
        }
    }
}
