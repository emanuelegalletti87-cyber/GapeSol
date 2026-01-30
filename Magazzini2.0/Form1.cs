using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazzini2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContatti_Click(object sender, EventArgs e)
        {
            frmContatti frmCont = new frmContatti();
            frmCont.Show();
        }

        private void btnMagazzini_Click(object sender, EventArgs e)
        {        
            frmMagazzini frmMaga = new frmMagazzini();
            frmMaga.ShowDialog();
        }

        private void btnProdotti_Click(object sender, EventArgs e)
        {
            frmProdotti frmPro = new frmProdotti();
            frmPro.Show();
        }

        private void btnMovimento_Click(object sender, EventArgs e)
        {
            frmMovimenti frmMovi = new frmMovimenti();
            frmMovi.Show();
        }

    }
}
