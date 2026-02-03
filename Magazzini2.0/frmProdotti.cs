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
            try
            {
                GestioneMagazziniEntities db = new GestioneMagazziniEntities();
                gestioneProdottiDataSet.Reset();
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
    }
}
