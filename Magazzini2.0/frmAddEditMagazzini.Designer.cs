
namespace Magazzini2._0
{
    partial class frmAddEditMagazzini
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
            this.btnAnnulla = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblComune = new System.Windows.Forms.Label();
            this.lblIndirizzo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbComune = new System.Windows.Forms.TextBox();
            this.txtbIndirizzo = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAnnulla
            // 
            this.btnAnnulla.Location = new System.Drawing.Point(395, 136);
            this.btnAnnulla.Name = "btnAnnulla";
            this.btnAnnulla.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulla.TabIndex = 0;
            this.btnAnnulla.Text = "Annulla";
            this.btnAnnulla.UseVisualStyleBackColor = true;
            this.btnAnnulla.Click += new System.EventHandler(this.btnAnnulla_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(314, 137);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Ok";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblComune
            // 
            this.lblComune.AutoSize = true;
            this.lblComune.Location = new System.Drawing.Point(13, 13);
            this.lblComune.Name = "lblComune";
            this.lblComune.Size = new System.Drawing.Size(60, 17);
            this.lblComune.TabIndex = 2;
            this.lblComune.Text = "Comune";
            // 
            // lblIndirizzo
            // 
            this.lblIndirizzo.AutoSize = true;
            this.lblIndirizzo.Location = new System.Drawing.Point(13, 64);
            this.lblIndirizzo.Name = "lblIndirizzo";
            this.lblIndirizzo.Size = new System.Drawing.Size(53, 17);
            this.lblIndirizzo.TabIndex = 3;
            this.lblIndirizzo.Text = "Indirizo";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 117);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtbComune
            // 
            this.txtbComune.Location = new System.Drawing.Point(16, 33);
            this.txtbComune.Name = "txtbComune";
            this.txtbComune.Size = new System.Drawing.Size(100, 22);
            this.txtbComune.TabIndex = 5;
            // 
            // txtbIndirizzo
            // 
            this.txtbIndirizzo.Location = new System.Drawing.Point(16, 84);
            this.txtbIndirizzo.Name = "txtbIndirizzo";
            this.txtbIndirizzo.Size = new System.Drawing.Size(100, 22);
            this.txtbIndirizzo.TabIndex = 6;
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(16, 137);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 22);
            this.txtbNome.TabIndex = 7;
            // 
            // frmAddEditMagazzini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 163);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.txtbIndirizzo);
            this.Controls.Add(this.txtbComune);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblIndirizzo);
            this.Controls.Add(this.lblComune);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnAnnulla);
            this.Name = "frmAddEditMagazzini";
            this.Text = "Modifica Magazzino";
            this.Load += new System.EventHandler(this.frmAddEditMagazzini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulla;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblComune;
        private System.Windows.Forms.Label lblIndirizzo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbComune;
        private System.Windows.Forms.TextBox txtbIndirizzo;
        private System.Windows.Forms.TextBox txtbNome;
    }
}