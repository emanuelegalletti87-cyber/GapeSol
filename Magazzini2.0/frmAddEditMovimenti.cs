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
    public partial class frmAddEditMovimenti : Form
    {
        public frmAddEditMovimenti()
        {
            InitializeComponent();
        }

        private void frmAddEditMovimenti_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'gestioneProdottiDataSet.Prodotti'. È possibile spostarla o rimuoverla se necessario.
            this.prodottiTableAdapter.Fill(this.gestioneProdottiDataSet.Prodotti);
            // TODO: questa riga di codice carica i dati nella tabella 'gestioneMagazziniDataSet.Magazzini'. È possibile spostarla o rimuoverla se necessario.
            this.magazziniTableAdapter.Fill(this.gestioneMagazziniDataSet.Magazzini);

        }
    }
}
