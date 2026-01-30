
namespace Magazzini2._0
{
    partial class frmAddEditContatto
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
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtbCognome = new System.Windows.Forms.TextBox();
            this.lblCitta = new System.Windows.Forms.Label();
            this.txtbCitta = new System.Windows.Forms.TextBox();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.txtbIndirizzo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtbTelefono = new System.Windows.Forms.TextBox();
            this.comboBoxTipoContatto = new System.Windows.Forms.ComboBox();
            this.contattoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneContattiDataSet = new Magazzini2._0.GestioneContattiDataSet();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblDataNascita = new System.Windows.Forms.Label();
            this.btnConferma = new System.Windows.Forms.Button();
            this.btnAnnulla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneContattiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataNascita.Location = new System.Drawing.Point(3, 119);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(611, 22);
            this.dtpDataNascita.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(0, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtbNome
            // 
            this.txtbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNome.Location = new System.Drawing.Point(3, 29);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(611, 22);
            this.txtbNome.TabIndex = 2;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(0, 54);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(72, 17);
            this.lblCognome.TabIndex = 3;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtbCognome
            // 
            this.txtbCognome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbCognome.Location = new System.Drawing.Point(3, 74);
            this.txtbCognome.Name = "txtbCognome";
            this.txtbCognome.Size = new System.Drawing.Size(611, 22);
            this.txtbCognome.TabIndex = 4;
            // 
            // lblCitta
            // 
            this.lblCitta.AutoSize = true;
            this.lblCitta.Location = new System.Drawing.Point(0, 144);
            this.lblCitta.Name = "lblCitta";
            this.lblCitta.Size = new System.Drawing.Size(40, 17);
            this.lblCitta.TabIndex = 5;
            this.lblCitta.Text = "Città:";
            // 
            // txtbCitta
            // 
            this.txtbCitta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbCitta.Location = new System.Drawing.Point(3, 164);
            this.txtbCitta.Name = "txtbCitta";
            this.txtbCitta.Size = new System.Drawing.Size(611, 22);
            this.txtbCitta.TabIndex = 6;
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Location = new System.Drawing.Point(0, 189);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(64, 17);
            this.lblIndirizzo.TabIndex = 7;
            this.lblIndirizzo.Text = "Indirizzo:";
            // 
            // txtbIndirizzo
            // 
            this.txtbIndirizzo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbIndirizzo.Location = new System.Drawing.Point(3, 209);
            this.txtbIndirizzo.Name = "txtbIndirizzo";
            this.txtbIndirizzo.Size = new System.Drawing.Size(611, 22);
            this.txtbIndirizzo.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(0, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-Mail:";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbEmail.Location = new System.Drawing.Point(3, 254);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(611, 22);
            this.txtbEmail.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(0, 279);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(132, 17);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Numero di telefono:";
            // 
            // txtbTelefono
            // 
            this.txtbTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTelefono.Location = new System.Drawing.Point(3, 300);
            this.txtbTelefono.Name = "txtbTelefono";
            this.txtbTelefono.Size = new System.Drawing.Size(611, 22);
            this.txtbTelefono.TabIndex = 12;
            // 
            // comboBoxTipoContatto
            // 
            this.comboBoxTipoContatto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTipoContatto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contattoBindingSource, "TipoContatto", true));
            this.comboBoxTipoContatto.DataSource = this.contattoBindingSource;
            this.comboBoxTipoContatto.DisplayMember = "TipoContatto";
            this.comboBoxTipoContatto.FormattingEnabled = true;
            this.comboBoxTipoContatto.Location = new System.Drawing.Point(3, 345);
            this.comboBoxTipoContatto.Name = "comboBoxTipoContatto";
            this.comboBoxTipoContatto.Size = new System.Drawing.Size(611, 24);
            this.comboBoxTipoContatto.TabIndex = 13;
            this.comboBoxTipoContatto.ValueMember = "TipoContatto";
            // 
            // contattoBindingSource
            // 
            this.contattoBindingSource.DataMember = "Contatto";
            this.contattoBindingSource.DataSource = this.gestioneContattiDataSet;
            // 
            // gestioneContattiDataSet
            // 
            this.gestioneContattiDataSet.DataSetName = "GestioneContattiDataSet";
            this.gestioneContattiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(0, 325);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(85, 17);
            this.lblTipoCliente.TabIndex = 14;
            this.lblTipoCliente.Text = "Tipo cliente:";
            // 
            // lblDataNascita
            // 
            this.lblDataNascita.AutoSize = true;
            this.lblDataNascita.Location = new System.Drawing.Point(0, 99);
            this.lblDataNascita.Name = "lblDataNascita";
            this.lblDataNascita.Size = new System.Drawing.Size(106, 17);
            this.lblDataNascita.TabIndex = 15;
            this.lblDataNascita.Text = "Data Di Nascita";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(435, 385);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(88, 23);
            this.btnConferma.TabIndex = 16;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.UseVisualStyleBackColor = true;
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(529, 385);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 17;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // frmAddEditContatto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 420);
            this.Controls.Add(this.btnAnnulla);
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.lblDataNascita);
            this.Controls.Add(this.lblTipoCliente);
            this.Controls.Add(this.comboBoxTipoContatto);
            this.Controls.Add(this.txtbTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtbIndirizzo);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.txtbCitta);
            this.Controls.Add(this.lblCitta);
            this.Controls.Add(this.txtbCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dtpDataNascita);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditContatto";
            this.Text = "Aggiungi/Modifica Contatto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddEditContatto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contattoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneContattiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtbCognome;
        private System.Windows.Forms.Label lblCitta;
        private System.Windows.Forms.TextBox txtbCitta;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.TextBox txtbIndirizzo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtbTelefono;
        private System.Windows.Forms.ComboBox comboBoxTipoContatto;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.BindingSource contattoBindingSource;
        private GestioneContattiDataSet gestioneContattiDataSet;
        private System.Windows.Forms.Label lblDataNascita;
        private System.Windows.Forms.Button btnConferma;
        private System.Windows.Forms.Button btnAnnulla;
    }
}