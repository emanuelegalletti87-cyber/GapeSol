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
    public partial class frmMovimenti : Form
    {
        public frmMovimenti()
        {
            InitializeComponent();
        }

        private void frmMovimenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestioneMagazziniDataSet1.Movimenti' table. You can move, or remove it, as needed.
            this.movimentiTableAdapter.Fill(this.gestioneMagazziniDataSet1.Movimenti);

        }
    }
}
