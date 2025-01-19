using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;

namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    public partial class FrmGestioGaleria : Form
    {
        private RestaurantsDBEntitiesIker1 restaurantContext { get; set; } = new RestaurantsDBEntitiesIker1();
        FrmAGestioGaleria frmADMGestioGaleria = null;
        int restaurantId;

        public FrmGestioGaleria(RestaurantsDBEntitiesIker1 restaurantContext)
        {
            InitializeComponent();
            this.restaurantContext = restaurantContext;
        }

        private void FrmGestioGaleria_Load(object sender, EventArgs e)
        {
            omplirComboRestaurants();
            iniDgrid();
            getDades();
        }

        private void iniDgrid()
        {
            if (dgvGestioGaleria.Columns.Count == 0)
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "imatge";
                imageColumn.HeaderText = "Imatges";
                dgvGestioGaleria.Columns.Add(imageColumn);

                DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
                idColumn.Name = "idImatge";
                idColumn.Visible = false;
                dgvGestioGaleria.Columns.Add(idColumn);
            }
        }

        private void getDades()
        {
            var selectedRestaurantId = cbRestaurants.SelectedValue;
            if (selectedRestaurantId != null)
            {
                if (int.TryParse(selectedRestaurantId.ToString(), out restaurantId))
                {
                    var qryFotos = from f in restaurantContext.GaleriaImatges
                                   where f.idRestaurant == restaurantId
                                   orderby f.idImatge
                                   select f;

                    var fotos = qryFotos.ToList();

                    if (fotos != null && fotos.Count > 0)
                    {
                        dgvGestioGaleria.Rows.Clear();

                        foreach (var foto in fotos)
                        {
                            if (!string.IsNullOrEmpty(foto.imatge))
                            {
                                var imagen = ConvertBase64ToImage(foto.imatge);
                                int rowIndex = dgvGestioGaleria.Rows.Add(imagen);
                                dgvGestioGaleria.Rows[rowIndex].Cells["idImatge"].Value = foto.idImatge;
                            }
                        }
                    }
                    else
                    {
                        dgvGestioGaleria.Rows.Clear();
                    }
                }
            }
        }

        private void omplirComboRestaurants()
        {
            var qryRestaurants = from r in restaurantContext.Restaurants
                                 orderby r.idRestaurant
                                 select r;

            cbRestaurants.DataSource = qryRestaurants.ToList();
            cbRestaurants.DisplayMember = "Nom";
            cbRestaurants.ValueMember = "idRestaurant";

            cbRestaurants.SelectedIndex = 0;
        }

        private void cbRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDades();
        }

        private System.Drawing.Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new System.IO.MemoryStream(imageBytes))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void pbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGestioGaleria.SelectedRows.Count > 0)
            {
                int rowIndex = dgvGestioGaleria.SelectedRows[0].Index;
                var selectedImageId = dgvGestioGaleria.Rows[rowIndex].Cells["idImatge"].Value;

                if (selectedImageId != null)
                {
                    var fotoToDelete = (from f in restaurantContext.GaleriaImatges
                                        where f.idImatge == (int)selectedImageId
                                        select f).FirstOrDefault();

                    if (fotoToDelete != null && MessageBox.Show("Segur que vols eliminar la foto?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        restaurantContext.GaleriaImatges.Remove(fotoToDelete);

                        if (ferCanvis())
                        {
                            dgvGestioGaleria.Rows.RemoveAt(rowIndex);
                        }
                        else
                        {
                            MessageBox.Show("No s'ha pogut eliminar la imatge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Imatge no eliminada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No s'ha trobat l'id de la imatge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccioneu una imatge per eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbAfegir_Click(object sender, EventArgs e)
        {
            frmADMGestioGaleria = new FrmAGestioGaleria(restaurantContext, restaurantId);
            frmADMGestioGaleria.Show();
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
