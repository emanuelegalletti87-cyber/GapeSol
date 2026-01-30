
namespace Magazzini2._0
{
    partial class frmMagazzini
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagazzini));
            this.dgvMagazzini = new System.Windows.Forms.DataGridView();
            this.comuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indirizzoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magazziniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestioneMagazziniDataSet = new Magazzini2._0.GestioneMagazziniDataSet();
            this.toolStripMagazzini = new System.Windows.Forms.ToolStrip();
            this.toolStripLblMagaCerca = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxtbMagaCerca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnMagaCerca = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMagaAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMagaEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMagaDelete = new System.Windows.Forms.ToolStripButton();
            this.magazziniTableAdapter = new Magazzini2._0.GestioneMagazziniDataSetTableAdapters.MagazziniTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazziniBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet)).BeginInit();
            this.toolStripMagazzini.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMagazzini
            // 
            this.dgvMagazzini.AllowUserToAddRows = false;
            this.dgvMagazzini.AllowUserToDeleteRows = false;
            this.dgvMagazzini.AllowUserToResizeColumns = false;
            this.dgvMagazzini.AllowUserToResizeRows = false;
            this.dgvMagazzini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMagazzini.AutoGenerateColumns = false;
            this.dgvMagazzini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazzini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMagazzini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comuneDataGridViewTextBoxColumn,
            this.indirizzoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dgvMagazzini.DataSource = this.magazziniBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMagazzini.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMagazzini.Location = new System.Drawing.Point(0, 30);
            this.dgvMagazzini.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMagazzini.MultiSelect = false;
            this.dgvMagazzini.Name = "dgvMagazzini";
            this.dgvMagazzini.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMagazzini.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMagazzini.RowHeadersWidth = 51;
            this.dgvMagazzini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMagazzini.RowTemplate.Height = 24;
            this.dgvMagazzini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMagazzini.ShowEditingIcon = false;
            this.dgvMagazzini.Size = new System.Drawing.Size(800, 420);
            this.dgvMagazzini.TabIndex = 3;
            // 
            // comuneDataGridViewTextBoxColumn
            // 
            this.comuneDataGridViewTextBoxColumn.DataPropertyName = "Comune";
            this.comuneDataGridViewTextBoxColumn.HeaderText = "Comune";
            this.comuneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comuneDataGridViewTextBoxColumn.Name = "comuneDataGridViewTextBoxColumn";
            this.comuneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indirizzoDataGridViewTextBoxColumn
            // 
            this.indirizzoDataGridViewTextBoxColumn.DataPropertyName = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.HeaderText = "Indirizzo";
            this.indirizzoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.indirizzoDataGridViewTextBoxColumn.Name = "indirizzoDataGridViewTextBoxColumn";
            this.indirizzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // toolStripMagazzini
            // 
            this.toolStripMagazzini.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMagazzini.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblMagaCerca,
            this.toolStripTxtbMagaCerca,
            this.toolStripBtnMagaCerca,
            this.toolStripBtnMagaAdd,
            this.toolStripBtnMagaEdit,
            this.toolStripBtnMagaDelete});
            this.toolStripMagazzini.Location = new System.Drawing.Point(0, 0);
            this.toolStripMagazzini.Name = "toolStripMagazzini";
            this.toolStripMagazzini.Size = new System.Drawing.Size(800, 31);
            this.toolStripMagazzini.TabIndex = 4;
            this.toolStripMagazzini.Text = "toolStrip1";
            // 
            // toolStripLblMagaCerca
            // 
            this.toolStripLblMagaCerca.Name = "toolStripLblMagaCerca";
            this.toolStripLblMagaCerca.Size = new System.Drawing.Size(130, 28);
            this.toolStripLblMagaCerca.Text = "Nome Magazzino:";
            // 
            // toolStripTxtbMagaCerca
            // 
            this.toolStripTxtbMagaCerca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTxtbMagaCerca.Name = "toolStripTxtbMagaCerca";
            this.toolStripTxtbMagaCerca.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripBtnMagaCerca
            // 
            this.toolStripBtnMagaCerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMagaCerca.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMagaCerca.Image")));
            this.toolStripBtnMagaCerca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMagaCerca.Name = "toolStripBtnMagaCerca";
            this.toolStripBtnMagaCerca.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripBtnMagaCerca.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnMagaCerca.Text = "toolStripButton1";
            this.toolStripBtnMagaCerca.Click += new System.EventHandler(this.toolStripBtnMagaCerca_Click);
            // 
            // toolStripBtnMagaAdd
            // 
            this.toolStripBtnMagaAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnMagaAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMagaAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMagaAdd.Image")));
            this.toolStripBtnMagaAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMagaAdd.Name = "toolStripBtnMagaAdd";
            this.toolStripBtnMagaAdd.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnMagaAdd.Text = "Aggiungi";
            this.toolStripBtnMagaAdd.Click += new System.EventHandler(this.toolStripBtnMagaAdd_Click);
            // 
            // toolStripBtnMagaEdit
            // 
            this.toolStripBtnMagaEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnMagaEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMagaEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMagaEdit.Image")));
            this.toolStripBtnMagaEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMagaEdit.Name = "toolStripBtnMagaEdit";
            this.toolStripBtnMagaEdit.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnMagaEdit.Text = "Modifica";
            this.toolStripBtnMagaEdit.Click += new System.EventHandler(this.toolStripBtnMagaEdit_Click);
            // 
            // toolStripBtnMagaDelete
            // 
            this.toolStripBtnMagaDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnMagaDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnMagaDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMagaDelete.Image")));
            this.toolStripBtnMagaDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMagaDelete.Name = "toolStripBtnMagaDelete";
            this.toolStripBtnMagaDelete.Size = new System.Drawing.Size(29, 28);
            this.toolStripBtnMagaDelete.Text = "Elimina";
            this.toolStripBtnMagaDelete.Click += new System.EventHandler(this.toolStripBtnMagaDelete_Click);
            // 
            // magazziniTableAdapter
            // 
            this.magazziniTableAdapter.ClearBeforeFill = true;
            // 
            // frmMagazzini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripMagazzini);
            this.Controls.Add(this.dgvMagazzini);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMagazzini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione Magazzini";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMagazzini_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magazziniBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestioneMagazziniDataSet)).EndInit();
            this.toolStripMagazzini.ResumeLayout(false);
            this.toolStripMagazzini.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GestioneMagazziniDataSet gestioneMagazziniDataSet;
        private System.Windows.Forms.BindingSource magazziniBindingSource;
        private GestioneMagazziniDataSetTableAdapters.MagazziniTableAdapter magazziniTableAdapter;
        private System.Windows.Forms.ToolStrip toolStripMagazzini;
        private System.Windows.Forms.ToolStripLabel toolStripLblMagaCerca;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtbMagaCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnMagaCerca;
        private System.Windows.Forms.ToolStripButton toolStripBtnMagaAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnMagaEdit;
        private System.Windows.Forms.ToolStripButton toolStripBtnMagaDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indirizzoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        internal System.Windows.Forms.DataGridView dgvMagazzini;
    }
}