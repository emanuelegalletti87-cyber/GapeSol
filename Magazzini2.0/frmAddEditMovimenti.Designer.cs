namespace Magazzini2._0
{
    partial class frmAddEditMovimenti
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
            this.lblMagazzino = new System.Windows.Forms.Label();
            this.lblContatto = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.lblTipoMovimento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.magazziniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneMagazziniDataSet = new Magazzini2._0.GestioneMagazziniDataSet();
            this.txtbContatto = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPrezzoTotale = new System.Windows.Forms.Label();
            this.magazziniTableAdapter = new Magazzini2._0.GestioneMagazziniDataSetTableAdapters.MagazziniTableAdapter();
            this.dgvProdotto = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneProdottiDataSet = new Magazzini2._0.GestioneProdottiDataSet();
            this.dgvContatto = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContattoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneContattiDataSet2 = new Magazzini2._0.GestioneContattiDataSet2();
            this.prodottiTableAdapter = new Magazzini2._0.GestioneProdottiDataSetTableAdapters.ProdottiTableAdapter();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            this.contattoTableAdapter = new Magazzini2._0.GestioneContattiDataSet2TableAdapters.ContattoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.magazziniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProdottiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneContattiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMagazzino
            // 
            this.lblMagazzino.AutoSize = true;
            this.lblMagazzino.Location = new System.Drawing.Point(16, 11);
            this.lblMagazzino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMagazzino.Name = "lblMagazzino";
            this.lblMagazzino.Size = new System.Drawing.Size(80, 17);
            this.lblMagazzino.TabIndex = 0;
            this.lblMagazzino.Text = "Magazzino:";
            // 
            // lblContatto
            // 
            this.lblContatto.AutoSize = true;
            this.lblContatto.Location = new System.Drawing.Point(16, 38);
            this.lblContatto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContatto.Name = "lblContatto";
            this.lblContatto.Size = new System.Drawing.Size(65, 17);
            this.lblContatto.TabIndex = 1;
            this.lblContatto.Text = "Contatto:";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(16, 69);
            this.lblPrezzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(56, 17);
            this.lblPrezzo.TabIndex = 2;
            this.lblPrezzo.Text = "Prezzo:";
            // 
            // lblQuantita
            // 
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(16, 97);
            this.lblQuantita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(66, 17);
            this.lblQuantita.TabIndex = 3;
            this.lblQuantita.Text = "Quantità:";
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Location = new System.Drawing.Point(16, 129);
            this.lblTipoMovimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(112, 17);
            this.lblTipoMovimento.TabIndex = 4;
            this.lblTipoMovimento.Text = "Tipo Movimento:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(16, 160);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(42, 17);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.magazziniBindingSource, "Nome", true));
            this.comboBox1.DataSource = this.magazziniBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Nome";
            // 
            // magazziniBindingSource
            // 
            this.magazziniBindingSource.DataMember = "Magazzini";
            this.magazziniBindingSource.DataSource = this.gestioneMagazziniDataSet;
            // 
            // gestioneMagazziniDataSet
            // 
            this.gestioneMagazziniDataSet.DataSetName = "GestioneMagazziniDataSet";
            this.gestioneMagazziniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtbContatto
            // 
            this.txtbContatto.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtbContatto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbContatto.Location = new System.Drawing.Point(91, 34);
            this.txtbContatto.Margin = new System.Windows.Forms.Padding(4);
            this.txtbContatto.Name = "txtbContatto";
            this.txtbContatto.ReadOnly = true;
            this.txtbContatto.Size = new System.Drawing.Size(243, 22);
            this.txtbContatto.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 66);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(255, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(91, 95);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(244, 22);
            this.numericUpDown2.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(139, 126);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 153);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lblPrezzoTotale
            // 
            this.lblPrezzoTotale.AutoSize = true;
            this.lblPrezzoTotale.Location = new System.Drawing.Point(359, 11);
            this.lblPrezzoTotale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrezzoTotale.Name = "lblPrezzoTotale";
            this.lblPrezzoTotale.Size = new System.Drawing.Size(100, 17);
            this.lblPrezzoTotale.TabIndex = 12;
            this.lblPrezzoTotale.Text = "Prezzo Totale:";
            // 
            // magazziniTableAdapter
            // 
            this.magazziniTableAdapter.ClearBeforeFill = true;
            // 
            // dgvProdotto
            // 
            this.dgvProdotto.AllowUserToAddRows = false;
            this.dgvProdotto.AllowUserToDeleteRows = false;
            this.dgvProdotto.AutoGenerateColumns = false;
            this.dgvProdotto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdotto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descrizioneDataGridViewTextBoxColumn,
            this.prezzoUnitarioDataGridViewTextBoxColumn});
            this.dgvProdotto.DataSource = this.prodottiBindingSource;
            this.dgvProdotto.Location = new System.Drawing.Point(3, 185);
            this.dgvProdotto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdotto.Name = "dgvProdotto";
            this.dgvProdotto.ReadOnly = true;
            this.dgvProdotto.RowHeadersWidth = 51;
            this.dgvProdotto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdotto.Size = new System.Drawing.Size(528, 325);
            this.dgvProdotto.TabIndex = 13;
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
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            this.descrizioneDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezzoUnitarioDataGridViewTextBoxColumn
            // 
            this.prezzoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrezzoUnitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.HeaderText = "PrezzoUnitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezzoUnitarioDataGridViewTextBoxColumn.Name = "prezzoUnitarioDataGridViewTextBoxColumn";
            this.prezzoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.prezzoUnitarioDataGridViewTextBoxColumn.Width = 125;
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
            // dgvContatto
            // 
            this.dgvContatto.AllowUserToAddRows = false;
            this.dgvContatto.AllowUserToDeleteRows = false;
            this.dgvContatto.AutoGenerateColumns = false;
            this.dgvContatto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.cognomeDataGridViewTextBoxColumn,
            this.dataDiNascitaDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.cittaDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoContattoDataGridViewTextBoxColumn});
            this.dgvContatto.DataSource = this.contattoBindingSource;
            this.dgvContatto.Location = new System.Drawing.Point(539, 185);
            this.dgvContatto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContatto.Name = "dgvContatto";
            this.dgvContatto.ReadOnly = true;
            this.dgvContatto.RowHeadersWidth = 51;
            this.dgvContatto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatto.Size = new System.Drawing.Size(505, 325);
            this.dgvContatto.TabIndex = 14;
            this.dgvContatto.SelectionChanged += new System.EventHandler(this.dgvContatto_SelectionChanged);
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cognomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataDiNascitaDataGridViewTextBoxColumn
            // 
            this.dataDiNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.HeaderText = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataDiNascitaDataGridViewTextBoxColumn.Name = "dataDiNascitaDataGridViewTextBoxColumn";
            this.dataDiNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDiNascitaDataGridViewTextBoxColumn.Width = 125;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            this.indirizzoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            this.cittaDataGridViewTextBoxColumn.DataPropertyName = "Citta";
            this.cittaDataGridViewTextBoxColumn.HeaderText = "Citta";
            this.cittaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            this.cittaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cittaDataGridViewTextBoxColumn.Width = 125;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoContattoDataGridViewTextBoxColumn
            // 
            this.tipoContattoDataGridViewTextBoxColumn.DataPropertyName = "TipoContatto";
            this.tipoContattoDataGridViewTextBoxColumn.HeaderText = "TipoContatto";
            this.tipoContattoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoContattoDataGridViewTextBoxColumn.Name = "tipoContattoDataGridViewTextBoxColumn";
            this.tipoContattoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoContattoDataGridViewTextBoxColumn.Width = 125;
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataMember = "Contatto";
            this.contattoBindingSource.DataSource = this.gestioneContattiDataSet2;
            // 
            // gestioneContattiDataSet2
            // 
            this.gestioneContattiDataSet2.DataSetName = "GestioneContattiDataSet2";
            this.gestioneContattiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodottiTableAdapter
            // 
            this.prodottiTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(944, 153);
            this.btnAnnulla.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(100, 28);
            this.btnAnnulla.TabIndex = 15;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(836, 153);
            this.btnConferma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(100, 28);
            this.btnConferma.TabIndex = 16;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            // 
            // contattoTableAdapter
            // 
            this.contattoTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddEditMovimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1045, 512);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.dgvContatto);
            this.Controls.Add(this.dgvProdotto);
            this.Controls.Add(this.lblPrezzoTotale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtbContatto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTipoMovimento);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblContatto);
            this.Controls.Add(this.lblMagazzino);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEditMovimenti";
            this.Text = "Aggiungi/Modifica Movimento";
            this.Load += new System.EventHandler(this.frmAddEditMovimenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.magazziniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProdottiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneContattiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMagazzino;
        private System.Windows.Forms.Label lblContatto;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.Label lblTipoMovimento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbContatto;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPrezzoTotale;
        private GestioneMagazziniDataSet gestioneMagazziniDataSet;
        private System.Windows.Forms.BindingSource magazziniBindingSource;
        private GestioneMagazziniDataSetTableAdapters.MagazziniTableAdapter magazziniTableAdapter;
        private System.Windows.Forms.DataGridView dgvProdotto;
        private System.Windows.Forms.DataGridView dgvContatto;
        private GestioneProdottiDataSet gestioneProdottiDataSet;
        private System.Windows.Forms.BindingSource prodottiBindingSource;
        private GestioneProdottiDataSetTableAdapters.ProdottiTableAdapter prodottiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrizioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezzoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
        private GestioneContattiDataSet2 gestioneContattiDataSet2;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private GestioneContattiDataSet2TableAdapters.ContattoTableAdapter contattoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContattoDataGridViewTextBoxColumn;
    }
}