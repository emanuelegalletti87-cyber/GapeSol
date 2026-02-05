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

        private ToolStripControlHost _dtpHost;

        private void frmMovimenti_Load(object sender, EventArgs e)
        {
            var dtp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Long,
                Width = 170 // regola a piacere
            };

            _dtpHost = new ToolStripControlHost(dtp)
            {
                Margin = new Padding(0, 0, 0, 0),
                Padding = new Padding(0),
                AutoSize = false
            };

            toolStrip1.Items.Add(_dtpHost);
        }
    }
}
