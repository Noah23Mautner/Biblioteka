using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BIBLIOTEKA2.UpravljanjeK;

namespace BIBLIOTEKA2
{
    
    public partial class UpravljanjeK : Form
    {
        public class Korisnik
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string OIB { get; set; }
            public string Kontakt { get; set; }
        }

        public class Knjiga
        {
            public string Naslov { get; set; }
            public string Autor { get; set; }
            public int Godina { get; set; }
            public string ISBN { get; set; }
            public int BrojPrimjeraka { get; set; }
        }

        List<Korisnik> korisnici = new List<Korisnik>();
        List<Knjiga> knjige = new List<Knjiga>();
        public UpravljanjeK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremiKorisnika_Click(object sender, EventArgs e)
        {
            var k = new Korisnik
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                OIB = txtOIB.Text,
                Kontakt = txtKontakt.Text
            };
            
            korisnici.Add(k);
            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = korisnici;
           
        }

        private void btnSpremiKnjigu_Click(object sender, EventArgs e)
        {
            var knj = new Knjiga
            {
                Naslov = txtNaslov.Text,
                Autor = txtAutor.Text,
                Godina = int.Parse(txtGodina.Text),
                ISBN = txtISBN.Text,
                BrojPrimjeraka = int.Parse(txtPrimjerci.Text)
            };
            
            knjige.Add(knj);
            dgvKnjige.DataSource = null;
            dgvKnjige.DataSource = knjige;
            
        }
    }
}
