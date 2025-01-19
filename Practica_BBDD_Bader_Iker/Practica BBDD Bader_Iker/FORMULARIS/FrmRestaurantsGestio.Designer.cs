namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmRestaurantsGestio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgRestaurants = new System.Windows.Forms.DataGridView();
            this.lbLlistaRes = new System.Windows.Forms.Label();
            this.gbAfegir = new System.Windows.Forms.GroupBox();
            this.lbImatge = new System.Windows.Forms.Label();
            this.btFitxer = new System.Windows.Forms.Button();
            this.lbLinkWeb = new System.Windows.Forms.Label();
            this.tbLinkWeb = new System.Windows.Forms.TextBox();
            this.lbLinkMaps = new System.Windows.Forms.Label();
            this.tbLinkMaps = new System.Windows.Forms.TextBox();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btAfegir = new System.Windows.Forms.Button();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.cbCiutats = new System.Windows.Forms.ComboBox();
            this.lbCiutat = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbCodiPostal = new System.Windows.Forms.TextBox();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbCodiPostal = new System.Windows.Forms.Label();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurants)).BeginInit();
            this.gbAfegir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRestaurants
            // 
            this.dgRestaurants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestaurants.Location = new System.Drawing.Point(491, 46);
            this.dgRestaurants.Name = "dgRestaurants";
            this.dgRestaurants.ReadOnly = true;
            this.dgRestaurants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRestaurants.Size = new System.Drawing.Size(458, 454);
            this.dgRestaurants.TabIndex = 1;
            // 
            // lbLlistaRes
            // 
            this.lbLlistaRes.AutoSize = true;
            this.lbLlistaRes.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbLlistaRes.Location = new System.Drawing.Point(486, 12);
            this.lbLlistaRes.Name = "lbLlistaRes";
            this.lbLlistaRes.Size = new System.Drawing.Size(133, 25);
            this.lbLlistaRes.TabIndex = 19;
            this.lbLlistaRes.Text = "Restaurants";
            // 
            // gbAfegir
            // 
            this.gbAfegir.Controls.Add(this.btMod);
            this.gbAfegir.Controls.Add(this.lbImatge);
            this.gbAfegir.Controls.Add(this.btFitxer);
            this.gbAfegir.Controls.Add(this.lbLinkWeb);
            this.gbAfegir.Controls.Add(this.tbLinkWeb);
            this.gbAfegir.Controls.Add(this.lbLinkMaps);
            this.gbAfegir.Controls.Add(this.tbLinkMaps);
            this.gbAfegir.Controls.Add(this.btBorrar);
            this.gbAfegir.Controls.Add(this.btAfegir);
            this.gbAfegir.Controls.Add(this.lbTelefon);
            this.gbAfegir.Controls.Add(this.cbCiutats);
            this.gbAfegir.Controls.Add(this.lbCiutat);
            this.gbAfegir.Controls.Add(this.tbTelefon);
            this.gbAfegir.Controls.Add(this.tbNom);
            this.gbAfegir.Controls.Add(this.lbEmail);
            this.gbAfegir.Controls.Add(this.lbNom);
            this.gbAfegir.Controls.Add(this.tbEmail);
            this.gbAfegir.Controls.Add(this.tbAdresa);
            this.gbAfegir.Controls.Add(this.tbCodiPostal);
            this.gbAfegir.Controls.Add(this.lbAdresa);
            this.gbAfegir.Controls.Add(this.lbCodiPostal);
            this.gbAfegir.Font = new System.Drawing.Font("Verdana", 12F);
            this.gbAfegir.Location = new System.Drawing.Point(1, 12);
            this.gbAfegir.Name = "gbAfegir";
            this.gbAfegir.Size = new System.Drawing.Size(472, 488);
            this.gbAfegir.TabIndex = 21;
            this.gbAfegir.TabStop = false;
            this.gbAfegir.Text = "Afegir/Modificar Restaurant";
            // 
            // lbImatge
            // 
            this.lbImatge.AutoSize = true;
            this.lbImatge.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbImatge.Location = new System.Drawing.Point(9, 356);
            this.lbImatge.Name = "lbImatge";
            this.lbImatge.Size = new System.Drawing.Size(108, 25);
            this.lbImatge.TabIndex = 26;
            this.lbImatge.Text = "Miniatura";
            // 
            // btFitxer
            // 
            this.btFitxer.Font = new System.Drawing.Font("Verdana", 15F);
            this.btFitxer.Location = new System.Drawing.Point(134, 350);
            this.btFitxer.Name = "btFitxer";
            this.btFitxer.Size = new System.Drawing.Size(312, 36);
            this.btFitxer.TabIndex = 25;
            this.btFitxer.Text = "Obrir un fitxer";
            this.btFitxer.UseVisualStyleBackColor = true;
            this.btFitxer.Click += new System.EventHandler(this.btFitxer_Click);
            // 
            // lbLinkWeb
            // 
            this.lbLinkWeb.AutoSize = true;
            this.lbLinkWeb.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbLinkWeb.Location = new System.Drawing.Point(11, 276);
            this.lbLinkWeb.Name = "lbLinkWeb";
            this.lbLinkWeb.Size = new System.Drawing.Size(104, 25);
            this.lbLinkWeb.TabIndex = 24;
            this.lbLinkWeb.Text = "Link Web";
            // 
            // tbLinkWeb
            // 
            this.tbLinkWeb.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbLinkWeb.Location = new System.Drawing.Point(134, 269);
            this.tbLinkWeb.Name = "tbLinkWeb";
            this.tbLinkWeb.Size = new System.Drawing.Size(312, 32);
            this.tbLinkWeb.TabIndex = 23;
            // 
            // lbLinkMaps
            // 
            this.lbLinkMaps.AutoSize = true;
            this.lbLinkMaps.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbLinkMaps.Location = new System.Drawing.Point(6, 314);
            this.lbLinkMaps.Name = "lbLinkMaps";
            this.lbLinkMaps.Size = new System.Drawing.Size(122, 25);
            this.lbLinkMaps.TabIndex = 22;
            this.lbLinkMaps.Text = "Maps Links";
            // 
            // tbLinkMaps
            // 
            this.tbLinkMaps.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbLinkMaps.Location = new System.Drawing.Point(134, 307);
            this.tbLinkMaps.Name = "tbLinkMaps";
            this.tbLinkMaps.Size = new System.Drawing.Size(312, 32);
            this.tbLinkMaps.TabIndex = 21;
            // 
            // btBorrar
            // 
            this.btBorrar.Font = new System.Drawing.Font("Verdana", 15F);
            this.btBorrar.Location = new System.Drawing.Point(310, 404);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(156, 78);
            this.btBorrar.TabIndex = 20;
            this.btBorrar.Text = "Borrar dades";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btAfegir
            // 
            this.btAfegir.Font = new System.Drawing.Font("Verdana", 15F);
            this.btAfegir.Location = new System.Drawing.Point(6, 404);
            this.btAfegir.Name = "btAfegir";
            this.btAfegir.Size = new System.Drawing.Size(150, 78);
            this.btAfegir.TabIndex = 19;
            this.btAfegir.Text = "Afegir";
            this.btAfegir.UseVisualStyleBackColor = true;
            this.btAfegir.Click += new System.EventHandler(this.btAfegir_Click);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbTelefon.Location = new System.Drawing.Point(11, 238);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(84, 25);
            this.lbTelefon.TabIndex = 18;
            this.lbTelefon.Text = "Telèfon";
            // 
            // cbCiutats
            // 
            this.cbCiutats.Font = new System.Drawing.Font("Verdana", 15F);
            this.cbCiutats.FormattingEnabled = true;
            this.cbCiutats.Location = new System.Drawing.Point(134, 78);
            this.cbCiutats.Name = "cbCiutats";
            this.cbCiutats.Size = new System.Drawing.Size(312, 33);
            this.cbCiutats.TabIndex = 4;
            // 
            // lbCiutat
            // 
            this.lbCiutat.AutoSize = true;
            this.lbCiutat.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbCiutat.Location = new System.Drawing.Point(10, 88);
            this.lbCiutat.Name = "lbCiutat";
            this.lbCiutat.Size = new System.Drawing.Size(66, 23);
            this.lbCiutat.TabIndex = 5;
            this.lbCiutat.Text = "Ciutat";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbTelefon.Location = new System.Drawing.Point(134, 231);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(312, 32);
            this.tbTelefon.TabIndex = 17;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbNom.Location = new System.Drawing.Point(134, 38);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(312, 32);
            this.tbNom.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbEmail.Location = new System.Drawing.Point(11, 200);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(65, 25);
            this.lbEmail.TabIndex = 16;
            this.lbEmail.Text = "eMail";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbNom.Location = new System.Drawing.Point(11, 45);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(58, 25);
            this.lbNom.TabIndex = 10;
            this.lbNom.Text = "Nom";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbEmail.Location = new System.Drawing.Point(134, 193);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(312, 32);
            this.tbEmail.TabIndex = 15;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbAdresa.Location = new System.Drawing.Point(134, 117);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(312, 32);
            this.tbAdresa.TabIndex = 11;
            // 
            // tbCodiPostal
            // 
            this.tbCodiPostal.Font = new System.Drawing.Font("Verdana", 15F);
            this.tbCodiPostal.Location = new System.Drawing.Point(134, 155);
            this.tbCodiPostal.Name = "tbCodiPostal";
            this.tbCodiPostal.Size = new System.Drawing.Size(312, 32);
            this.tbCodiPostal.TabIndex = 14;
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbAdresa.Location = new System.Drawing.Point(7, 124);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(81, 25);
            this.lbAdresa.TabIndex = 12;
            this.lbAdresa.Text = "Adreça";
            // 
            // lbCodiPostal
            // 
            this.lbCodiPostal.AutoSize = true;
            this.lbCodiPostal.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbCodiPostal.Location = new System.Drawing.Point(7, 162);
            this.lbCodiPostal.Name = "lbCodiPostal";
            this.lbCodiPostal.Size = new System.Drawing.Size(123, 25);
            this.lbCodiPostal.TabIndex = 13;
            this.lbCodiPostal.Text = "Codi Postal";
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.icons8_delete_100;
            this.pbEliminar.Location = new System.Drawing.Point(955, 400);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(100, 100);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEliminar.TabIndex = 21;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btMod
            // 
            this.btMod.Font = new System.Drawing.Font("Verdana", 15F);
            this.btMod.Location = new System.Drawing.Point(162, 404);
            this.btMod.Name = "btMod";
            this.btMod.Size = new System.Drawing.Size(142, 78);
            this.btMod.TabIndex = 27;
            this.btMod.Text = "Modificar";
            this.btMod.UseVisualStyleBackColor = true;
            this.btMod.Click += new System.EventHandler(this.btMod_Click);
            // 
            // FrmRestaurantsGestio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 512);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.gbAfegir);
            this.Controls.Add(this.lbLlistaRes);
            this.Controls.Add(this.dgRestaurants);
            this.Name = "FrmRestaurantsGestio";
            this.Text = "Gestió Restaurants";
            this.Load += new System.EventHandler(this.FrmRestaurantsGestio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurants)).EndInit();
            this.gbAfegir.ResumeLayout(false);
            this.gbAfegir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgRestaurants;
        private System.Windows.Forms.Label lbLlistaRes;
        private System.Windows.Forms.GroupBox gbAfegir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btAfegir;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.ComboBox cbCiutats;
        private System.Windows.Forms.Label lbCiutat;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbCodiPostal;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbCodiPostal;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbLinkWeb;
        private System.Windows.Forms.TextBox tbLinkWeb;
        private System.Windows.Forms.Label lbLinkMaps;
        private System.Windows.Forms.TextBox tbLinkMaps;
        private System.Windows.Forms.Label lbImatge;
        private System.Windows.Forms.Button btFitxer;
        private System.Windows.Forms.Button btMod;
    }
}