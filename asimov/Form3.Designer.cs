namespace asimov
{
    partial class Form3
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
            this.labelNom = new System.Windows.Forms.Label();
            this.cbListeEleve = new System.Windows.Forms.ComboBox();
            this.labelTitreListe = new System.Windows.Forms.Label();
            this.dataGridViewScolarite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScolarite)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(46, 9);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(0, 16);
            this.labelNom.TabIndex = 0;
            // 
            // cbListeEleve
            // 
            this.cbListeEleve.FormattingEnabled = true;
            this.cbListeEleve.Location = new System.Drawing.Point(15, 61);
            this.cbListeEleve.Name = "cbListeEleve";
            this.cbListeEleve.Size = new System.Drawing.Size(334, 24);
            this.cbListeEleve.TabIndex = 1;
            this.cbListeEleve.SelectedIndexChanged += new System.EventHandler(this.cbListeEleve_SelectedIndexChanged);
            // 
            // labelTitreListe
            // 
            this.labelTitreListe.AutoSize = true;
            this.labelTitreListe.Location = new System.Drawing.Point(12, 42);
            this.labelTitreListe.Name = "labelTitreListe";
            this.labelTitreListe.Size = new System.Drawing.Size(111, 16);
            this.labelTitreListe.TabIndex = 2;
            this.labelTitreListe.Text = "Liste des élèves :";
            // 
            // dataGridViewScolarite
            // 
            this.dataGridViewScolarite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScolarite.Location = new System.Drawing.Point(15, 113);
            this.dataGridViewScolarite.Name = "dataGridViewScolarite";
            this.dataGridViewScolarite.RowHeadersWidth = 51;
            this.dataGridViewScolarite.Size = new System.Drawing.Size(720, 298);
            this.dataGridViewScolarite.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewScolarite);
            this.Controls.Add(this.labelTitreListe);
            this.Controls.Add(this.cbListeEleve);
            this.Controls.Add(this.labelNom);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScolarite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.ComboBox cbListeEleve;
        private System.Windows.Forms.Label labelTitreListe;
        private System.Windows.Forms.DataGridView dataGridViewScolarite;
    }
}