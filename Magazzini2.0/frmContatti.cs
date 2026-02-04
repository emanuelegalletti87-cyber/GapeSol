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
    public partial class frmContatti : Form
    {
        List<Contatto> mListaContatto;
        public frmContatti()
        {
            InitializeComponent();
        }


        private void frmContatti_Load(object sender, EventArgs e)
        {
            try
            {
                CaricaContatti();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnContattiAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditContatto frmAddEditContatto = new frmAddEditContatto();
                frmAddEditContatto.ShowDialog();
                CaricaContatti();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripBtnContattiModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContatti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Attenzione, selezionare il Contatto da eliminare.", "Validazione input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                GestioneMagazziniEntities db = new GestioneMagazziniEntities(); 
                frmAddEditContatto gestContatto = new frmAddEditContatto(mListaContatto.ElementAt(dgvContatti.SelectedRows[0].Index));
                gestContatto.ShowDialog();
                CaricaContatti();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CaricaContatti()
        {
            GestioneMagazziniEntities db = new GestioneMagazziniEntities();
            contattoTableAdapter.Fill(GestioneContattiDataSet.Contatto);
            try
            {

                if (string.IsNullOrEmpty(toolStripTxtbContattiCerca.Text))
                {
                    contattoTableAdapter.Fill(GestioneContattiDataSet.Contatto);
                    mListaContatto = db.Contatto.ToList();
                }
                else
                {
                    var filtro = GestioneContattiDataSet.Contatto.AsEnumerable().Where(x =>
                                 x.Field<string>("Nome").Contains(toolStripTxtbContattiCerca.Text));

                    dgvContatti.DataSource = filtro.Any()
                        ? filtro.CopyToDataTable()
                        : null;
                    mListaContatto = db.Contatto.Where(x => x.Nome.Contains(toolStripTxtbContattiCerca.Text)).ToList();
                }
                dgvContatti.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvContatti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2
                               && e.Value != null)
                {
                    e.Value = Convert.ToDateTime(e.Value).ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }

                if (e.ColumnIndex == 7
                    && e.Value != null)
                {
                    int valore = (int)e.Value;                 // 0,1,2
                    enmTipoContatto tipo = (enmTipoContatto)valore; // cast a enum

                    e.Value = tipo.ToString(); // "Contatto", "Cliente", "Fornitore"
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnContattiElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvContatti.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Attenzione, selezionare il contatto da eliminare.", "Validazione input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Contatto contattoSelezionato = new Contatto();
                contattoSelezionato = mListaContatto.ElementAt(dgvContatti.SelectedRows[0].Index);

                DialogResult result = MessageBox.Show($"Attenzione, sei sicuro di voler cancellare il contatto: {contattoSelezionato.Nome} ? Non potrai tornare indietro", "Conferma operazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)

                    return;

                GestioneMagazziniEntities db = new GestioneMagazziniEntities();
                Contatto contDB = db.Contatto.Where(x => x.ID == contattoSelezionato.ID).FirstOrDefault();

                if (contDB != null)
                {
                    db.Contatto.Remove(contDB);
                    db.SaveChanges();
                }

                CaricaContatti();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnContattiCerca_Click(object sender, EventArgs e)
        {
            try
            {
                string testoCerca = toolStripTxtbContattiCerca.Text;
                if (string.IsNullOrEmpty(testoCerca))
                {
                    MessageBox.Show("Inserire un testo nel campo cerca.", "Errore di ricerca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CaricaContatti();

                if (!mListaContatto.Any())
                {
                    MessageBox.Show($"Attenzione! Il contatto: {testoCerca.ToString()}, non esiste, riprovare con un contatto esistente", "Errore di ricerca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
