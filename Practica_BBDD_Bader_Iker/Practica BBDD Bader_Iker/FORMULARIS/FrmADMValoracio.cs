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
    public partial class FrmADMValoracio : Form
    {
        private RestaurantsDBEntitiesIker restaurantContext;
        private Resenyes resenyaActual;
        int valoracioActual;
        Char accio;

        public FrmADMValoracio(RestaurantsDBEntitiesIker restaurantContext, char accio, Resenyes resenya = null)
        {
            InitializeComponent();
            this.restaurantContext = restaurantContext;
            this.accio = accio;
            this.resenyaActual = resenya;
        }

        private void FrmValoracio_Load(object sender, EventArgs e)
        {
            omplirComboRestaurants();
            switch (accio)
            {

                case 'A':
                    this.Name = "Afegir Pais";
                    cbRestaurants.SelectedIndex = 0;
                    break;
                case 'D':
                    this.Name = "Eliminar Pais";
                    cbRestaurants.SelectedValue = resenyaActual.idRestaurant;
                    omplirDadesFormulari();
                    break;
                case 'M':
                    this.Name = "Modificar Pais";
                    omplirDadesFormulari();
                    break;
                default:
                    break;
            }
        }

        private void omplirDadesFormulari()
        {
            if (resenyaActual != null)
            {
                tbUsuari.Text = resenyaActual.nomUsuari;
                tbResenya.Text = resenyaActual.descripcio;
                valoracioActual = resenyaActual.valoracio.GetValueOrDefault();
                cbRestaurants.SelectedValue = resenyaActual.idRestaurant;

                for (int i = 1; i <= 5; i++)
                {
                    PictureBox star = this.Controls.Find("pbEstrella" + i, true).FirstOrDefault() as PictureBox;
                    if (star != null)
                    {
                        star.Image = i <= valoracioActual ? Properties.Resources.estrellaLlena : Properties.Resources.estrellaVacia;
                    }
                }
            }
            else
            {
                MessageBox.Show("No s'ha trobat la ressenya per modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void pbEstrella_Click(object sender, EventArgs e)
        {
            pbEstrella1.Tag = 1;
            pbEstrella2.Tag = 2;
            pbEstrella3.Tag = 3;
            pbEstrella4.Tag = 4;
            pbEstrella5.Tag = 5;

            PictureBox clickedStar = (PictureBox)sender;
            int estrellaValue = int.Parse(clickedStar.Tag.ToString());

            for (int i = 1; i <= 5; i++)
            {
                PictureBox star = this.Controls.Find("pbEstrella" + i, true).FirstOrDefault() as PictureBox;
                if (star != null)
                {
                    star.Image = i <= estrellaValue ? Properties.Resources.estrellaLlena : Properties.Resources.estrellaVacia;
                }
            }
            valoracioActual = estrellaValue;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean xb = false;

            switch (accio)
            {
                case 'A': xb = addResenya(); break;
                case 'B': xb = delResenya(); break;
                case 'M': xb = modResenya(); break;
            }
            if (xb)
            {
                this.Close();
            }
        }

        private bool modResenya()
        {
            Boolean xb = false;
            Resenyes r = restaurantContext.Resenyes.Find(resenyaActual.idResenya);

            if (r != null)
            {
                r.nomUsuari = tbUsuari.Text;
                r.descripcio = tbResenya.Text;
                r.valoracio = valoracioActual;
                xb = ferCanvis();
            }
            return xb;
        }

        private bool delResenya()
        {
            Boolean xb = false;
            Resenyes r = restaurantContext.Resenyes.Find(resenyaActual.idResenya);

            if (r != null)
            {
                restaurantContext.Resenyes.Remove(r);
                xb = ferCanvis();
            }
            return xb;
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
