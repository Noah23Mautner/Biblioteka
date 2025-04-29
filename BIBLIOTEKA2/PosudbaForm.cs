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
using static BIBLIOTEKA2.PosudbaForm;

namespace BIBLIOTEKA2
{
    public partial class PosudbaForm : Form
    {

        List<Posudba> posudbe = new List<Posudba>();
        List<Korisnik> korisnici = new List<Korisnik>();
        List<Knjiga> knjige = new List<Knjiga>();

        public PosudbaForm()
        {
            InitializeComponent();
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            if (cmbKorisnici.SelectedItem is Korisnik korisnik && cmbKnjige.SelectedItem is Knjiga knjiga)
            {
                Posudba nova = new Posudba
                {
                    KorisnikIme = korisnik.Ime + " " + korisnik.Prezime,
                    KnjigaNaslov = knjiga.Naslov,
                    DatumPosudbe = dtPosudba.Value,
                    DatumPovrata = dtPovrat.Value
                };

                posudbe.Add(nova);
                XmlHelper.SpremiXml(posudbe, "posudbe.xml");
                OsvjeziGrid();
            }
            else
            {
                MessageBox.Show("Molimo odaberite korisnika i knjigu.");
            }
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (dgvPosudbe.SelectedRows.Count > 0)
            {
                int index = dgvPosudbe.SelectedRows[0].Index;
                posudbe.RemoveAt(index);
                XmlHelper.SpremiXml(posudbe, "posudbe.xml");
                OsvjeziGrid();
            }
            else
            {
                MessageBox.Show("Odaberite posudbu za vraćanje.");
            }
        }
        private void OsvjeziGrid()
        {
            dgvPosudbe.DataSource = null;
            dgvPosudbe.DataSource = posudbe;
        }

        private void PosudbaForm_Load(object sender, EventArgs e)
        {
            korisnici = XmlHelper.UcitajXml<Korisnik>("korisnici.xml");
            knjige = XmlHelper.UcitajXml<Knjiga>("knjige.xml");
            posudbe = XmlHelper.UcitajXml<Posudba>("posudbe.xml");

            cmbKorisnici.DataSource = korisnici;
            cmbKorisnici.DisplayMember = "Ime";  // možeš promijeniti ako želiš prikazati i prezime

            cmbKnjige.DataSource = knjige;
            cmbKnjige.DisplayMember = "Naslov";

            OsvjeziGrid();
        }
    }
}
