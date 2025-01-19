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
    public partial class FrmADMCiutat : Form
    {

        private RestaurantsDBEntities10 restaurantContext { get; set; }

        char op;
        public string pais;
        public string ciutat;

        public FrmADMCiutat(RestaurantsDBEntities10 xres, char xop)
        {
            InitializeComponent();
            restaurantContext = xres;
            op = xop;
        }

        private void FrmADMCiutat_Load(object sender, EventArgs e)
        {
            omplirComboPaisos();
            switch (op)
            {

                case 'A':
                    this.Name = "Afegir Pais";
                    cbPais.SelectedIndex = 0;
                    break;
                case 'D':
                    this.Name = "Eliminar Pais";
                    cbPais.SelectedValue = pais;
                    tbCiutat.Text = ciutat;
                    break;
                case 'M':
                    this.Name = "Modificar Pais";
                    break;
                default:
                    break;
            }
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if ((tbCiutat.Text.Trim().Length == 0) || (cbPais.SelectedItem == null))
            {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            Boolean xb = false;
            if (vDades())
            {
                switch (op)
                {
                    case 'A': xb = addCiutat(); break;
                    case 'D': xb = delCiutat(); break;
                    case 'M': xb = modCiutat(); break;
                }
                if (xb)
                {
                    this.Close();
                }
            }
        }

        private Boolean addCiutat()
        {
            Boolean xb = false;

            Ciutats c = new Ciutats();

            if (vDades())
            {
                c.NomCiutat = tbCiutat.Text;
                c.NomPais = cbPais.SelectedValue.ToString();
                restaurantContext.Ciutats.Add(c);
                if (ferCanvis())
                {
                    ciutat = tbCiutat.Text.Trim();
                    xb = true;
                }
                else
                {
                    pais = "";
                }
            }

            return xb;
        }


        private Boolean delCiutat()
        {
            Boolean xb = false;
            Ciutats c = restaurantContext.Ciutats.Find(tbCiutat.Text.Trim());

            if (c != null)
            {
                restaurantContext.Ciutats.Remove(c);
                xb = ferCanvis();
            }
            return xb;
        }

        private Boolean modCiutat()
        {

            Boolean xb = false;
            Ciutats c = restaurantContext.Ciutats.Find(tbCiutat.Text.Trim());

            if (c != null)
            {
                c.NomCiutat = tbCiutat.Text.Trim();
                c.NomPais = cbPais.SelectedValue.ToString();
                xb = ferCanvis();
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

        private void omplirComboPaisos()
        {
            var qryPaisos = from p in restaurantContext.Paisos
                            orderby p.NomPais
                            select p;


            cbPais.DataSource = qryPaisos.ToList();
            cbPais.DisplayMember = "NomPais";
            cbPais.ValueMember = "NomPais";
            cbPais.SelectedIndex = 0;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            pais = "";
            this.Close();
        }

        
    }
}
