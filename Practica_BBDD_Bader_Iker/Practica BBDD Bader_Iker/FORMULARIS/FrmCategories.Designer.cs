namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmCategories
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
            this.dgRestCat = new System.Windows.Forms.DataGridView();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.dgRestaurants = new System.Windows.Forms.DataGridView();
            this.btAfegir = new System.Windows.Forms.Button();
            this.gbCat = new System.Windows.Forms.GroupBox();
            this.lbCat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.lbRestaurants = new System.Windows.Forms.Label();
            this.lbResCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurants)).BeginInit();
            this.gbCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRestCat
            // 
            this.dgRestCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRestCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestCat.Location = new System.Drawing.Point(491, 50);
            this.dgRestCat.Name = "dgRestCat";
            this.dgRestCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRestCat.Size = new System.Drawing.Size(487, 432);
            this.dgRestCat.TabIndex = 7;
            // 
            // dgCategories
            // 
            this.dgCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Location = new System.Drawing.Point(150, 76);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategories.Size = new System.Drawing.Size(288, 252);
            this.dgCategories.TabIndex = 8;
            // 
            // dgRestaurants
            // 
            this.dgRestaurants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRestaurants.Location = new System.Drawing.Point(12, 50);
            this.dgRestaurants.Name = "dgRestaurants";
            this.dgRestaurants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRestaurants.Size = new System.Drawing.Size(448, 207);
            this.dgRestaurants.TabIndex = 9;
            // 
            // btAfegir
            // 
            this.btAfegir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAfegir.Font = new System.Drawing.Font("Verdana", 15F);
            this.btAfegir.Location = new System.Drawing.Point(491, 494);
            this.btAfegir.Name = "btAfegir";
            this.btAfegir.Size = new System.Drawing.Size(487, 125);
            this.btAfegir.TabIndex = 16;
            this.btAfegir.Text = "Afegir Categoria al Restaurant Seleccionat";
            this.btAfegir.UseVisualStyleBackColor = false;
            this.btAfegir.Click += new System.EventHandler(this.btAfegir_Click);
            // 
            // gbCat
            // 
            this.gbCat.BackColor = System.Drawing.Color.Transparent;
            this.gbCat.Controls.Add(this.lbCat);
            this.gbCat.Controls.Add(this.textBox1);
            this.gbCat.Controls.Add(this.dgCategories);
            this.gbCat.Controls.Add(this.pbAdd);
            this.gbCat.Controls.Add(this.pbDel);
            this.gbCat.Font = new System.Drawing.Font("Verdana", 15F);
            this.gbCat.Location = new System.Drawing.Point(12, 274);
            this.gbCat.Name = "gbCat";
            this.gbCat.Size = new System.Drawing.Size(459, 345);
            this.gbCat.TabIndex = 17;
            this.gbCat.TabStop = false;
            this.gbCat.Text = "Gestió Categories";
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.BackColor = System.Drawing.Color.Transparent;
            this.lbCat.Font = new System.Drawing.Font("Verdana", 12F);
            this.lbCat.Location = new System.Drawing.Point(10, 44);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(134, 18);
            this.lbCat.TabIndex = 20;
            this.lbCat.Text = "Nova Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 32);
            this.textBox1.TabIndex = 15;
            // 
            // pbAdd
            // 
            this.pbAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbAdd.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.icons8_add_100;
            this.pbAdd.Location = new System.Drawing.Point(14, 94);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(127, 114);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 13;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbDel
            // 
            this.pbDel.BackColor = System.Drawing.Color.Transparent;
            this.pbDel.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.remove;
            this.pbDel.Location = new System.Drawing.Point(28, 214);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(92, 94);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 14;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // lbRestaurants
            // 
            this.lbRestaurants.AutoSize = true;
            this.lbRestaurants.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbRestaurants.Location = new System.Drawing.Point(13, 12);
            this.lbRestaurants.Name = "lbRestaurants";
            this.lbRestaurants.Size = new System.Drawing.Size(133, 25);
            this.lbRestaurants.TabIndex = 18;
            this.lbRestaurants.Text = "Restaurants";
            // 
            // lbResCat
            // 
            this.lbResCat.AutoSize = true;
            this.lbResCat.Font = new System.Drawing.Font("Verdana", 15F);
            this.lbResCat.Location = new System.Drawing.Point(497, 12);
            this.lbResCat.Name = "lbResCat";
            this.lbResCat.Size = new System.Drawing.Size(260, 25);
            this.lbResCat.TabIndex = 19;
            this.lbResCat.Text = "Restaurants i Categories";
            // 
            // FrmCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 631);
            this.Controls.Add(this.lbResCat);
            this.Controls.Add(this.lbRestaurants);
            this.Controls.Add(this.gbCat);
            this.Controls.Add(this.btAfegir);
            this.Controls.Add(this.dgRestaurants);
            this.Controls.Add(this.dgRestCat);
            this.Name = "FrmCategories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FrmCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRestCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRestaurants)).EndInit();
            this.gbCat.ResumeLayout(false);
            this.gbCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRestCat;
        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.DataGridView dgRestaurants;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Button btAfegir;
        private System.Windows.Forms.GroupBox gbCat;
        private System.Windows.Forms.Label lbRestaurants;
        private System.Windows.Forms.Label lbResCat;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.TextBox textBox1;
    }
}