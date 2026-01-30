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

    //Creiamo la classe frmMagazzini dalla classe astratta form
    public partial class frmMagazzini : Form
    {
        //Creiamo la lista di oggetti Magazzini che ci servirà a popolare il dgv e altre operazioni
        List<Magazzini> mlistaMagazzini;

        //Inizializiamo il form
        public frmMagazzini()
        {
            InitializeComponent();
        }

        //Creiamo il metodo che carica la pagina e i magazzini presenti nel DB all'interno del dgvMagazzini 
        private void frmMagazzini_Load(object sender, EventArgs e)
        {
            CaricaMagazzini();
        }

        //Creiamo il metodo che aggiorna i magazzini all'interno del dgvMagazzini
        private void CaricaMagazzini()
        {
            GestioneMagazziniEntities db = new GestioneMagazziniEntities();
           
            try
            {
                if (string.IsNullOrEmpty(toolStripTxtbMagaCerca.Text))
                {
                    magazziniTableAdapter.Fill(gestioneMagazziniDataSet.Magazzini);
                    mlistaMagazzini = db.Magazzini.ToList();
                }
                else
                {
                    var filtro = gestioneMagazziniDataSet.Magazzini.AsEnumerable().Where(x =>
                                    x.Field<string>("Nome").StartsWith(toolStripTxtbMagaCerca.Text) ||
                                    x.Field<string>("Nome").EndsWith(toolStripTxtbMagaCerca.Text));

                    dgvMagazzini.DataSource = filtro.Any()
                        ? filtro.CopyToDataTable()
                        : null;

                    mlistaMagazzini = db.Magazzini.Where(x=>x.Nome.Contains(toolStripTxtbMagaCerca.Text)).ToList();         
                }
                dgvMagazzini.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Gestiamo l'evento di click del pulsante che serve ad aggiungere dei magazzini
        private void toolStripBtnMagaAdd_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditMagazzini frmAdd = new frmAddEditMagazzini();
                frmAdd.ShowDialog();
                CaricaMagazzini();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        //Gestiamo l'evento di click del pulsante che serve a modificare uno dei magazzini
        private void toolStripBtnMagaEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMagazzini.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Attenzione, selezionare il magazzino da modificare.", "Validazione input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                frmAddEditMagazzini gestMaga = new frmAddEditMagazzini(mlistaMagazzini.ElementAt(dgvMagazzini.SelectedRows[0].Index));
                gestMaga.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        //Gestiamo l'evento di click del pulsante che serve a eliminare uno dei magazzini
        private void toolStripBtnMagaDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMagazzini.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Attenzione, selezionare il magazzino da eliminare.", "Validazione input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Magazzini magaSelezionato = mlistaMagazzini.ElementAt(dgvMagazzini.SelectedRows[0].Index);

                DialogResult result = MessageBox.Show($"Attenzione, sei sicuro di voler cancellare il magazzino {magaSelezionato.Nome} ? Non potrai tornare indietro", "Conferma operazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)

                    return;


                GestioneMagazziniEntities db = new GestioneMagazziniEntities();

                Magazzini magaDB = db.Magazzini.Where(x => x.ID == magaSelezionato.ID).FirstOrDefault();
                if (magaDB != null)
                {
                    db.Magazzini.Remove(magaDB);
                    db.SaveChanges();
                }

                CaricaMagazzini();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                throw;
            }

        }

        //Gestiamo l'evento di click del pulsante che serve a cercare uno dei magazzini
        private void toolStripBtnMagaCerca_Click(object sender, EventArgs e)
        {
            try
            {
                string testoCerca = toolStripTxtbMagaCerca.Text;
                if (string.IsNullOrEmpty(testoCerca))
                {
                    MessageBox.Show($"Inserire un testo nel campo cerca.", "Errore di ricerca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CaricaMagazzini();


                if (!mlistaMagazzini.Any())
                    MessageBox.Show($"Attenzione! Il magazzino: {testoCerca.ToString()}, non esiste, riprovare con un magazzino esistente", "Errore di ricerca", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore di ricerca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
