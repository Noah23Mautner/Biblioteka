using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BIBLIOTEKA2.Models;
using static BIBLIOTEKA2.UpravljanjeK;

namespace BIBLIOTEKA2
{
    
    public partial class UpravljanjeK : Form
    {
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
            string ime = txtIme.Text.Trim();
            string prezime = txtPrezime.Text.Trim();
            string oibText = txtOIB.Text.Trim();
            string kontakt = txtKontakt.Text.Trim();

            // Provjera praznih polja
            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(oibText) ||
                string.IsNullOrWhiteSpace(kontakt))
            {
                MessageBox.Show("Sva polja moraju biti ispunjena!");
                return;
            }

            // Provjera da Ime i Prezime ne sadrže brojeve
            if (ime.Any(char.IsDigit) || prezime.Any(char.IsDigit))
            {
                MessageBox.Show("Ime i Prezime ne smiju sadržavati brojeve!");
                return;
            }

            // Provjera OIB-a: mora biti broj i imati točno 11 znamenki
            if (!long.TryParse(oibText, out long oib) || oibText.Length != 11)
            {
                MessageBox.Show("OIB mora biti broj i imati točno 11 znamenki!");
                return;
            }

            Korisnik novi = new Korisnik
            {
                Ime = ime,
                Prezime = prezime,
                OIB = oibText,
                Kontakt = kontakt
            };

            korisnici.Add(novi);
            XmlHelper.SpremiXml(korisnici, "korisnici.xml");
            OsvjeziKorisnike();

        }

        private void btnSpremiKnjigu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGodina.Text, out int godina))
            {
                MessageBox.Show("Godina mora biti cijeli broj!");
                return;
            }

            if (!int.TryParse(txtPrimjerci.Text, out int primjerci))
            {
                MessageBox.Show("Broj primjeraka mora biti cijeli broj!");
                return;
            }

            Knjiga nova = new Knjiga
            {
                Naslov = txtNaslov.Text,
                Autor = txtAutor.Text,
                Godina = godina,
                ISBN = txtISBN.Text,
                BrojPrimjeraka = primjerci
            };

            knjige.Add(nova);
            XmlHelper.SpremiXml(knjige, "knjige.xml");
            OsvjeziKnjige();
        }

        private void UpravljanjeK_Load(object sender, EventArgs e)
        {
            korisnici = XmlHelper.UcitajXml<Korisnik>("korisnici.xml");
            knjige = XmlHelper.UcitajXml<Knjiga>("knjige.xml");

            OsvjeziKorisnike();
            OsvjeziKnjige();
        }
        private void OsvjeziKorisnike()
        {
            dgvKorisnici.DataSource = null;
            dgvKorisnici.DataSource = korisnici;
        }

        private void OsvjeziKnjige()
        {
            dgvKnjige.DataSource = null;
            dgvKnjige.DataSource = knjige;
        }
    }
}
