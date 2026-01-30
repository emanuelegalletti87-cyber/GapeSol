using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Magazzini2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMovimento = new System.Windows.Forms.Button();
            this.btnContatti = new System.Windows.Forms.Button();
            this.btnProdotti = new System.Windows.Forms.Button();
            this.btnMagazzini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovimento
            // 
            this.btnMovimento.Location = new System.Drawing.Point(48, 175);
            this.btnMovimento.Margin = new System.Windows.Forms.Padding(2);
            this.btnMovimento.Name = "btnMovimento";
            this.btnMovimento.Size = new System.Drawing.Size(86, 45);
            this.btnMovimento.TabIndex = 3;
            this.btnMovimento.Text = "Movimenti Magazzino";
            this.btnMovimento.UseVisualStyleBackColor = true;
            this.btnMovimento.Click += new System.EventHandler(this.btnMovimento_Click);
            // 
            // btnContatti
            // 
            this.btnContatti.Location = new System.Drawing.Point(48, 87);
            this.btnContatti.Margin = new System.Windows.Forms.Padding(2);
            this.btnContatti.Name = "btnContatti";
            this.btnContatti.Size = new System.Drawing.Size(86, 40);
            this.btnContatti.TabIndex = 4;
            this.btnContatti.Text = "Contatti";
            this.btnContatti.UseVisualStyleBackColor = true;
            this.btnContatti.Click += new System.EventHandler(this.btnContatti_Click);
            // 
            // btnProdotti
            // 
            this.btnProdotti.Location = new System.Drawing.Point(48, 43);
            this.btnProdotti.Margin = new System.Windows.Forms.Padding(2);
            this.btnProdotti.Name = "btnProdotti";
            this.btnProdotti.Size = new System.Drawing.Size(86, 40);
            this.btnProdotti.TabIndex = 6;
            this.btnProdotti.Text = "Prodotti";
            this.btnProdotti.UseVisualStyleBackColor = true;
            this.btnProdotti.Click += new System.EventHandler(this.btnProdotti_Click);
            // 
            // btnMagazzini
            // 
            this.btnMagazzini.Location = new System.Drawing.Point(48, 131);
            this.btnMagazzini.Margin = new System.Windows.Forms.Padding(2);
            this.btnMagazzini.Name = "btnMagazzini";
            this.btnMagazzini.Size = new System.Drawing.Size(86, 40);
            this.btnMagazzini.TabIndex = 0;
            this.btnMagazzini.Text = "Magazzini";
            this.btnMagazzini.UseVisualStyleBackColor = true;
            this.btnMagazzini.Click += new System.EventHandler(this.btnMagazzini_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(504, 272);
            this.Controls.Add(this.btnMagazzini);
            this.Controls.Add(this.btnProdotti);
            this.Controls.Add(this.btnContatti);
            this.Controls.Add(this.btnMovimento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menù";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMovimento;
        private System.Windows.Forms.Button btnContatti;
        private System.Windows.Forms.Button btnProdotti;
        private System.Windows.Forms.Button btnMagazzini;
    }
}

