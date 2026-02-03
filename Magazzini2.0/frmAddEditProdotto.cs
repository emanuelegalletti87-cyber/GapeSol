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
    public partial class frmAddEditProdotto : Form
    {
        private Prodotti mProdotto;

        private Prodotti Prodotto
        {
            get { return Prodotto; }
            set { mProdotto = Prodotto; }
        }

        public frmAddEditProdotto()
        {
            InitializeComponent();
        }

        public frmAddEditProdotto(Prodotti prodotto)
        {
            mProdotto = prodotto;
            InitializeComponent();

        }

        private void frmAddEditProdotto_Load(object sender, EventArgs e)
        {
            if (mProdotto != null)
            {
                txtbNome.Text = mProdotto.Nome;
                txtbDescrizione.Text = mProdotto.Descrizione;
                nudPrezzo.Value = Convert.ToDecimal(mProdotto.PrezzoUnitario);
            }
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            return;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCampi())
                {
                    MessageBox.Show("Attenzione, compilare tutti i campi necessari.", "Validazione input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GestioneMagazziniEntities db = new GestioneMagazziniEntities();
                Prodotti prodotto = null;
                bool isModifica = true;

                if (mProdotto == null)
                {
                    isModifica = false;
                    prodotto = new Prodotti();
                }
                else
                {
                    prodotto = db.Prodotti.Where(x => x.ID.Equals(mProdotto.ID)).FirstOrDefault();
                }

                prodotto.Nome = txtbNome.Text;
                prodotto.Descrizione = txtbDescrizione.Text;
                prodotto.PrezzoUnitario = Convert.ToDouble(nudPrezzo.Value);

                if (!isModifica)
                {
                    db.Prodotti.Add(prodotto);
                }

                db.SaveChanges();
                MessageBox.Show("Il database è stato aggiornato con successo.", "Operazione conclusa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Attenzione si è verificato un errore nell'inserimento/aggiornamento dei magazzini: {ex.Message}", "Operazione interrotta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private bool ValidaCampi()
        {
            if (string.IsNullOrEmpty(txtbNome.Text) || string.IsNullOrEmpty(txtbDescrizione.Text) || nudPrezzo == null)
            {
                return false;
            }
            return true;
        }
    }
}
