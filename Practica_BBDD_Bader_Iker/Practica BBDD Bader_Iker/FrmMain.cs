using Practica_BBDD_Bader_Iker.FORMULARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_BBDD_Bader_Iker
{
    public partial class FrmMain : Form
    {

        private RestaurantsDBEntities10 restaurantContext { get; set; } = new RestaurantsDBEntities10();
        

        FrmPaisos frmPaisos = null;
        FrmCiutats frmCiutats = null;
        FrmCategories frmCategories = null;
        FrmGestioGaleria frmGestioGaleria = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void paisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Països";

            if (!(ja_esta_obert(xnom)))
            {
                frmPaisos = new FrmPaisos(restaurantContext); 
                frmPaisos.Name = xnom;
                frmPaisos.MdiParent = this;
                frmPaisos.Show();
            }
            frmPaisos.Activate();
        }
        private void ciutatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Ciutats";

            if (!(ja_esta_obert(xnom)))
            {
                frmCiutats = new FrmCiutats(restaurantContext);
                frmCiutats.Name = xnom;
                frmCiutats.MdiParent = this;
                frmCiutats.Show();
            }
            frmCiutats.Activate();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Categories";

            if (!(ja_esta_obert(xnom)))
            {
                frmCategories = new FrmCategories(restaurantContext);
                frmCategories.Name = xnom;
                frmCategories.MdiParent = this;
                frmCategories.Show();
            }
            frmCategories.Activate();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            verificarConnexio();
        }

        private void verificarConnexio()
        {
            Boolean xb = testConnexio();

            restaurantsToolStripMenuItem.Enabled = xb;
            llocsToolStripMenuItem.Enabled = xb;
            gestioToolStripMenuItem.Enabled = xb;  
            verificarConexióToolStripMenuItem.Enabled = !xb;
        }

        private Boolean testConnexio()
        {
            Boolean xb = false;

            Cursor = Cursors.WaitCursor;
            try
            {
                xb = (restaurantContext.Database.Connection.State == ConnectionState.Open);
                if (!xb)
                {
                    restaurantContext.Database.Connection.Open();
                    xb = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Cursor = Cursors.Default;
            return xb;
        }

        private Boolean ja_esta_obert(String xnom)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom);
                x1++;
            }
            return (xb);
        }

        private void tancarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void verificarConexióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verificarConnexio();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Gestió Galeria";

            if (!(ja_esta_obert(xnom)))
            {
                frmGestioGaleria = new FrmGestioGaleria(restaurantContext);
                frmGestioGaleria.Name = xnom;
                frmGestioGaleria.MdiParent = this;
                frmGestioGaleria.Show();
            }
            frmGestioGaleria.Activate();
        }

        private void dadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
