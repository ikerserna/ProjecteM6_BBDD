using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Entity;

namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    public partial class FrmAGestioGaleria : Form
    {
        private RestaurantsDBEntities10 restaurantContext { get; set; }
        private string rutaImagen;
        public int idRestauranteSeleccionado;

        public FrmAGestioGaleria(RestaurantsDBEntities10 xres, int idRestaurante)
        {
            InitializeComponent();
            restaurantContext = xres;
            idRestauranteSeleccionado = idRestaurante;
        }

        private void FrmADMGestioGaleria_Load(object sender, EventArgs e)
        {
            rutaImagen = string.Empty;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imatges (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Seleccionar imatge";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = openFileDialog.FileName;
                try
                {
                    pbPreview.Image = new System.Drawing.Bitmap(rutaImagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al carregar la imatge: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAcceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaImagen))
            {
                MessageBox.Show("Cal seleccionar una imatge abans de continuar.", "Advertència", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Boolean exito = false;

            if (vDades())
            {
                exito = afegirImatge();
            }

            if (exito)
            {
                this.Close();
            }
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if (pbPreview.Image == null)
            {
                MessageBox.Show("No es pot deixar la imatge en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private Boolean afegirImatge()
        {
            Boolean xb = false;
            GaleriaImatges i = new GaleriaImatges();

            try
            {
                i.imatge = ConvertirImagenBase64(rutaImagen);

                var qryFotos = from f in restaurantContext.GaleriaImatges
                               where f.idRestaurant == idRestauranteSeleccionado
                               orderby f.idImatge descending
                               select f;

                int nextId = qryFotos.Any() ? qryFotos.First().idImatge + 1 : 1;

                i.idImatge = nextId;

                i.idRestaurant = idRestauranteSeleccionado;

                restaurantContext.GaleriaImatges.Add(i);

                if (ferCanvis())
                {
                    xb = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imatge: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xb;
        }

        private string ConvertirImagenBase64(string rutaImagen)
        {
            byte[] imagenBytes = File.ReadAllBytes(rutaImagen);
            return Convert.ToBase64String(imagenBytes);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
