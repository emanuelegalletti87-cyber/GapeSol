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
        private List<Contatto> mListaContatti;
        private List<Prodotti> mListaProdotti;
        private Prodotti mProdottoSelezionato;
        private Contatto mContattoSelezionato;

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

        private void CaricaContatti()
        {
            // TODO: This line of code loads data into the 'gestioneContattiDataSet2.Contatto' table. You can move, or remove it, as needed.
            this.contattoTableAdapter.Fill(this.gestioneContattiDataSet2.Contatto);

            GestioneMagazziniEntities db = new GestioneMagazziniEntities();
            mListaContatti = db.Contatto.ToList();
        }

        private void dgvContatto_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
