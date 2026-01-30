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
            // TODO: This line of code loads data into the 'gestioneMagazziniDataSet1.Contatto' table. You can move, or remove it, as needed.
            this.contattoTableAdapter.Fill(this.GestioneContattiDataSet.Contatto);
            dgvContatti.ClearSelection();

        }

        private void toolStripBtnContattiAggiungi_Click(object sender, EventArgs e)
        {
            frmAddEditContatto frmAddEditContatto = new frmAddEditContatto();
            frmAddEditContatto.ShowDialog();
            contattoTableAdapter.Fill(GestioneContattiDataSet.Contatto);
        }

        private void toolStripBtnContattiModifica_Click(object sender, EventArgs e)
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
            contattoTableAdapter.Fill(GestioneContattiDataSet.Contatto);
        }

        private void dgvContatti_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
    }
}
