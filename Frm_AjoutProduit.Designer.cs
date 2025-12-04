namespace Gestion_de_produits
{
    partial class Frm_AjoutProduit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Reference = new System.Windows.Forms.TextBox();
            this.Txt_NomProduit = new System.Windows.Forms.TextBox();
            this.Txt_QteStock = new System.Windows.Forms.TextBox();
            this.Txt_PrixUnit = new System.Windows.Forms.TextBox();
            this.Chk_ProduitFrais = new System.Windows.Forms.CheckBox();
            this.Txt_ProduitFrais = new System.Windows.Forms.TextBox();
            this.Btn_AjoutPdt = new System.Windows.Forms.Button();
            this.Btn_ListePdt = new System.Windows.Forms.Button();
            this.Btn_Rech = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité en stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix unitaire ";
            // 
            // Txt_Reference
            // 
            this.Txt_Reference.Location = new System.Drawing.Point(254, 54);
            this.Txt_Reference.Name = "Txt_Reference";
            this.Txt_Reference.Size = new System.Drawing.Size(216, 22);
            this.Txt_Reference.TabIndex = 4;
            // 
            // Txt_NomProduit
            // 
            this.Txt_NomProduit.Location = new System.Drawing.Point(254, 108);
            this.Txt_NomProduit.Name = "Txt_NomProduit";
            this.Txt_NomProduit.Size = new System.Drawing.Size(216, 22);
            this.Txt_NomProduit.TabIndex = 5;
            // 
            // Txt_QteStock
            // 
            this.Txt_QteStock.Location = new System.Drawing.Point(254, 162);
            this.Txt_QteStock.Name = "Txt_QteStock";
            this.Txt_QteStock.Size = new System.Drawing.Size(216, 22);
            this.Txt_QteStock.TabIndex = 6;
            // 
            // Txt_PrixUnit
            // 
            this.Txt_PrixUnit.Location = new System.Drawing.Point(254, 218);
            this.Txt_PrixUnit.Name = "Txt_PrixUnit";
            this.Txt_PrixUnit.Size = new System.Drawing.Size(216, 22);
            this.Txt_PrixUnit.TabIndex = 7;
            // 
            // Chk_ProduitFrais
            // 
            this.Chk_ProduitFrais.AutoSize = true;
            this.Chk_ProduitFrais.Location = new System.Drawing.Point(82, 276);
            this.Chk_ProduitFrais.Name = "Chk_ProduitFrais";
            this.Chk_ProduitFrais.Size = new System.Drawing.Size(99, 20);
            this.Chk_ProduitFrais.TabIndex = 8;
            this.Chk_ProduitFrais.Text = "Produit frais";
            this.Chk_ProduitFrais.UseVisualStyleBackColor = true;
            this.Chk_ProduitFrais.CheckedChanged += new System.EventHandler(this.Chk_ProduitFrais_CheckedChanged);
            // 
            // Txt_ProduitFrais
            // 
            this.Txt_ProduitFrais.Location = new System.Drawing.Point(254, 277);
            this.Txt_ProduitFrais.Name = "Txt_ProduitFrais";
            this.Txt_ProduitFrais.Size = new System.Drawing.Size(216, 22);
            this.Txt_ProduitFrais.TabIndex = 9;
            // 
            // Btn_AjoutPdt
            // 
            this.Btn_AjoutPdt.Location = new System.Drawing.Point(57, 334);
            this.Btn_AjoutPdt.Name = "Btn_AjoutPdt";
            this.Btn_AjoutPdt.Size = new System.Drawing.Size(142, 27);
            this.Btn_AjoutPdt.TabIndex = 10;
            this.Btn_AjoutPdt.Text = "Ajouter produit ";
            this.Btn_AjoutPdt.UseVisualStyleBackColor = true;
            this.Btn_AjoutPdt.Click += new System.EventHandler(this.Btn_AjoutPdt_Click);
            // 
            // Btn_ListePdt
            // 
            this.Btn_ListePdt.Location = new System.Drawing.Point(225, 334);
            this.Btn_ListePdt.Name = "Btn_ListePdt";
            this.Btn_ListePdt.Size = new System.Drawing.Size(245, 27);
            this.Btn_ListePdt.TabIndex = 11;
            this.Btn_ListePdt.Text = "Afficher liste des produits ";
            this.Btn_ListePdt.UseVisualStyleBackColor = true;
            this.Btn_ListePdt.Click += new System.EventHandler(this.Btn_ListePdt_Click);
            // 
            // Btn_Rech
            // 
            this.Btn_Rech.Location = new System.Drawing.Point(57, 381);
            this.Btn_Rech.Name = "Btn_Rech";
            this.Btn_Rech.Size = new System.Drawing.Size(413, 27);
            this.Btn_Rech.TabIndex = 12;
            this.Btn_Rech.Text = "Recherche multi-critères ";
            this.Btn_Rech.UseVisualStyleBackColor = true;
            this.Btn_Rech.Click += new System.EventHandler(this.Btn_Rech_Click);
            // 
            // Frm_AjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 479);
            this.Controls.Add(this.Btn_Rech);
            this.Controls.Add(this.Btn_ListePdt);
            this.Controls.Add(this.Btn_AjoutPdt);
            this.Controls.Add(this.Txt_ProduitFrais);
            this.Controls.Add(this.Chk_ProduitFrais);
            this.Controls.Add(this.Txt_PrixUnit);
            this.Controls.Add(this.Txt_QteStock);
            this.Controls.Add(this.Txt_NomProduit);
            this.Controls.Add(this.Txt_Reference);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_AjoutProduit";
            this.Text = "Ajout d\'un produit";
            this.Load += new System.EventHandler(this.Frm_AjoutProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Reference;
        private System.Windows.Forms.TextBox Txt_NomProduit;
        private System.Windows.Forms.TextBox Txt_QteStock;
        private System.Windows.Forms.TextBox Txt_PrixUnit;
        private System.Windows.Forms.CheckBox Chk_ProduitFrais;
        private System.Windows.Forms.TextBox Txt_ProduitFrais;
        private System.Windows.Forms.Button Btn_AjoutPdt;
        private System.Windows.Forms.Button Btn_ListePdt;
        private System.Windows.Forms.Button Btn_Rech;
    }
}