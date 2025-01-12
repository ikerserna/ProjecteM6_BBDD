namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmADMCiutat
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbCiutat = new System.Windows.Forms.Label();
            this.tbCiutat = new System.Windows.Forms.TextBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(227, 125);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(87, 43);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(134, 125);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(87, 43);
            this.btAccept.TabIndex = 10;
            this.btAccept.Text = "Acceptar";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbPais.Location = new System.Drawing.Point(20, 65);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(48, 23);
            this.lbPais.TabIndex = 9;
            this.lbPais.Text = "Pais";
            // 
            // lbCiutat
            // 
            this.lbCiutat.AutoSize = true;
            this.lbCiutat.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbCiutat.Location = new System.Drawing.Point(20, 19);
            this.lbCiutat.Name = "lbCiutat";
            this.lbCiutat.Size = new System.Drawing.Size(66, 23);
            this.lbCiutat.TabIndex = 8;
            this.lbCiutat.Text = "Ciutat";
            // 
            // tbCiutat
            // 
            this.tbCiutat.Location = new System.Drawing.Point(92, 24);
            this.tbCiutat.Name = "tbCiutat";
            this.tbCiutat.Size = new System.Drawing.Size(212, 20);
            this.tbCiutat.TabIndex = 7;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(128, 67);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(158, 21);
            this.cbPais.TabIndex = 6;
            // 
            // FrmADMCiutat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 184);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.lbCiutat);
            this.Controls.Add(this.tbCiutat);
            this.Controls.Add(this.cbPais);
            this.Name = "FrmADMCiutat";
            this.Text = "Ciutat";
            this.Load += new System.EventHandler(this.FrmADMCiutat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbCiutat;
        private System.Windows.Forms.TextBox tbCiutat;
        private System.Windows.Forms.ComboBox cbPais;
    }
}