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
    public partial class frmMovimenti : Form
    {
        public frmMovimenti()
        {
            InitializeComponent();
        }

        private ToolStripControlHost dtpDa;
        private ToolStripControlHost dtpA;

        private void frmMovimenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestioneMovimentiDataSet.Movimenti' table. You can move, or remove it, as needed.
            this.movimentiTableAdapter.Fill(this.gestioneMovimentiDataSet.Movimenti);
            try
            {
                var _dtp = new DateTimePicker
                {
                    Format = DateTimePickerFormat.Long,
                    Width = 170 // regola a piacere
                };
                var _dtp2 = new DateTimePicker
                {
                    Format = DateTimePickerFormat.Long,
                    Width = 170 // regola a piacere
                };

                dtpDa = new ToolStripControlHost(_dtp)
                {
                    Margin = new Padding(0, 0, 0, 0),
                    Padding = new Padding(0),
                    AutoSize = false
                };
                dtpA = new ToolStripControlHost(_dtp2)
                {
                    Margin = new Padding(0, 0, 0, 0),
                    Padding = new Padding(0),
                    AutoSize = false
                };
                ToolStripLabel lblA = new ToolStripLabel("a");
                toolStrip1.Items.Insert(8, dtpDa);
                toolStrip1.Items.Insert(9, lblA);
                toolStrip1.Items.Insert(10, dtpA);
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
                frmAddEditMovimenti frm = new frmAddEditMovimenti();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Errore sconosciuto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
