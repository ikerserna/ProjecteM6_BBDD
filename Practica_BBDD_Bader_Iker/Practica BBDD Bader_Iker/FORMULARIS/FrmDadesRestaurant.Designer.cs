namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmDadesRestaurant
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
            this.tbEnllacWeb = new System.Windows.Forms.TextBox();
            this.pbWeb = new System.Windows.Forms.PictureBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLinkGoogleMaps = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pàgina Web";
            // 
            // tbEnllacWeb
            // 
            this.tbEnllacWeb.Location = new System.Drawing.Point(139, 71);
            this.tbEnllacWeb.Name = "tbEnllacWeb";
            this.tbEnllacWeb.Size = new System.Drawing.Size(263, 20);
            this.tbEnllacWeb.TabIndex = 1;
            // 
            // pbWeb
            // 
            this.pbWeb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbWeb.Location = new System.Drawing.Point(139, 114);
            this.pbWeb.Name = "pbWeb";
            this.pbWeb.Size = new System.Drawing.Size(263, 155);
            this.pbWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWeb.TabIndex = 2;
            this.pbWeb.TabStop = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(215, 275);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 39);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Link Google Maps";
            // 
            // tbLinkGoogleMaps
            // 
            this.tbLinkGoogleMaps.Location = new System.Drawing.Point(200, 396);
            this.tbLinkGoogleMaps.Name = "tbLinkGoogleMaps";
            this.tbLinkGoogleMaps.Size = new System.Drawing.Size(202, 20);
            this.tbLinkGoogleMaps.TabIndex = 5;
            // 
            // FrmDadesRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 635);
            this.Controls.Add(this.tbLinkGoogleMaps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.pbWeb);
            this.Controls.Add(this.tbEnllacWeb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDadesRestaurant";
            this.Text = "FrmDadesRestaurant";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEnllacWeb;
        private System.Windows.Forms.PictureBox pbWeb;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLinkGoogleMaps;
    }
}