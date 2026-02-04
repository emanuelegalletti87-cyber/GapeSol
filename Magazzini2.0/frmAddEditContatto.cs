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
    public partial class frmAddEditContatto : Form
    {
        private Contatto mContatto;

        public frmAddEditContatto()
        {
            InitializeComponent();
            comboBoxTipoContatto.DataSource = Enum.GetValues(typeof(enmTipoContatto));
        }

        public frmAddEditContatto(Contatto contatto)
        {
            mContatto = contatto;
            InitializeComponent();
            comboBoxTipoContatto.DataSource = Enum.GetValues(typeof(enmTipoContatto));
        }
        private void frmAddEditContatto_Load(object sender, EventArgs e)
        {
            if (mContatto != null)
            {
                txtbNome.Text = mContatto.Nome.ToString();
                txtbCognome.Text = mContatto.Cognome.ToString();
                txtbCitta.Text = mContatto.Citta.ToString();
                txtbIndirizzo.Text = mContatto.Indirizzo.ToString();
                txtbEmail.Text = mContatto.EMail.ToString();
                txtbTelefono.Text = mContatto.Telefono.ToString();
                dtpDataNascita.Value = mContatto.DataDiNascita.Date;
                comboBoxTipoContatto.SelectedItem = mContatto.TipoContatto;
            }
        }
        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            Close();
        }



        private bool ValidaCampi()
        {
            if (string.IsNullOrEmpty(txtbNome.Text) || string.IsNullOrEmpty(txtbCognome.Text) || string.IsNullOrEmpty(txtbIndirizzo.Text) || string.IsNullOrEmpty(txtbCitta.Text) || string.IsNullOrEmpty(txtbEmail.Text) || string.IsNullOrEmpty(txtbTelefono.Text))
            {
                return false;
            }
            return true;
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
                Contatto contatto = new Contatto();
                bool isModifica = true;
                if (mContatto == null)
                {
                    isModifica = false;
                    contatto = new Contatto();
                }
                else
                {
                    contatto = db.Contatto.Where(x => x.ID == mContatto.ID).FirstOrDefault();
                }

                contatto.Nome = txtbNome.Text;
                contatto.Cognome = txtbCognome.Text;
                contatto.DataDiNascita = dtpDataNascita.Value;
                contatto.Indirizzo = txtbIndirizzo.Text;
                contatto.Citta = txtbCitta.Text;
                contatto.EMail = txtbEmail.Text;
                contatto.Telefono = txtbTelefono.Text;
                contatto.TipoContatto = (enmTipoContatto)comboBoxTipoContatto.SelectedItem;

                if (!isModifica)
                    db.Contatto.Add(contatto);

                db.SaveChanges();

                MessageBox.Show("Contatto aggiunto/modificato con successo.", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'operazione: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
