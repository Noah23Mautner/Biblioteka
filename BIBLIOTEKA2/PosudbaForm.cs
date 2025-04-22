using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BIBLIOTEKA2.PosudbaForm;

namespace BIBLIOTEKA2
{
    public partial class PosudbaForm : Form
    {
        public class Posudba
        {
            public string Korisnik { get; set; }
            public string Knjiga { get; set; }
            public DateTime DatumPosudbe { get; set; }
            public DateTime? DatumPovrata { get; set; }
        }

        List<Posudba> posudbe = new List<Posudba>();
        public PosudbaForm()
        {
            InitializeComponent();
        }

        private void btnPosudi_Click(object sender, EventArgs e)
        {
            var nova = new Posudba
            {
                Korisnik = cmbKorisnici.SelectedItem.ToString(),
                Knjiga = cmbKnjige.SelectedItem.ToString(),
                DatumPosudbe = dtPosudba.Value,
                DatumPovrata = null
            };
            posudbe.Add(nova);
            osvjeziPosudbe();
        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            if (dgvPosudbe.CurrentRow != null)
            {
                var p = (Posudba)dgvPosudbe.CurrentRow.DataBoundItem;
                p.DatumPovrata = dtPovrat.Value;
                osvjeziPosudbe();
            }
        }
        private void osvjeziPosudbe()
        {
            dgvPosudbe.DataSource = null;
            dgvPosudbe.DataSource = posudbe;
        }
    }
}
