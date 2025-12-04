using Gestion_de_produits.Classes;
using System;
using System.Windows.Forms;

namespace Gestion_de_produits
{
    public partial class Frm_ListPdt : Form
    {
        public Frm_ListPdt()
        {
            InitializeComponent();
        }

        private void RafraichirDataGrid()
        {
            Dgv_Produits.Rows.Clear();

            foreach (Produit p in Utils.ListProduits)
            {
                Dgv_Produits.Rows.Add(
                    p.Reference,
                    p.NomProduit,
                    p.PrixUnitaire,
                    p.QuantiteStock
                );
            }
        }

        private void Frm_ListPdt_Load(object sender, EventArgs e)
        {
            // Charger depuis SQLite
            Utils.ListProduits = Utils.DB.ChargerTousProduits();

            // Rafraîchir l'affichage
            RafraichirDataGrid();
        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Reference.Text))
            {
                MessageBox.Show("Veuillez saisir une référence!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reference = Txt_Reference.Text.Trim();

            Produit produitATrouver = null;
            foreach (Produit p in Utils.ListProduits)
            {
                if (p.Reference == reference)
                {
                    produitATrouver = p;
                    break;
                }
            }

            if (produitATrouver != null)
            {
                DialogResult resultat = MessageBox.Show(
                    $"Voulez-vous vraiment supprimer le produit '{produitATrouver.NomProduit}' ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultat == DialogResult.Yes)
                {
                    Utils.ListProduits.Remove(produitATrouver);
                    Utils.DB.SupprimerProduit(reference);

                    MessageBox.Show("Produit supprimé avec succès!", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RafraichirDataGrid();
                    Txt_Reference.Clear();
                }
            }
            else
            {
                MessageBox.Show("Produit introuvable!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Reference.Text) ||
                string.IsNullOrWhiteSpace(Txt_Quantite.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float quantite;
            if (!float.TryParse(Txt_Quantite.Text, out quantite))
            {
                MessageBox.Show("Quantité invalide!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reference = Txt_Reference.Text.Trim();

            Produit produitTrouve = null;
            foreach (Produit p in Utils.ListProduits)
            {
                if (p.Reference == reference)
                {
                    produitTrouve = p;
                    break;
                }
            }

            if (produitTrouve != null)
            {
                produitTrouve.AjouterQuantite(quantite);
                Utils.DB.MettreAJourQuantite(reference, produitTrouve.QuantiteStock);

                MessageBox.Show("Quantité ajoutée avec succès!", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                RafraichirDataGrid();
                Txt_Reference.Clear();
                Txt_Quantite.Clear();
            }
            else
            {
                MessageBox.Show("Produit introuvable!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Retirer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Reference.Text) ||
                string.IsNullOrWhiteSpace(Txt_Quantite.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float quantite;
            if (!float.TryParse(Txt_Quantite.Text, out quantite))
            {
                MessageBox.Show("Quantité invalide!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reference = Txt_Reference.Text.Trim();

            Produit produitTrouve = null;
            foreach (Produit p in Utils.ListProduits)
            {
                if (p.Reference == reference)
                {
                    produitTrouve = p;
                    break;
                }
            }

            if (produitTrouve != null)
            {
                produitTrouve.RetirerQuantite(quantite);
                Utils.DB.MettreAJourQuantite(reference, produitTrouve.QuantiteStock);

                MessageBox.Show("Quantité retirée avec succès!", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                RafraichirDataGrid();
                Txt_Reference.Clear();
                Txt_Quantite.Clear();
            }
            else
            {
                MessageBox.Show("Produit introuvable!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_Produits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Dgv_Produits.Rows[e.RowIndex];
                Txt_Reference.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}