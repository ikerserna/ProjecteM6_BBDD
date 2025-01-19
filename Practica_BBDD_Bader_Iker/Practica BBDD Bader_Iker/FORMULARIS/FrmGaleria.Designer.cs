namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmGaleria
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
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSeguent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurants";
            // 
            // cbRestaurants
            // 
            this.cbRestaurants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestaurants.FormattingEnabled = true;
            this.cbRestaurants.Location = new System.Drawing.Point(141, 13);
            this.cbRestaurants.Name = "cbRestaurants";
            this.cbRestaurants.Size = new System.Drawing.Size(398, 21);
            this.cbRestaurants.TabIndex = 1;
            this.cbRestaurants.SelectedIndexChanged += new System.EventHandler(this.cbRestaurants_SelectedIndexChanged);
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.camera_off;
            this.pbFoto.Location = new System.Drawing.Point(141, 65);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(398, 328);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 2;
            this.pbFoto.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(12, 213);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(82, 39);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSeguent
            // 
            this.btnSeguent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguent.Location = new System.Drawing.Point(580, 213);
            this.btnSeguent.Name = "btnSeguent";
            this.btnSeguent.Size = new System.Drawing.Size(98, 39);
            this.btnSeguent.TabIndex = 4;
            this.btnSeguent.Text = "Següent";
            this.btnSeguent.UseVisualStyleBackColor = true;
            this.btnSeguent.Click += new System.EventHandler(this.btnSeguent_Click);
            // 
            // FrmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.btnSeguent);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.cbRestaurants);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGaleria";
            this.Text = "FrmGaleria";
            this.Load += new System.EventHandler(this.FrmGaleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRestaurants;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSeguent;
    }
}