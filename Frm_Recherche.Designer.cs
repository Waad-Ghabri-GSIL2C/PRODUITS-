namespace Gestion_de_produits
{
    partial class Frm_Recherche
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
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Reference = new System.Windows.Forms.TextBox();
            this.Btn_Rechercher = new System.Windows.Forms.Button();
            this.Txt_NomProduit = new System.Windows.Forms.TextBox();
            this.Txt_PrixMin = new System.Windows.Forms.TextBox();
            this.Txt_PrixMax = new System.Windows.Forms.TextBox();
            this.Dgv_Resultats = new System.Windows.Forms.DataGridView();
            this.Col_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_NomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_QuantiteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkFRAIS = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resultats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Liste des produits ";
            // 
            // Txt_Reference
            // 
            this.Txt_Reference.Location = new System.Drawing.Point(196, 57);
            this.Txt_Reference.Name = "Txt_Reference";
            this.Txt_Reference.Size = new System.Drawing.Size(178, 22);
            this.Txt_Reference.TabIndex = 5;
            // 
            // Btn_Rechercher
            // 
            this.Btn_Rechercher.Location = new System.Drawing.Point(937, 57);
            this.Btn_Rechercher.Name = "Btn_Rechercher";
            this.Btn_Rechercher.Size = new System.Drawing.Size(124, 38);
            this.Btn_Rechercher.TabIndex = 6;
            this.Btn_Rechercher.Text = "Rechercher";
            this.Btn_Rechercher.UseVisualStyleBackColor = true;
            this.Btn_Rechercher.Click += new System.EventHandler(this.Btn_Rechercher_Click);
            // 
            // Txt_NomProduit
            // 
            this.Txt_NomProduit.Location = new System.Drawing.Point(196, 97);
            this.Txt_NomProduit.Name = "Txt_NomProduit";
            this.Txt_NomProduit.Size = new System.Drawing.Size(178, 22);
            this.Txt_NomProduit.TabIndex = 7;
            // 
            // Txt_PrixMin
            // 
            this.Txt_PrixMin.Location = new System.Drawing.Point(672, 38);
            this.Txt_PrixMin.Name = "Txt_PrixMin";
            this.Txt_PrixMin.Size = new System.Drawing.Size(178, 22);
            this.Txt_PrixMin.TabIndex = 8;
            // 
            // Txt_PrixMax
            // 
            this.Txt_PrixMax.Location = new System.Drawing.Point(672, 94);
            this.Txt_PrixMax.Name = "Txt_PrixMax";
            this.Txt_PrixMax.Size = new System.Drawing.Size(178, 22);
            this.Txt_PrixMax.TabIndex = 9;
            // 
            // Dgv_Resultats
            // 
            this.Dgv_Resultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Resultats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Reference,
            this.Col_NomProduit,
            this.Col_PrixUnitaire,
            this.Col_QuantiteStock});
            this.Dgv_Resultats.Location = new System.Drawing.Point(93, 218);
            this.Dgv_Resultats.Name = "Dgv_Resultats";
            this.Dgv_Resultats.RowHeadersWidth = 51;
            this.Dgv_Resultats.RowTemplate.Height = 24;
            this.Dgv_Resultats.Size = new System.Drawing.Size(949, 182);
            this.Dgv_Resultats.TabIndex = 10;
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
            // checkFRAIS
            // 
            this.checkFRAIS.AutoSize = true;
            this.checkFRAIS.Location = new System.Drawing.Point(73, 21);
            this.checkFRAIS.Name = "checkFRAIS";
            this.checkFRAIS.Size = new System.Drawing.Size(102, 20);
            this.checkFRAIS.TabIndex = 11;
            this.checkFRAIS.Text = "Produit frais ";
            this.checkFRAIS.UseVisualStyleBackColor = true;
            this.checkFRAIS.CheckedChanged += new System.EventHandler(this.checkFRAIS_CheckedChanged);
            // 
            // Frm_Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.checkFRAIS);
            this.Controls.Add(this.Dgv_Resultats);
            this.Controls.Add(this.Txt_PrixMax);
            this.Controls.Add(this.Txt_PrixMin);
            this.Controls.Add(this.Txt_NomProduit);
            this.Controls.Add(this.Btn_Rechercher);
            this.Controls.Add(this.Txt_Reference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Recherche";
            this.Text = "Recherche multi-critères";
            this.Load += new System.EventHandler(this.Frm_Recherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resultats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Reference;
        private System.Windows.Forms.Button Btn_Rechercher;
        private System.Windows.Forms.TextBox Txt_NomProduit;
        private System.Windows.Forms.TextBox Txt_PrixMin;
        private System.Windows.Forms.TextBox Txt_PrixMax;
        private System.Windows.Forms.DataGridView Dgv_Resultats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_NomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_QuantiteStock;
        private System.Windows.Forms.CheckBox checkFRAIS;
    }
}