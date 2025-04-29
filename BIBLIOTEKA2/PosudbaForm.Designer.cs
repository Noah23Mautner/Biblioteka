namespace BIBLIOTEKA2
{
    partial class PosudbaForm
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
            this.cmbKorisnici = new System.Windows.Forms.ComboBox();
            this.cmbKnjige = new System.Windows.Forms.ComboBox();
            this.dtPosudba = new System.Windows.Forms.DateTimePicker();
            this.dtPovrat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.dgvPosudbe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKorisnici
            // 
            this.cmbKorisnici.FormattingEnabled = true;
            this.cmbKorisnici.Location = new System.Drawing.Point(73, 87);
            this.cmbKorisnici.Name = "cmbKorisnici";
            this.cmbKorisnici.Size = new System.Drawing.Size(121, 24);
            this.cmbKorisnici.TabIndex = 0;
            // 
            // cmbKnjige
            // 
            this.cmbKnjige.FormattingEnabled = true;
            this.cmbKnjige.Location = new System.Drawing.Point(318, 87);
            this.cmbKnjige.Name = "cmbKnjige";
            this.cmbKnjige.Size = new System.Drawing.Size(121, 24);
            this.cmbKnjige.TabIndex = 1;
            // 
            // dtPosudba
            // 
            this.dtPosudba.Location = new System.Drawing.Point(73, 157);
            this.dtPosudba.Name = "dtPosudba";
            this.dtPosudba.Size = new System.Drawing.Size(230, 22);
            this.dtPosudba.TabIndex = 2;
            // 
            // dtPovrat
            // 
            this.dtPovrat.Location = new System.Drawing.Point(318, 157);
            this.dtPovrat.Name = "dtPovrat";
            this.dtPovrat.Size = new System.Drawing.Size(230, 22);
            this.dtPovrat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Knjiga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posudba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Povrat";
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(76, 220);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(171, 45);
            this.btnPosudi.TabIndex = 8;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(318, 220);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(171, 45);
            this.btnVrati.TabIndex = 9;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // dgvPosudbe
            // 
            this.dgvPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosudbe.Location = new System.Drawing.Point(76, 308);
            this.dgvPosudbe.Name = "dgvPosudbe";
            this.dgvPosudbe.RowHeadersWidth = 51;
            this.dgvPosudbe.RowTemplate.Height = 24;
            this.dgvPosudbe.Size = new System.Drawing.Size(413, 150);
            this.dgvPosudbe.TabIndex = 10;
            // 
            // PosudbaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 493);
            this.Controls.Add(this.dgvPosudbe);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPovrat);
            this.Controls.Add(this.dtPosudba);
            this.Controls.Add(this.cmbKnjige);
            this.Controls.Add(this.cmbKorisnici);
            this.Name = "PosudbaForm";
            this.Text = "PosudbaForm";
            this.Load += new System.EventHandler(this.PosudbaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosudbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKorisnici;
        private System.Windows.Forms.ComboBox cmbKnjige;
        private System.Windows.Forms.DateTimePicker dtPosudba;
        private System.Windows.Forms.DateTimePicker dtPovrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnVrati;
        private System.Windows.Forms.DataGridView dgvPosudbe;
    }
}