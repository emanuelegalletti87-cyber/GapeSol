
namespace Magazzini2._0
{
    partial class frmProdotti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdotti));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblCerca = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxtbProdottiCerca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnProdoCerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAggiungi = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnModifica = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnProdoElimina = new System.Windows.Forms.ToolStripButton();
            this.dgvProdotti = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneProdottiDataSet = new Magazzini2._0.GestioneProdottiDataSet();
            this.prodottiTableAdapter = new Magazzini2._0.GestioneProdottiDataSetTableAdapters.ProdottiTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProdottiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblCerca,
            this.toolStripTxtbProdottiCerca,
            this.toolStripBtnProdoCerca,
            this.toolStripBtnAggiungi,
            this.toolStripBtnModifica,
            this.toolStripBtnProdoElimina});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblCerca
            // 
            this.toolStripLblCerca.Name = "toolStripLblCerca";
            this.toolStripLblCerca.Size = new System.Drawing.Size(93, 24);
            this.toolStripLblCerca.Text = "Nome prodotto:";
            // 
            // toolStripTxtbProdottiCerca
            // 
            this.toolStripTxtbProdottiCerca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtbProdottiCerca.Name = "toolStripTxtbProdottiCerca";
            this.toolStripTxtbProdottiCerca.Size = new System.Drawing.Size(76, 27);
            // 
            // toolStripBtnProdoCerca
            // 
            this.toolStripBtnProdoCerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnProdoCerca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnProdoCerca.Image")));
            this.toolStripBtnProdoCerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnProdoCerca.Name = "toolStripBtnProdoCerca";
            this.toolStripBtnProdoCerca.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnProdoCerca.Text = "Cerca";
            this.toolStripBtnProdoCerca.Click += new System.EventHandler(this.toolStripBtnProdoCerca_Click);
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
            this.toolStripBtnModifica.Click += new System.EventHandler(this.toolStripBtnModifica_Click);
            // 
            // toolStripBtnProdoElimina
            // 
            this.toolStripBtnProdoElimina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnProdoElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnProdoElimina.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnProdoElimina.Image")));
            this.toolStripBtnProdoElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnProdoElimina.Name = "toolStripBtnProdoElimina";
            this.toolStripBtnProdoElimina.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnProdoElimina.Text = "Elimina";
            this.toolStripBtnProdoElimina.ToolTipText = "Elimina";
            this.toolStripBtnProdoElimina.Click += new System.EventHandler(this.toolStripBtnProdoElimina_Click);
            // 
            // dgvProdotti
            // 
            this.dgvProdotti.AllowUserToAddRows = false;
            this.dgvProdotti.AllowUserToDeleteRows = false;
            this.dgvProdotti.AllowUserToResizeColumns = false;
            this.dgvProdotti.AllowUserToResizeRows = false;
            this.dgvProdotti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdotti.AutoGenerateColumns = false;
            this.dgvProdotti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdotti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.prezzoUnitarioDataGridViewTextBoxColumn});
            this.dgvProdotti.DataSource = this.prodottiBindingSource;
            this.dgvProdotti.Location = new System.Drawing.Point(0, 22);
            this.dgvProdotti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProdotti.Name = "dgvProdotti";
            this.dgvProdotti.ReadOnly = true;
            this.dgvProdotti.RowHeadersWidth = 51;
            this.dgvProdotti.RowTemplate.Height = 24;
            this.dgvProdotti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdotti.Size = new System.Drawing.Size(600, 344);
            this.dgvProdotti.TabIndex = 1;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezzoUnitarioDataGridViewTextBoxColumn
            // 
            this.prezzoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrezzoUnitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.HeaderText = "PrezzoUnitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezzoUnitarioDataGridViewTextBoxColumn.Name = "prezzoUnitarioDataGridViewTextBoxColumn";
            this.prezzoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodottiBindingSource
            // 
            this.prodottiBindingSource.DataMember = "Prodotti";
            this.prodottiBindingSource.DataSource = this.gestioneProdottiDataSet;
            // 
            // gestioneProdottiDataSet
            // 
            this.gestioneProdottiDataSet.DataSetName = "GestioneProdottiDataSet";
            this.gestioneProdottiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodottiTableAdapter
            // 
            this.prodottiTableAdapter.ClearBeforeFill = true;
            // 
            // frmProdotti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvProdotti);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProdotti";
            this.Text = "Gestione Prodotti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProdotti_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProdottiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLblCerca;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtbProdottiCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnProdoCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnAggiungi;
        private System.Windows.Forms.ToolStripButton toolStripBtnModifica;
        private System.Windows.Forms.ToolStripButton toolStripBtnProdoElimina;
        private System.Windows.Forms.DataGridView dgvProdotti;
        private GestioneProdottiDataSet gestioneProdottiDataSet;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private GestioneProdottiDataSetTableAdapters.ProdottiTableAdapter prodottiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoUnitarioDataGridViewTextBoxColumn;
    }
}