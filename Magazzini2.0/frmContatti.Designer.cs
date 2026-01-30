
namespace Magazzini2._0
{
    partial class frmContatti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContatti));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLblContattiCerca = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxtbContattiCerca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnContattiCerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnContattiAggiungi = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnContattiModifica = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnContattiElimina = new System.Windows.Forms.ToolStripButton();
            this.dgvContatti = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContattoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestioneContattiDataSet = new Magazzini2._0.GestioneContattiDataSet();
            this.contattoTableAdapter = new Magazzini2._0.GestioneMagazziniDataSet1TableAdapters.ContattoTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestioneContattiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblContattiCerca,
            this.toolStripTxtbContattiCerca,
            this.toolStripBtnContattiCerca,
            this.toolStripBtnContattiAggiungi,
            this.toolStripBtnContattiModifica,
            this.toolStripBtnContattiElimina});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLblContattiCerca
            // 
            this.toolStripLblContattiCerca.Name = "toolStripLblContattiCerca";
            this.toolStripLblContattiCerca.Size = new System.Drawing.Size(113, 24);
            this.toolStripLblContattiCerca.Text = "Nome contatto:";
            // 
            // toolStripTxtbContattiCerca
            // 
            this.toolStripTxtbContattiCerca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtbContattiCerca.Name = "toolStripTxtbContattiCerca";
            this.toolStripTxtbContattiCerca.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripBtnContattiCerca
            // 
            this.toolStripBtnContattiCerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnContattiCerca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnContattiCerca.Image")));
            this.toolStripBtnContattiCerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnContattiCerca.Name = "toolStripBtnContattiCerca";
            this.toolStripBtnContattiCerca.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnContattiCerca.ToolTipText = "Cerca";
            // 
            // toolStripBtnContattiAggiungi
            // 
            this.toolStripBtnContattiAggiungi.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnContattiAggiungi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnContattiAggiungi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnContattiAggiungi.Image")));
            this.toolStripBtnContattiAggiungi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnContattiAggiungi.Name = "toolStripBtnContattiAggiungi";
            this.toolStripBtnContattiAggiungi.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnContattiAggiungi.ToolTipText = "Aggiungi";
            this.toolStripBtnContattiAggiungi.Click += new System.EventHandler(this.toolStripBtnContattiAggiungi_Click);
            // 
            // toolStripBtnContattiModifica
            // 
            this.toolStripBtnContattiModifica.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnContattiModifica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnContattiModifica.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnContattiModifica.Image")));
            this.toolStripBtnContattiModifica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnContattiModifica.Name = "toolStripBtnContattiModifica";
            this.toolStripBtnContattiModifica.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnContattiModifica.ToolTipText = "Modifica";
            this.toolStripBtnContattiModifica.Click += new System.EventHandler(this.toolStripBtnContattiModifica_Click);
            // 
            // toolStripBtnContattiElimina
            // 
            this.toolStripBtnContattiElimina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnContattiElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnContattiElimina.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnContattiElimina.Image")));
            this.toolStripBtnContattiElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnContattiElimina.Name = "toolStripBtnContattiElimina";
            this.toolStripBtnContattiElimina.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnContattiElimina.ToolTipText = "Elimina";
            // 
            // dgvContatti
            // 
            this.dgvContatti.AllowUserToAddRows = false;
            this.dgvContatti.AllowUserToDeleteRows = false;
            this.dgvContatti.AllowUserToResizeColumns = false;
            this.dgvContatti.AllowUserToResizeRows = false;
            this.dgvContatti.AutoGenerateColumns = false;
            this.dgvContatti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContatti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.dataDiNascitaDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.cittaDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoContattoDataGridViewTextBoxColumn});
            this.dgvContatti.DataSource = this.contattoBindingSource;
            this.dgvContatti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContatti.Location = new System.Drawing.Point(0, 27);
            this.dgvContatti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvContatti.MultiSelect = false;
            this.dgvContatti.Name = "dgvContatti";
            this.dgvContatti.ReadOnly = true;
            this.dgvContatti.RowHeadersWidth = 51;
            this.dgvContatti.RowTemplate.Height = 24;
            this.dgvContatti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatti.Size = new System.Drawing.Size(800, 423);
            this.dgvContatti.TabIndex = 1;
            this.dgvContatti.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContatti_CellFormatting);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDiNascitaDataGridViewTextBoxColumn
            // 
            this.dataDiNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.HeaderText = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDiNascitaDataGridViewTextBoxColumn.Name = "dataDiNascitaDataGridViewTextBoxColumn";
            this.dataDiNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            this.cittaDataGridViewTextBoxColumn.DataPropertyName = "Citta";
            this.cittaDataGridViewTextBoxColumn.HeaderText = "Citta";
            this.cittaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            this.cittaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoContattoDataGridViewTextBoxColumn
            // 
            this.tipoContattoDataGridViewTextBoxColumn.DataPropertyName = "TipoContatto";
            this.tipoContattoDataGridViewTextBoxColumn.HeaderText = "TipoContatto";
            this.tipoContattoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoContattoDataGridViewTextBoxColumn.Name = "tipoContattoDataGridViewTextBoxColumn";
            this.tipoContattoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataMember = "Contatto";
            this.contattoBindingSource.DataSource = this.GestioneContattiDataSet;
            // 
            // GestioneContattiDataSet
            // 
            this.GestioneContattiDataSet.DataSetName = "GestioneContattiDataSet";
            this.GestioneContattiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contattoTableAdapter
            // 
            this.contattoTableAdapter.ClearBeforeFill = true;
            // 
            // frmContatti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvContatti);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmContatti";
            this.Text = "Gestione Contatti";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContatti_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestioneContattiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLblContattiCerca;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtbContattiCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnContattiCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnContattiAggiungi;
        private System.Windows.Forms.ToolStripButton toolStripBtnContattiModifica;
        private System.Windows.Forms.ToolStripButton toolStripBtnContattiElimina;
        private System.Windows.Forms.DataGridView dgvContatti;
        private GestioneContattiDataSet GestioneContattiDataSet;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private GestioneMagazziniDataSet1TableAdapters.ContattoTableAdapter contattoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContattoDataGridViewTextBoxColumn;
    }
}