namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmGestioGaleria
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbRestaurants = new System.Windows.Forms.ComboBox();
            this.dgvGestioGaleria = new System.Windows.Forms.DataGridView();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.pbAfegir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestioGaleria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfegir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurants";
            // 
            // cbRestaurants
            // 
            this.cbRestaurants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestaurants.FormattingEnabled = true;
            this.cbRestaurants.Location = new System.Drawing.Point(142, 14);
            this.cbRestaurants.Name = "cbRestaurants";
            this.cbRestaurants.Size = new System.Drawing.Size(347, 21);
            this.cbRestaurants.TabIndex = 1;
            this.cbRestaurants.SelectedIndexChanged += new System.EventHandler(this.cbRestaurants_SelectedIndexChanged);
            // 
            // dgvGestioGaleria
            // 
            this.dgvGestioGaleria.AllowUserToAddRows = false;
            this.dgvGestioGaleria.AllowUserToDeleteRows = false;
            this.dgvGestioGaleria.AllowUserToResizeColumns = false;
            this.dgvGestioGaleria.AllowUserToResizeRows = false;
            this.dgvGestioGaleria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGestioGaleria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGestioGaleria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestioGaleria.Location = new System.Drawing.Point(17, 61);
            this.dgvGestioGaleria.Name = "dgvGestioGaleria";
            this.dgvGestioGaleria.RowTemplate.Height = 100;
            this.dgvGestioGaleria.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGestioGaleria.Size = new System.Drawing.Size(472, 358);
            this.dgvGestioGaleria.TabIndex = 2;
            // 
            // pbEliminar
            // 
            this.pbEliminar.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.remove;
            this.pbEliminar.Location = new System.Drawing.Point(595, 353);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(59, 57);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 4;
            this.pbEliminar.TabStop = false;
            this.pbEliminar.Click += new System.EventHandler(this.pbEliminar_Click);
            // 
            // pbAfegir
            // 
            this.pbAfegir.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.icons8_add_100;
            this.pbAfegir.Location = new System.Drawing.Point(512, 344);
            this.pbAfegir.Name = "pbAfegir";
            this.pbAfegir.Size = new System.Drawing.Size(77, 75);
            this.pbAfegir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfegir.TabIndex = 3;
            this.pbAfegir.TabStop = false;
            this.pbAfegir.Click += new System.EventHandler(this.pbAfegir_Click);
            // 
            // FrmGestioGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.pbAfegir);
            this.Controls.Add(this.dgvGestioGaleria);
            this.Controls.Add(this.cbRestaurants);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestioGaleria";
            this.Text = "FrmGestioGaleria";
            this.Load += new System.EventHandler(this.FrmGestioGaleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestioGaleria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfegir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRestaurants;
        private System.Windows.Forms.DataGridView dgvGestioGaleria;
        private System.Windows.Forms.PictureBox pbAfegir;
        private System.Windows.Forms.PictureBox pbEliminar;
    }
}