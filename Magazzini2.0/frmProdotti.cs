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
    public partial class frmProdotti : Form
    {
        List<Prodotti> mlistaProdotti;
        public frmProdotti()
        {
            InitializeComponent();
        }

        private void frmProdotti_Load(object sender, EventArgs e)
        {
            CaricaProdotti();

        }

        private void CaricaProdotti()
        {
            GestioneMagazziniEntities db = new GestioneMagazziniEntities();
            prodottiTableAdapter.Fill(this.gestioneProdottiDataSet.Prodotti);
            try
            {
                if (string.IsNullOrEmpty(toolStripTxtbProdottiCerca.Text))
                {
                    prodottiTableAdapter.Fill(this.gestioneProdottiDataSet.Prodotti);
                    mlistaProdotti = db.Prodotti.ToList();
                }
                else
                {
                    var filtro = gestioneProdottiDataSet.Prodotti.AsEnumerable().Where(x =>
                                 x.Field<string>("Nome").Contains(toolStripTxtbProdottiCerca.Text));

                    dgvProdotti.DataSource = filtro.Any()
                        ? filtro.CopyToDataTable()
                        : null;

                    mlistaProdotti = db.Prodotti.Where(x => x.Nome.Contains(toolStripTxtbProdottiCerca.Text)).ToList();
                }
                dgvProdotti.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void toolStripBtnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditProdotto frmAddEditProdotto = new frmAddEditProdotto();
                frmAddEditProdotto.ShowDialog();
                CaricaProdotti();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdotti.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Selezionare un prodotto da modificare.", "Modifica prodotto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmAddEditProdotto frmAddEditProdotto = new frmAddEditProdotto(mlistaProdotti[dgvProdotti.SelectedRows[0].Index]);
                frmAddEditProdotto.ShowDialog();
                CaricaProdotti();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnProdoElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdotti.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selezionare un prodotto da eliminare.", "Elimina prodotto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Prodotti prodottoSelezionato = mlistaProdotti.ElementAt(dgvProdotti.SelectedRows[0].Index);

                DialogResult result = MessageBox.Show($"Sei sicuro di voler eliminare il prodotto '{prodottoSelezionato.Nome}'?", "Elimina prodotto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                GestioneMagazziniEntities db = new GestioneMagazziniEntities();

                Prodotti prodoDB = db.Prodotti.Where(x => x.ID == prodottoSelezionato.ID).FirstOrDefault();
                if (prodoDB != null)
                {
                    db.Prodotti.Remove(prodoDB);
                    db.SaveChanges();

                }
                CaricaProdotti();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripBtnProdoCerca_Click(object sender, EventArgs e)
        {
            try
            {
                string testoCerca = toolStripTxtbProdottiCerca.Text;
                if (string.IsNullOrEmpty(testoCerca))
                {
                    MessageBox.Show("Inserire il testo da cercare.", "Cerca prodotto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CaricaProdotti();

                if (!mlistaProdotti.Any())
                {
                    MessageBox.Show("Nessun prodotto trovato con i criteri di ricerca inseriti.", "Cerca prodotto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
