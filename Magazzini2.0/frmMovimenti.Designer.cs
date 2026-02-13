
namespace Magazzini2._0
{
    partial class frmMovimenti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimenti));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStriplblCerca = new System.Windows.Forms.ToolStripLabel();
            this.txtbCerca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnCerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblDa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBtnAggiungi = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnModifica = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnElimina = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMovEntrata = new System.Windows.Forms.Label();
            this.lblMovUscita = new System.Windows.Forms.Label();
            this.lblTotUscita = new System.Windows.Forms.Label();
            this.lblTotEntrata = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblFiltro,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStriplblCerca,
            this.txtbCerca,
            this.toolStripBtnCerca,
            this.toolStripSeparator2,
            this.lblDa,
            this.toolStripBtnAggiungi,
            this.toolStripBtnModifica,
            this.toolStripBtnElimina});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblFiltro
            // 
            this.toolStripLblFiltro.Name = "toolStripLblFiltro";
            this.toolStripLblFiltro.Size = new System.Drawing.Size(37, 24);
            this.toolStripLblFiltro.Text = "Filtro:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(92, 27);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStriplblCerca
            // 
            this.toolStriplblCerca.Name = "toolStriplblCerca";
            this.toolStriplblCerca.Size = new System.Drawing.Size(37, 24);
            this.toolStriplblCerca.Text = "Cerca";
            // 
            // txtbCerca
            // 
            this.txtbCerca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbCerca.Name = "txtbCerca";
            this.txtbCerca.Size = new System.Drawing.Size(76, 27);
            // 
            // toolStripBtnCerca
            // 
            this.toolStripBtnCerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCerca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCerca.Image")));
            this.toolStripBtnCerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCerca.Name = "toolStripBtnCerca";
            this.toolStripBtnCerca.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnCerca.Text = "toolStripButton1";
            this.toolStripBtnCerca.ToolTipText = "Cerca";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // lblDa
            // 
            this.lblDa.MergeIndex = 6;
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(20, 24);
            this.lblDa.Text = "da";
            // 
            // toolStripBtnAggiungi
            // 
            this.toolStripBtnAggiungi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnAggiungi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAggiungi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAggiungi.Image")));
            this.toolStripBtnAggiungi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAggiungi.Name = "toolStripBtnAggiungi";
            this.toolStripBtnAggiungi.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnAggiungi.Text = "Aggiungi";
            this.toolStripBtnAggiungi.Click += new System.EventHandler(this.toolStripBtnAggiungi_Click);
            // 
            // toolStripBtnModifica
            // 
            this.toolStripBtnModifica.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnModifica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnModifica.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnModifica.Image")));
            this.toolStripBtnModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnModifica.Name = "toolStripBtnModifica";
            this.toolStripBtnModifica.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnModifica.Text = "Modifica";
            // 
            // toolStripBtnElimina
            // 
            this.toolStripBtnElimina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnElimina.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnElimina.Image")));
            this.toolStripBtnElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnElimina.Name = "toolStripBtnElimina";
            this.toolStripBtnElimina.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnElimina.Text = "Elimina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(697, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblMovEntrata
            // 
            this.lblMovEntrata.AutoSize = true;
            this.lblMovEntrata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMovEntrata.Location = new System.Drawing.Point(0, 380);
            this.lblMovEntrata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovEntrata.Name = "lblMovEntrata";
            this.lblMovEntrata.Size = new System.Drawing.Size(117, 13);
            this.lblMovEntrata.TabIndex = 2;
            this.lblMovEntrata.Text = "n° movimenti in entrata:";
            // 
            // lblMovUscita
            // 
            this.lblMovUscita.AutoSize = true;
            this.lblMovUscita.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMovUscita.Location = new System.Drawing.Point(0, 367);
            this.lblMovUscita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMovUscita.Name = "lblMovUscita";
            this.lblMovUscita.Size = new System.Drawing.Size(112, 13);
            this.lblMovUscita.TabIndex = 3;
            this.lblMovUscita.Text = "n° movimenti in uscita:";
            // 
            // lblTotUscita
            // 
            this.lblTotUscita.AutoSize = true;
            this.lblTotUscita.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotUscita.Location = new System.Drawing.Point(0, 354);
            this.lblTotUscita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotUscita.Name = "lblTotUscita";
            this.lblTotUscita.Size = new System.Drawing.Size(114, 13);
            this.lblTotUscita.TabIndex = 4;
            this.lblTotUscita.Text = "totale denaro in uscita:";
            // 
            // lblTotEntrata
            // 
            this.lblTotEntrata.AutoSize = true;
            this.lblTotEntrata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotEntrata.Location = new System.Drawing.Point(0, 341);
            this.lblTotEntrata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotEntrata.Name = "lblTotEntrata";
            this.lblTotEntrata.Size = new System.Drawing.Size(122, 13);
            this.lblTotEntrata.TabIndex = 5;
            this.lblTotEntrata.Text = "totale denaro in entrata: ";
            // 
            // frmMovimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 393);
            this.Controls.Add(this.lblTotEntrata);
            this.Controls.Add(this.lblTotUscita);
            this.Controls.Add(this.lblMovUscita);
            this.Controls.Add(this.lblMovEntrata);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMovimenti";
            this.Text = "frmMovimenti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovimenti_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStriplblCerca;
        private System.Windows.Forms.ToolStripTextBox txtbCerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblDa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnAggiungi;
        private System.Windows.Forms.ToolStripButton toolStripBtnModifica;
        private System.Windows.Forms.ToolStripButton toolStripBtnElimina;
        private System.Windows.Forms.Label lblMovEntrata;
        private System.Windows.Forms.Label lblMovUscita;
        private System.Windows.Forms.Label lblTotUscita;
        private System.Windows.Forms.Label lblTotEntrata;
        private System.Windows.Forms.ToolStripLabel toolStripLblFiltro;
    }
}