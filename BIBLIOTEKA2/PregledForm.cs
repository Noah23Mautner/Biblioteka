using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTEKA2
{
    public partial class PregledForm : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        List<Knjiga> knjige = new List<Knjiga>();

        public PregledForm()
        {
            InitializeComponent();
        }

        private void PregledForm_Load(object sender, EventArgs e)
        {
            korisnici = XmlHelper.UcitajXml<Korisnik>("korisnici.xml");
            knjige = XmlHelper.UcitajXml<Knjiga>("knjige.xml");

            OsvjeziPrikaz();
        }
        private void OsvjeziPrikaz()
        {
            dgvKorisniciPregled.DataSource = null;
            dgvKorisniciPregled.DataSource = korisnici;

            dgvKnjigePregled.DataSource = null;
            dgvKnjigePregled.DataSource = knjige;
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (dgvKorisniciPregled.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika za brisanje.");
                return;
            }

            int index = dgvKorisniciPregled.SelectedRows[0].Index;
            korisnici.RemoveAt(index);
            XmlHelper.SpremiXml(korisnici, "korisnici.xml");
            OsvjeziPrikaz();
        }

        private void btnObrisiKnjigu_Click(object sender, EventArgs e)
        {
            if (dgvKnjigePregled.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite knjigu za brisanje.");
                return;
            }

            int index = dgvKnjigePregled.SelectedRows[0].Index;
            knjige.RemoveAt(index);
            XmlHelper.SpremiXml(knjige, "knjige.xml");
            OsvjeziPrikaz();
        }
    }
}
