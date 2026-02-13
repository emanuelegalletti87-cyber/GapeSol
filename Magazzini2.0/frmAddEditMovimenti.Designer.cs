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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPrezzoTotale = new System.Windows.Forms.Label();
            this.gestioneMagazziniDataSet = new Magazzini2._0.GestioneMagazziniDataSet();
            this.magazziniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magazziniTableAdapter = new Magazzini2._0.GestioneMagazziniDataSetTableAdapters.MagazziniTableAdapter();
            this.dgvProdotto = new System.Windows.Forms.DataGridView();
            this.dgvContatto = new System.Windows.Forms.DataGridView();
            this.gestioneProdottiDataSet = new Magazzini2._0.GestioneProdottiDataSet();
            this.prodottiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodottiTableAdapter = new Magazzini2._0.GestioneProdottiDataSetTableAdapters.ProdottiTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrizioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezzoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestioneContattiDataSet = new Magazzini2._0.GestioneContattiDataSet();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDiNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cittaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoContattoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConferma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazziniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProdottiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneContattiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMagazzino
            // 
            this.lblMagazzino.AutoSize = true;
            this.lblMagazzino.Location = new System.Drawing.Point(12, 9);
            this.lblMagazzino.Name = "lblMagazzino";
            this.lblMagazzino.Size = new System.Drawing.Size(61, 13);
            this.lblMagazzino.TabIndex = 0;
            this.lblMagazzino.Text = "Magazzino:";
            // 
            // lblContatto
            // 
            this.lblContatto.AutoSize = true;
            this.lblContatto.Location = new System.Drawing.Point(12, 31);
            this.lblContatto.Name = "lblContatto";
            this.lblContatto.Size = new System.Drawing.Size(50, 13);
            this.lblContatto.TabIndex = 1;
            this.lblContatto.Text = "Contatto:";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Location = new System.Drawing.Point(12, 56);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(42, 13);
            this.lblPrezzo.TabIndex = 2;
            this.lblPrezzo.Text = "Prezzo:";
            // 
            // lblQuantita
            // 
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(12, 79);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(50, 13);
            this.lblQuantita.TabIndex = 3;
            this.lblQuantita.Text = "Quantità:";
            // 
            // lblTipoMovimento
            // 
            this.lblTipoMovimento.AutoSize = true;
            this.lblTipoMovimento.Location = new System.Drawing.Point(12, 105);
            this.lblTipoMovimento.Name = "lblTipoMovimento";
            this.lblTipoMovimento.Size = new System.Drawing.Size(86, 13);
            this.lblTipoMovimento.TabIndex = 4;
            this.lblTipoMovimento.Text = "Tipo Movimento:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 130);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "Data:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.magazziniBindingSource, "Nome", true));
            this.comboBox1.DataSource = this.magazziniBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(68, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(60, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(191, 20);
            this.numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(68, 77);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(183, 20);
            this.numericUpDown2.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(104, 102);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lblPrezzoTotale
            // 
            this.lblPrezzoTotale.AutoSize = true;
            this.lblPrezzoTotale.Location = new System.Drawing.Point(269, 9);
            this.lblPrezzoTotale.Name = "lblPrezzoTotale";
            this.lblPrezzoTotale.Size = new System.Drawing.Size(75, 13);
            this.lblPrezzoTotale.TabIndex = 12;
            this.lblPrezzoTotale.Text = "Prezzo Totale:";
            // 
            // gestioneMagazziniDataSet
            // 
            this.gestioneMagazziniDataSet.DataSetName = "GestioneMagazziniDataSet";
            this.gestioneMagazziniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // magazziniBindingSource
            // 
            this.magazziniBindingSource.DataMember = "Magazzini";
            this.magazziniBindingSource.DataSource = this.gestioneMagazziniDataSet;
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
            this.dgvProdotto.Location = new System.Drawing.Point(2, 150);
            this.dgvProdotto.Name = "dgvProdotto";
            this.dgvProdotto.ReadOnly = true;
            this.dgvProdotto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdotto.Size = new System.Drawing.Size(396, 264);
            this.dgvProdotto.TabIndex = 13;
            // 
            // dgvContatto
            // 
            this.dgvContatto.AllowUserToAddRows = false;
            this.dgvContatto.AllowUserToDeleteRows = false;
            this.dgvContatto.AutoGenerateColumns = false;
            this.dgvContatto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.cognomeDataGridViewTextBoxColumn,
            this.dataDiNascitaDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.cittaDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoContattoDataGridViewTextBoxColumn});
            this.dgvContatto.DataSource = this.contattoBindingSource;
            this.dgvContatto.Location = new System.Drawing.Point(404, 150);
            this.dgvContatto.Name = "dgvContatto";
            this.dgvContatto.ReadOnly = true;
            this.dgvContatto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatto.Size = new System.Drawing.Size(379, 264);
            this.dgvContatto.TabIndex = 14;
            // 
            // gestioneProdottiDataSet
            // 
            this.gestioneProdottiDataSet.DataSetName = "GestioneProdottiDataSet";
            this.gestioneProdottiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prodottiBindingSource
            // 
            this.prodottiBindingSource.DataMember = "Prodotti";
            this.prodottiBindingSource.DataSource = this.gestioneProdottiDataSet;
            // 
            // prodottiTableAdapter
            // 
            this.prodottiTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrizioneDataGridViewTextBoxColumn
            // 
            this.descrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione";
            this.descrizioneDataGridViewTextBoxColumn.Name = "descrizioneDataGridViewTextBoxColumn";
            this.descrizioneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezzoUnitarioDataGridViewTextBoxColumn
            // 
            this.prezzoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrezzoUnitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.HeaderText = "PrezzoUnitario";
            this.prezzoUnitarioDataGridViewTextBoxColumn.Name = "prezzoUnitarioDataGridViewTextBoxColumn";
            this.prezzoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gestioneContattiDataSet
            // 
            this.gestioneContattiDataSet.DataSetName = "GestioneContattiDataSet";
            this.gestioneContattiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataMember = "Contatto";
            this.contattoBindingSource.DataSource = this.gestioneContattiDataSet;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDiNascitaDataGridViewTextBoxColumn
            // 
            this.dataDiNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.HeaderText = "DataDiNascita";
            this.dataDiNascitaDataGridViewTextBoxColumn.Name = "dataDiNascitaDataGridViewTextBoxColumn";
            this.dataDiNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cittaDataGridViewTextBoxColumn
            // 
            this.cittaDataGridViewTextBoxColumn.DataPropertyName = "Citta";
            this.cittaDataGridViewTextBoxColumn.HeaderText = "Citta";
            this.cittaDataGridViewTextBoxColumn.Name = "cittaDataGridViewTextBoxColumn";
            this.cittaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "EMail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "EMail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoContattoDataGridViewTextBoxColumn
            // 
            this.tipoContattoDataGridViewTextBoxColumn.DataPropertyName = "TipoContatto";
            this.tipoContattoDataGridViewTextBoxColumn.HeaderText = "TipoContatto";
            this.tipoContattoDataGridViewTextBoxColumn.Name = "tipoContattoDataGridViewTextBoxColumn";
            this.tipoContattoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(708, 124);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 15;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(627, 124);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(75, 23);
            this.btnConferma.TabIndex = 16;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            // 
            // frmAddEditMovimenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 416);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.dgvContatto);
            this.Controls.Add(this.dgvProdotto);
            this.Controls.Add(this.lblPrezzoTotale);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTipoMovimento);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblContatto);
            this.Controls.Add(this.lblMagazzino);
            this.Name = "frmAddEditMovimenti";
            this.Text = "Aggiungi/Modifica Movimento";
            this.Load += new System.EventHandler(this.frmAddEditMovimenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazziniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneProdottiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodottiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneContattiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDiNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cittaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoContattoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private GestioneContattiDataSet gestioneContattiDataSet;
        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConferma;
    }
}