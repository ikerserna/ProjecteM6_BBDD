namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmADMPais
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
            this.cbContinent = new System.Windows.Forms.ComboBox();
            this.tbPais = new System.Windows.Forms.TextBox();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbContinent = new System.Windows.Forms.Label();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbContinent
            // 
            this.cbContinent.FormattingEnabled = true;
            this.cbContinent.Location = new System.Drawing.Point(122, 80);
            this.cbContinent.Name = "cbContinent";
            this.cbContinent.Size = new System.Drawing.Size(158, 21);
            this.cbContinent.TabIndex = 0;
            // 
            // tbPais
            // 
            this.tbPais.Location = new System.Drawing.Point(68, 37);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(212, 20);
            this.tbPais.TabIndex = 1;
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbPais.Location = new System.Drawing.Point(14, 32);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(48, 23);
            this.lbPais.TabIndex = 2;
            this.lbPais.Text = "Pais";
            // 
            // lbContinent
            // 
            this.lbContinent.AutoSize = true;
            this.lbContinent.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbContinent.Location = new System.Drawing.Point(14, 78);
            this.lbContinent.Name = "lbContinent";
            this.lbContinent.Size = new System.Drawing.Size(102, 23);
            this.lbContinent.TabIndex = 3;
            this.lbContinent.Text = "Continent";
            // 
            // btAccept
            // 
            this.btAccept.Location = new System.Drawing.Point(128, 138);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(87, 43);
            this.btAccept.TabIndex = 4;
            this.btAccept.Text = "Acceptar";
            this.btAccept.UseVisualStyleBackColor = true;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCancel.Location = new System.Drawing.Point(221, 138);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(87, 43);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FrmADMPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 200);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.lbContinent);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.cbContinent);
            this.Name = "FrmADMPais";
            this.Text = "FrmADMPais";
            this.Load += new System.EventHandler(this.FrmADMPais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContinent;
        private System.Windows.Forms.TextBox tbPais;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbContinent;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancel;
    }
}