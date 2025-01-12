namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmCiutats
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
            this.lbContinents = new System.Windows.Forms.Label();
            this.cbxTots = new System.Windows.Forms.CheckBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.dgCiutats = new System.Windows.Forms.DataGridView();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCiutats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContinents
            // 
            this.lbContinents.AutoSize = true;
            this.lbContinents.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbContinents.Location = new System.Drawing.Point(12, 13);
            this.lbContinents.Name = "lbContinents";
            this.lbContinents.Size = new System.Drawing.Size(70, 23);
            this.lbContinents.TabIndex = 9;
            this.lbContinents.Text = "Països";
            // 
            // cbxTots
            // 
            this.cbxTots.AutoSize = true;
            this.cbxTots.Checked = true;
            this.cbxTots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTots.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxTots.Location = new System.Drawing.Point(276, 11);
            this.cbxTots.Name = "cbxTots";
            this.cbxTots.Size = new System.Drawing.Size(162, 29);
            this.cbxTots.TabIndex = 8;
            this.cbxTots.Text = "Tots els països";
            this.cbxTots.UseVisualStyleBackColor = true;
            this.cbxTots.CheckedChanged += new System.EventHandler(this.cbxTots_CheckedChanged);
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(88, 15);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(171, 21);
            this.cbPais.TabIndex = 7;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // dgCiutats
            // 
            this.dgCiutats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCiutats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCiutats.Location = new System.Drawing.Point(12, 58);
            this.dgCiutats.Name = "dgCiutats";
            this.dgCiutats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCiutats.Size = new System.Drawing.Size(426, 371);
            this.dgCiutats.TabIndex = 6;
            // 
            // pbDel
            // 
            this.pbDel.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.remove;
            this.pbDel.Location = new System.Drawing.Point(566, 343);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(66, 84);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 11;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.icons8_add_100;
            this.pbAdd.Location = new System.Drawing.Point(460, 340);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(98, 89);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 10;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // FrmCiutats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lbContinents);
            this.Controls.Add(this.cbxTots);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.dgCiutats);
            this.Name = "FrmCiutats";
            this.Text = "Ciutats";
            this.Load += new System.EventHandler(this.FrmCiutats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCiutats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.Label lbContinents;
        private System.Windows.Forms.CheckBox cbxTots;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.DataGridView dgCiutats;
    }
}