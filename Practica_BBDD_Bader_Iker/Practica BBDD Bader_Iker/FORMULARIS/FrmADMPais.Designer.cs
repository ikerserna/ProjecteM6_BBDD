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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Pais = new System.Windows.Forms.Label();
            this.lbContinent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.Font = new System.Drawing.Font("Verdana", 14F);
            this.Pais.Location = new System.Drawing.Point(24, 45);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(68, 23);
            this.Pais.TabIndex = 2;
            this.Pais.Text = "label1";
            // 
            // lbContinent
            // 
            this.lbContinent.AutoSize = true;
            this.lbContinent.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbContinent.Location = new System.Drawing.Point(24, 91);
            this.lbContinent.Name = "lbContinent";
            this.lbContinent.Size = new System.Drawing.Size(102, 23);
            this.lbContinent.TabIndex = 3;
            this.lbContinent.Text = "Continent";
            // 
            // FrmADMPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 198);
            this.Controls.Add(this.lbContinent);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmADMPais";
            this.Text = "FrmADMPais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Pais;
        private System.Windows.Forms.Label lbContinent;
    }
}