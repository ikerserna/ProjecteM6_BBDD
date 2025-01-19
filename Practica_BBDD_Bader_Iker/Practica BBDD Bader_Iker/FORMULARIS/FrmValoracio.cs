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
    public partial class FrmValoracio : Form
    {
        private RestaurantsDBEntitiesIker restaurantContext;
        int valoracioActual;

        public FrmValoracio(RestaurantsDBEntitiesIker restaurantContext)
        {
            InitializeComponent();
            this.restaurantContext = restaurantContext;
        }

        private void FrmValoracio_Load(object sender, EventArgs e)
        {
            omplirComboRestaurants();
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

        private void pbEstrella_Click(object sender, EventArgs e)
        {
            pbEstrella1.Tag = 1;
            pbEstrella2.Tag = 2;
            pbEstrella3.Tag = 3;
            pbEstrella4.Tag = 4;
            pbEstrella5.Tag = 5;

            PictureBox clickedStar = (PictureBox)sender;
            int starValue = int.Parse(clickedStar.Tag.ToString());

            for (int i = 1; i <= 5; i++)
            {
                PictureBox star = this.Controls.Find("pbEstrella" + i, true).FirstOrDefault() as PictureBox;
                if (star != null)
                {
                    star.Image = i <= starValue ? Properties.Resources.estrellaLlena : Properties.Resources.estrellaVacia;
                }
            }
            valoracioActual = starValue;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean xb = false;

            if (vDades())
            {
                xb = addResenya();
            }

            if (xb)
            {
                this.Close();
            }
        }

        private bool addResenya()
        {
            Boolean xb = false;
            Resenyes rs = new Resenyes();

            try
            {
                var qryIdResenya = from r in restaurantContext.Resenyes
                                   orderby r.idResenya descending
                                   select r;

                int nextId = qryIdResenya.Any() ? qryIdResenya.First().idResenya + 1 : 1;

                rs.idResenya = nextId;
                rs.nomUsuari = tbUsuari.Text;
                rs.descripcio = tbResenya.Text;
                rs.valoracio = valoracioActual;
                rs.idRestaurant = cbRestaurants.SelectedIndex;

                if (ferCanvis())
                {
                    xb = true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al guardar la resenya: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        private bool ferCanvis()
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

        private bool vDades()
        {
            Boolean xb = true;
            if ((tbUsuari.Text.Trim().Length == 0) || (cbRestaurants.SelectedItem == null) || (tbResenya.Text.Trim().Length == 0) || (valoracioActual == 0))
            {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
