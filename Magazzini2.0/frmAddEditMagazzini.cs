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
    public partial class frmAddEditMagazzini : Form
    {

        private Magazzini mMagazzino;
        public Magazzini Magazzino
        {
            get { return mMagazzino; }
            set { mMagazzino = Magazzino; }
        }

        public frmAddEditMagazzini()
        {
            InitializeComponent();
        }

        public frmAddEditMagazzini(Magazzini magazzino)
        {
            mMagazzino = magazzino;
            InitializeComponent();
        }

        private void frmAddEditMagazzini_Load(object sender, EventArgs e)
        {
            if (mMagazzino != null)
            {
                txtbNome.Text = mMagazzino.Nome;
                txtbComune.Text = mMagazzino.Comune;
                txtbIndirizzo.Text = mMagazzino.Indirizzo;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCampi())
                {
                    MessageBox.Show("Attenzione, compilare tutti i campi necessari.", "Validazione input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GestioneMagazziniEntities db = new GestioneMagazziniEntities();
                Magazzini magazzino = null;
                bool isModifica = true;

                if (mMagazzino == null)
                {
                    isModifica = false;
                    magazzino = new Magazzini();
                }
                else
                {
                    magazzino = db.Magazzini.Where(x => x.ID == mMagazzino.ID).FirstOrDefault();
                }

                magazzino.Nome = txtbNome.Text;
                magazzino.Indirizzo = txtbIndirizzo.Text;
                magazzino.Comune = txtbComune.Text;

                if (!isModifica)
                {
                    db.Magazzini.Add(magazzino);
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
            if (string.IsNullOrEmpty(txtbNome.Text) || string.IsNullOrEmpty(txtbIndirizzo.Text) || string.IsNullOrEmpty(txtbComune.Text))
            {
                return false;
            }
            return true;
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
