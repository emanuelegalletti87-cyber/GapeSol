
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
            this.components = new System.ComponentModel.Container();
            this.toolStripMovimenti = new System.Windows.Forms.ToolStrip();
            this.dgvMovimenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gestioneMagazziniDataSet1 = new Magazzini2._0.GestioneMagazziniDataSet1();
            this.movimentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movimentiTableAdapter = new Magazzini2._0.GestioneMagazziniDataSet1TableAdapters.MovimentiTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProdottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMagazzinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDContattoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataMovimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMovimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLblFiltro = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblCerca = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxtbCerca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLblDa = new System.Windows.Forms.ToolStripLabel();
            this.toolStripMovimenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMovimenti
            // 
            this.toolStripMovimenti.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMovimenti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblFiltro,
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripLblCerca,
            this.toolStripTxtbCerca,
            this.toolStripSeparator2,
            this.toolStripLblDa});
            this.toolStripMovimenti.Location = new System.Drawing.Point(0, 0);
            this.toolStripMovimenti.Name = "toolStripMovimenti";
            this.toolStripMovimenti.Size = new System.Drawing.Size(929, 31);
            this.toolStripMovimenti.TabIndex = 0;
            this.toolStripMovimenti.Text = "toolStrip1";
            // 
            // dgvMovimenti
            // 
            this.dgvMovimenti.AllowUserToAddRows = false;
            this.dgvMovimenti.AllowUserToDeleteRows = false;
            this.dgvMovimenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovimenti.AutoGenerateColumns = false;
            this.dgvMovimenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iDProdottoDataGridViewTextBoxColumn,
            this.iDMagazzinoDataGridViewTextBoxColumn,
            this.iDContattoDataGridViewTextBoxColumn,
            this.dataMovimentoDataGridViewTextBoxColumn,
            this.tipoMovimentoDataGridViewTextBoxColumn,
            this.quantitaDataGridViewTextBoxColumn});
            this.dgvMovimenti.DataSource = this.movimentiBindingSource;
            this.dgvMovimenti.Location = new System.Drawing.Point(0, 28);
            this.dgvMovimenti.Name = "dgvMovimenti";
            this.dgvMovimenti.ReadOnly = true;
            this.dgvMovimenti.RowHeadersWidth = 51;
            this.dgvMovimenti.RowTemplate.Height = 24;
            this.dgvMovimenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimenti.Size = new System.Drawing.Size(929, 385);
            this.dgvMovimenti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "totale importo in uscita:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "totale importo in entrata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "n° Movimenti in uscita: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "n° Movimenti in entrata:";
            // 
            // gestioneMagazziniDataSet1
            // 
            this.gestioneMagazziniDataSet1.DataSetName = "GestioneMagazziniDataSet1";
            this.gestioneMagazziniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movimentiBindingSource
            // 
            this.movimentiBindingSource.DataMember = "Movimenti";
            this.movimentiBindingSource.DataSource = this.gestioneMagazziniDataSet1;
            // 
            // movimentiTableAdapter
            // 
            this.movimentiTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDProdottoDataGridViewTextBoxColumn
            // 
            this.iDProdottoDataGridViewTextBoxColumn.DataPropertyName = "IDProdotto";
            this.iDProdottoDataGridViewTextBoxColumn.HeaderText = "IDProdotto";
            this.iDProdottoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProdottoDataGridViewTextBoxColumn.Name = "iDProdottoDataGridViewTextBoxColumn";
            this.iDProdottoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProdottoDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDMagazzinoDataGridViewTextBoxColumn
            // 
            this.iDMagazzinoDataGridViewTextBoxColumn.DataPropertyName = "IDMagazzino";
            this.iDMagazzinoDataGridViewTextBoxColumn.HeaderText = "IDMagazzino";
            this.iDMagazzinoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDMagazzinoDataGridViewTextBoxColumn.Name = "iDMagazzinoDataGridViewTextBoxColumn";
            this.iDMagazzinoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDMagazzinoDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDContattoDataGridViewTextBoxColumn
            // 
            this.iDContattoDataGridViewTextBoxColumn.DataPropertyName = "IDContatto";
            this.iDContattoDataGridViewTextBoxColumn.HeaderText = "IDContatto";
            this.iDContattoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDContattoDataGridViewTextBoxColumn.Name = "iDContattoDataGridViewTextBoxColumn";
            this.iDContattoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDContattoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataMovimentoDataGridViewTextBoxColumn
            // 
            this.dataMovimentoDataGridViewTextBoxColumn.DataPropertyName = "DataMovimento";
            this.dataMovimentoDataGridViewTextBoxColumn.HeaderText = "DataMovimento";
            this.dataMovimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataMovimentoDataGridViewTextBoxColumn.Name = "dataMovimentoDataGridViewTextBoxColumn";
            this.dataMovimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataMovimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoMovimentoDataGridViewTextBoxColumn
            // 
            this.tipoMovimentoDataGridViewTextBoxColumn.DataPropertyName = "TipoMovimento";
            this.tipoMovimentoDataGridViewTextBoxColumn.HeaderText = "TipoMovimento";
            this.tipoMovimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoMovimentoDataGridViewTextBoxColumn.Name = "tipoMovimentoDataGridViewTextBoxColumn";
            this.tipoMovimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoMovimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitaDataGridViewTextBoxColumn
            // 
            this.quantitaDataGridViewTextBoxColumn.DataPropertyName = "Quantita";
            this.quantitaDataGridViewTextBoxColumn.HeaderText = "Quantita";
            this.quantitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitaDataGridViewTextBoxColumn.Name = "quantitaDataGridViewTextBoxColumn";
            this.quantitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // toolStripLblFiltro
            // 
            this.toolStripLblFiltro.Name = "toolStripLblFiltro";
            this.toolStripLblFiltro.Size = new System.Drawing.Size(46, 28);
            this.toolStripLblFiltro.Text = "Filtro:";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLblCerca
            // 
            this.toolStripLblCerca.Name = "toolStripLblCerca";
            this.toolStripLblCerca.Size = new System.Drawing.Size(46, 28);
            this.toolStripLblCerca.Text = "Cerca";
            // 
            // toolStripTxtbCerca
            // 
            this.toolStripTxtbCerca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtbCerca.Name = "toolStripTxtbCerca";
            this.toolStripTxtbCerca.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLblDa
            // 
            this.toolStripLblDa.Name = "toolStripLblDa";
            this.toolStripLblDa.Size = new System.Drawing.Size(31, 28);
            this.toolStripLblDa.Text = "Da:";
            // 
            // frmMovimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 484);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMovimenti);
            this.Controls.Add(this.toolStripMovimenti);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMovimenti";
            this.Text = "frmMovimenti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovimenti_Load);
            this.toolStripMovimenti.ResumeLayout(false);
            this.toolStripMovimenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimentiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMovimenti;
        private System.Windows.Forms.DataGridView dgvMovimenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GestioneMagazziniDataSet1 gestioneMagazziniDataSet1;
        private System.Windows.Forms.BindingSource movimentiBindingSource;
        private GestioneMagazziniDataSet1TableAdapters.MovimentiTableAdapter movimentiTableAdapter;
        private System.Windows.Forms.ToolStripLabel toolStripLblFiltro;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLblCerca;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtbCerca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLblDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMagazzinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDContattoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataMovimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMovimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitaDataGridViewTextBoxColumn;
    }
}