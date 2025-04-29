namespace BIBLIOTEKA2
{
    partial class PregledForm
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
            this.dgvKorisniciPregled = new System.Windows.Forms.DataGridView();
            this.dgvKnjigePregled = new System.Windows.Forms.DataGridView();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.btnObrisiKnjigu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigePregled)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisniciPregled
            // 
            this.dgvKorisniciPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciPregled.Location = new System.Drawing.Point(12, 40);
            this.dgvKorisniciPregled.Name = "dgvKorisniciPregled";
            this.dgvKorisniciPregled.RowHeadersWidth = 51;
            this.dgvKorisniciPregled.RowTemplate.Height = 24;
            this.dgvKorisniciPregled.Size = new System.Drawing.Size(332, 224);
            this.dgvKorisniciPregled.TabIndex = 0;
            // 
            // dgvKnjigePregled
            // 
            this.dgvKnjigePregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKnjigePregled.Location = new System.Drawing.Point(456, 40);
            this.dgvKnjigePregled.Name = "dgvKnjigePregled";
            this.dgvKnjigePregled.RowHeadersWidth = 51;
            this.dgvKnjigePregled.RowTemplate.Height = 24;
            this.dgvKnjigePregled.Size = new System.Drawing.Size(332, 224);
            this.dgvKnjigePregled.TabIndex = 1;
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(12, 303);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(229, 60);
            this.btnObrisiKorisnika.TabIndex = 2;
            this.btnObrisiKorisnika.Text = "Obrisi Korisnika";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.btnObrisiKorisnika_Click);
            // 
            // btnObrisiKnjigu
            // 
            this.btnObrisiKnjigu.Location = new System.Drawing.Point(456, 303);
            this.btnObrisiKnjigu.Name = "btnObrisiKnjigu";
            this.btnObrisiKnjigu.Size = new System.Drawing.Size(229, 60);
            this.btnObrisiKnjigu.TabIndex = 3;
            this.btnObrisiKnjigu.Text = "Obriši knjigu";
            this.btnObrisiKnjigu.UseVisualStyleBackColor = true;
            this.btnObrisiKnjigu.Click += new System.EventHandler(this.btnObrisiKnjigu_Click);
            // 
            // PregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiKnjigu);
            this.Controls.Add(this.btnObrisiKorisnika);
            this.Controls.Add(this.dgvKnjigePregled);
            this.Controls.Add(this.dgvKorisniciPregled);
            this.Name = "PregledForm";
            this.Text = "PregledForm";
            this.Load += new System.EventHandler(this.PregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKnjigePregled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisniciPregled;
        private System.Windows.Forms.DataGridView dgvKnjigePregled;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private System.Windows.Forms.Button btnObrisiKnjigu;
    }
}