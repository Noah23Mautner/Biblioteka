namespace BIBLIOTEKA2
{
    partial class Form1
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
            this.btnUpravljanje = new System.Windows.Forms.Button();
            this.btnPosudba = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpravljanje
            // 
            this.btnUpravljanje.Location = new System.Drawing.Point(52, 51);
            this.btnUpravljanje.Name = "btnUpravljanje";
            this.btnUpravljanje.Size = new System.Drawing.Size(227, 48);
            this.btnUpravljanje.TabIndex = 0;
            this.btnUpravljanje.Text = "Upravljanje korisnicima i knjigama";
            this.btnUpravljanje.UseVisualStyleBackColor = true;
            this.btnUpravljanje.Click += new System.EventHandler(this.btnUpravljanje_Click);
            // 
            // btnPosudba
            // 
            this.btnPosudba.Location = new System.Drawing.Point(52, 132);
            this.btnPosudba.Name = "btnPosudba";
            this.btnPosudba.Size = new System.Drawing.Size(227, 48);
            this.btnPosudba.TabIndex = 1;
            this.btnPosudba.Text = "Posudba i povrat knjiga";
            this.btnPosudba.UseVisualStyleBackColor = true;
            this.btnPosudba.Click += new System.EventHandler(this.btnPosudba_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(52, 213);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(227, 48);
            this.btnPregled.TabIndex = 2;
            this.btnPregled.Text = "Pregled korisnika i knjiga\n";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 307);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnPosudba);
            this.Controls.Add(this.btnUpravljanje);
            this.Name = "Form1";
            this.Text = "DashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpravljanje;
        private System.Windows.Forms.Button btnPosudba;
        private System.Windows.Forms.Button btnPregled;
    }
}

