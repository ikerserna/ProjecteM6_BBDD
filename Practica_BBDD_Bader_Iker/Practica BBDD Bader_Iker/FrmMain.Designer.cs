namespace Practica_BBDD_Bader_Iker
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.restaurantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.localsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciutatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galeriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniaturaWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valoracioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tancarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarConexióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurantsToolStripMenuItem,
            this.llocsToolStripMenuItem,
            this.gestioToolStripMenuItem,
            this.tancarToolStripMenuItem,
            this.verificarConexióToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1298, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // restaurantsToolStripMenuItem
            // 
            this.restaurantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.galeriaToolStripMenuItem1,
            this.localsToolStripMenuItem});
            this.restaurantsToolStripMenuItem.Name = "restaurantsToolStripMenuItem";
            this.restaurantsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.restaurantsToolStripMenuItem.Text = "Restaurants";
            // 
            // galeriaToolStripMenuItem1
            // 
            this.galeriaToolStripMenuItem1.Name = "galeriaToolStripMenuItem1";
            this.galeriaToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.galeriaToolStripMenuItem1.Text = "Veure Galeria";
            // 
            // localsToolStripMenuItem
            // 
            this.localsToolStripMenuItem.Name = "localsToolStripMenuItem";
            this.localsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.localsToolStripMenuItem.Text = "Locals";
            // 
            // llocsToolStripMenuItem
            // 
            this.llocsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciutatsToolStripMenuItem,
            this.paisosToolStripMenuItem});
            this.llocsToolStripMenuItem.Name = "llocsToolStripMenuItem";
            this.llocsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.llocsToolStripMenuItem.Text = "Llocs";
            // 
            // ciutatsToolStripMenuItem
            // 
            this.ciutatsToolStripMenuItem.Name = "ciutatsToolStripMenuItem";
            this.ciutatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ciutatsToolStripMenuItem.Text = "Ciutats";
            this.ciutatsToolStripMenuItem.Click += new System.EventHandler(this.ciutatsToolStripMenuItem_Click);
            // 
            // paisosToolStripMenuItem
            // 
            this.paisosToolStripMenuItem.Name = "paisosToolStripMenuItem";
            this.paisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paisosToolStripMenuItem.Text = "Paisos";
            this.paisosToolStripMenuItem.Click += new System.EventHandler(this.paisosToolStripMenuItem_Click);
            // 
            // gestioToolStripMenuItem
            // 
            this.gestioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadesToolStripMenuItem,
            this.galeriaToolStripMenuItem,
            this.miniaturaWikiToolStripMenuItem,
            this.googleMapsToolStripMenuItem,
            this.valoracioToolStripMenuItem});
            this.gestioToolStripMenuItem.Name = "gestioToolStripMenuItem";
            this.gestioToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.gestioToolStripMenuItem.Text = "Gestio";
            // 
            // dadesToolStripMenuItem
            // 
            this.dadesToolStripMenuItem.Name = "dadesToolStripMenuItem";
            this.dadesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dadesToolStripMenuItem.Text = "Dades";
            // 
            // galeriaToolStripMenuItem
            // 
            this.galeriaToolStripMenuItem.Name = "galeriaToolStripMenuItem";
            this.galeriaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.galeriaToolStripMenuItem.Text = "Galeria";
            // 
            // miniaturaWikiToolStripMenuItem
            // 
            this.miniaturaWikiToolStripMenuItem.Name = "miniaturaWikiToolStripMenuItem";
            this.miniaturaWikiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.miniaturaWikiToolStripMenuItem.Text = "Miniatures Wiki";
            // 
            // googleMapsToolStripMenuItem
            // 
            this.googleMapsToolStripMenuItem.Name = "googleMapsToolStripMenuItem";
            this.googleMapsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.googleMapsToolStripMenuItem.Text = "Google Maps";
            // 
            // valoracioToolStripMenuItem
            // 
            this.valoracioToolStripMenuItem.Name = "valoracioToolStripMenuItem";
            this.valoracioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.valoracioToolStripMenuItem.Text = "Valoracions";
            // 
            // tancarToolStripMenuItem
            // 
            this.tancarToolStripMenuItem.Name = "tancarToolStripMenuItem";
            this.tancarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tancarToolStripMenuItem.Text = "Tancar";
            this.tancarToolStripMenuItem.Click += new System.EventHandler(this.tancarToolStripMenuItem_Click);
            // 
            // verificarConexióToolStripMenuItem
            // 
            this.verificarConexióToolStripMenuItem.Name = "verificarConexióToolStripMenuItem";
            this.verificarConexióToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.verificarConexióToolStripMenuItem.Text = "Verificar Conexió";
            this.verificarConexióToolStripMenuItem.Click += new System.EventHandler(this.verificarConexióToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 727);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FrmMain";
            this.Text = "Restaurants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem llocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciutatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniaturaWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valoracioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galeriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem localsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tancarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarConexióToolStripMenuItem;
    }
}

