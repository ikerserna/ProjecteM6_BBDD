namespace Practica_BBDD_Bader_Iker.FORMULARIS
{
    partial class FrmPaisos
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
            this.dgPaisos = new System.Windows.Forms.DataGridView();
            this.cbContinents = new System.Windows.Forms.ComboBox();
            this.cbxTots = new System.Windows.Forms.CheckBox();
            this.lbContinents = new System.Windows.Forms.Label();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPaisos
            // 
            this.dgPaisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPaisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaisos.Location = new System.Drawing.Point(12, 75);
            this.dgPaisos.Name = "dgPaisos";
            this.dgPaisos.Size = new System.Drawing.Size(489, 371);
            this.dgPaisos.TabIndex = 0;
            // 
            // cbContinents
            // 
            this.cbContinents.FormattingEnabled = true;
            this.cbContinents.Location = new System.Drawing.Point(130, 32);
            this.cbContinents.Name = "cbContinents";
            this.cbContinents.Size = new System.Drawing.Size(171, 21);
            this.cbContinents.TabIndex = 1;
            this.cbContinents.SelectedIndexChanged += new System.EventHandler(this.cbContinents_SelectedIndexChanged);
            // 
            // cbxTots
            // 
            this.cbxTots.AutoSize = true;
            this.cbxTots.Checked = true;
            this.cbxTots.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTots.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cbxTots.Location = new System.Drawing.Point(307, 28);
            this.cbxTots.Name = "cbxTots";
            this.cbxTots.Size = new System.Drawing.Size(194, 29);
            this.cbxTots.TabIndex = 2;
            this.cbxTots.Text = "Tots els continents";
            this.cbxTots.UseVisualStyleBackColor = true;
            this.cbxTots.CheckedChanged += new System.EventHandler(this.cbxTots_CheckedChanged);
            // 
            // lbContinents
            // 
            this.lbContinents.AutoSize = true;
            this.lbContinents.Font = new System.Drawing.Font("Verdana", 14F);
            this.lbContinents.Location = new System.Drawing.Point(12, 30);
            this.lbContinents.Name = "lbContinents";
            this.lbContinents.Size = new System.Drawing.Size(112, 23);
            this.lbContinents.TabIndex = 3;
            this.lbContinents.Text = "Continents";
            // 
            // pbDel
            // 
            this.pbDel.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.remove;
            this.pbDel.Location = new System.Drawing.Point(622, 362);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(66, 84);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 5;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::Practica_BBDD_Bader_Iker.Properties.Resources.icons8_add_100;
            this.pbAdd.Location = new System.Drawing.Point(516, 359);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(98, 89);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 4;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // FrmPaisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 460);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.lbContinents);
            this.Controls.Add(this.cbxTots);
            this.Controls.Add(this.cbContinents);
            this.Controls.Add(this.dgPaisos);
            this.Name = "FrmPaisos";
            this.Text = "Països";
            this.Load += new System.EventHandler(this.FrmPaisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPaisos;
        private System.Windows.Forms.ComboBox cbContinents;
        private System.Windows.Forms.CheckBox cbxTots;
        private System.Windows.Forms.Label lbContinents;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
    }
}