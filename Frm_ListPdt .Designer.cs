namespace Gestion_de_produits
{
    partial class Frm_ListPdt
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
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Txt_Reference = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Quantite = new System.Windows.Forms.TextBox();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Btn_Retirer = new System.Windows.Forms.Button();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Dgv_Produits = new System.Windows.Forms.DataGridView();
            this.Col_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_QuantiteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des produits";
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(127, 489);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(147, 30);
            this.Btn_Supprimer.TabIndex = 1;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Txt_Reference
            // 
            this.Txt_Reference.Location = new System.Drawing.Point(357, 416);
            this.Txt_Reference.Name = "Txt_Reference";
            this.Txt_Reference.Size = new System.Drawing.Size(144, 22);
            this.Txt_Reference.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Référence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantité";
            // 
            // Txt_Quantite
            // 
            this.Txt_Quantite.Location = new System.Drawing.Point(814, 419);
            this.Txt_Quantite.Name = "Txt_Quantite";
            this.Txt_Quantite.Size = new System.Drawing.Size(144, 22);
            this.Txt_Quantite.TabIndex = 5;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(387, 489);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(147, 30);
            this.Btn_Ajouter.TabIndex = 6;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Btn_Retirer
            // 
            this.Btn_Retirer.Location = new System.Drawing.Point(661, 489);
            this.Btn_Retirer.Name = "Btn_Retirer";
            this.Btn_Retirer.Size = new System.Drawing.Size(147, 30);
            this.Btn_Retirer.TabIndex = 7;
            this.Btn_Retirer.Text = "Retirer";
            this.Btn_Retirer.UseVisualStyleBackColor = true;
            this.Btn_Retirer.Click += new System.EventHandler(this.Btn_Retirer_Click);
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(933, 489);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(147, 30);
            this.Btn_Annuler.TabIndex = 8;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Dgv_Produits
            // 
            this.Dgv_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Produits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Reference,
            this.Col_NomProduit,
            this.Col_PrixUnitaire,
            this.Col_QuantiteStock});
            this.Dgv_Produits.Location = new System.Drawing.Point(78, 81);
            this.Dgv_Produits.Name = "Dgv_Produits";
            this.Dgv_Produits.RowHeadersWidth = 51;
            this.Dgv_Produits.RowTemplate.Height = 24;
            this.Dgv_Produits.Size = new System.Drawing.Size(1056, 290);
            this.Dgv_Produits.TabIndex = 9;
            this.Dgv_Produits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Produits_CellClick);
            // 
            // Col_Reference
            // 
            this.Col_Reference.HeaderText = "Reference";
            this.Col_Reference.MinimumWidth = 6;
            this.Col_Reference.Name = "Col_Reference";
            this.Col_Reference.Width = 125;
            // 
            // Col_NomProduit
            // 
            this.Col_NomProduit.HeaderText = "NomProduit";
            this.Col_NomProduit.MinimumWidth = 6;
            this.Col_NomProduit.Name = "Col_NomProduit";
            this.Col_NomProduit.Width = 125;
            // 
            // Col_PrixUnitaire
            // 
            this.Col_PrixUnitaire.HeaderText = "PrixUnitaire";
            this.Col_PrixUnitaire.MinimumWidth = 6;
            this.Col_PrixUnitaire.Name = "Col_PrixUnitaire";
            this.Col_PrixUnitaire.Width = 125;
            // 
            // Col_QuantiteStock
            // 
            this.Col_QuantiteStock.HeaderText = "QuantiteStock";
            this.Col_QuantiteStock.MinimumWidth = 6;
            this.Col_QuantiteStock.Name = "Col_QuantiteStock";
            this.Col_QuantiteStock.Width = 125;
            // 
            // Frm_ListPdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 606);
            this.Controls.Add(this.Dgv_Produits);
            this.Controls.Add(this.Btn_Annuler);
            this.Controls.Add(this.Btn_Retirer);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Txt_Quantite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Reference);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ListPdt";
            this.Text = "Entrées et sorties en stock";
            this.Load += new System.EventHandler(this.Frm_ListPdt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.TextBox Txt_Reference;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Quantite;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Button Btn_Retirer;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.DataGridView Dgv_Produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_NomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_QuantiteStock;
    }
}