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
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnContattiAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditContatto frmAddEditContatto = new frmAddEditContatto();
                frmAddEditContatto.ShowDialog();
                contattoTableAdapter.Fill(GestioneContattiDataSet.Contatto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                mListaContatto = db.Contatto.ToList();
                frmAddEditContatto frmAddEditContatto = new frmAddEditContatto(mListaContatto.ElementAt(dgvContatti.SelectedRows[0].Index));
                frmAddEditContatto.ShowDialog();
                CaricaContatti();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CaricaContatti()
        {
            GestioneMagazziniEntities db = new GestioneMagazziniEntities();
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
                MessageBox.Show($"Si è verificato un errore: {ex}", "Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception)
            {
                MessageBox.Show("Si è verificato un errore sconosciuto, riprovare.", "errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
