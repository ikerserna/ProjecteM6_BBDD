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
    public partial class FrmADMPais : Form
    {

        private RestaurantsDBEntities10 restaurantContext { get; set; }

        char op;
        public string pais;
        public string continent;

        public FrmADMPais(RestaurantsDBEntities10 xres, char xop)
        {
            InitializeComponent();
            restaurantContext = xres;
            op = xop;
        }

        private void FrmADMPais_Load(object sender, EventArgs e)
        {
            omplirComboContinents();
            switch (op)
            {

                case 'A': this.Name = "Afegir Pais";
                    cbContinent.SelectedIndex = 0;
                    break;
                case 'D': this.Name = "Eliminar Pais";    
                    cbContinent.SelectedValue = continent;
                    tbPais.Text = pais;
                    break;
                case 'M': this.Name = "Modificar Pais";
                    break;
                default:
                    break;
            }
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            Boolean xb = false;
            if (vDades())
            {
                switch (op)
                {
                    case 'A': xb = addPais(); break;
                    case 'B': xb = delPais(); break;
                    case 'M': xb = modPais(); break;
                }
                if (xb)
                {
                    this.Close();
                }
            }
        }

        private Boolean vDades()
        {
            Boolean xb = true;

            if ((tbPais.Text.Trim().Length == 0) || (cbContinent.SelectedItem == null))
            {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        private Boolean addPais()
        {
            Boolean xb = false;

            Paisos p = new Paisos();

            if (vDades())
            {
                p.NomPais = tbPais.Text;
                p.NomContinent = cbContinent.SelectedValue.ToString();
                restaurantContext.Paisos.Add(p);
                if (ferCanvis())
                {
                    pais = tbPais.Text.Trim();
                    xb = true;
                }
                else
                {
                    pais = "";
                }
            }

            return xb;
        }


        private Boolean delPais()
        {
            Boolean xb = false;
            Paisos p = restaurantContext.Paisos.Find(tbPais.Text.Trim());  

            if (p != null)
            {
                restaurantContext.Paisos.Remove(p);
                xb = ferCanvis();
            }
            return xb;
        }

        private Boolean modPais()
        {
          
            Boolean xb = false;
            Paisos p = restaurantContext.Paisos.Find(tbPais.Text.Trim());  

            if (p != null)
            {
                p.NomPais = tbPais.Text.Trim();
                p.NomContinent = cbContinent.SelectedValue.ToString();
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


        

        private void omplirComboContinents()
        {
            var qryContinents = from c in restaurantContext.Continents
                                orderby c.NomContinent
                                select c;


            cbContinent.DataSource = qryContinents.ToList();
            cbContinent.DisplayMember = "NomContinent";
            cbContinent.ValueMember = "NomContinent";
            cbContinent.SelectedIndex = 0;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            pais = "";
            this.Close();
        }
    }
}
