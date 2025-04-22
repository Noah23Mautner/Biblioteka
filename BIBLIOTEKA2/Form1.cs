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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpravljanje_Click(object sender, EventArgs e)
        {
            UpravljanjeK forma = new UpravljanjeK();
            forma.ShowDialog();
        }

        private void btnPosudba_Click(object sender, EventArgs e)
        {
            PosudbaForm forma = new PosudbaForm();
            forma.ShowDialog();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            PregledForm forma = new PregledForm();
            forma.ShowDialog();
        }
    }
}
