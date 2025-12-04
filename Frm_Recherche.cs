using Gestion_de_produits.Classes;
using System;
using System.Windows.Forms;

namespace Gestion_de_produits
{
    public partial class Frm_Recherche : Form
    {
        public Frm_Recherche()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Méthode vide - on ne fait rien
        }

        // ÉVÉNEMENT DE LA CHECKBOX
        private void checkFRAIS_CheckedChanged(object sender, EventArgs e)
        {
            // Optionnel : changer l'apparence
            if (checkFRAIS.Checked)
            {
                checkFRAIS.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                checkFRAIS.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void Btn_Rechercher_Click(object sender, EventArgs e)
        {
            // Charger depuis SQLite
            Utils.ListProduits = Utils.DB.ChargerTousProduits();
            Dgv_Resultats.Rows.Clear();

            // Récupérer les critères de recherche (en minuscules pour comparaison)
            string reference = Txt_Reference.Text.Trim().ToLower();
            string nomProduit = Txt_NomProduit.Text.Trim().ToLower();

            // Gérer les prix min et max
            float prixMin = 0;
            float prixMax = float.MaxValue; // Valeur maximale possible

            // Si l'utilisateur a saisi un prix minimum
            if (!string.IsNullOrWhiteSpace(Txt_PrixMin.Text))
            {
                if (!float.TryParse(Txt_PrixMin.Text, out prixMin))
                {
                    MessageBox.Show("Prix minimum invalide!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Si l'utilisateur a saisi un prix maximum
            if (!string.IsNullOrWhiteSpace(Txt_PrixMax.Text))
            {
                if (!float.TryParse(Txt_PrixMax.Text, out prixMax))
                {
                    MessageBox.Show("Prix maximum invalide!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Parcourir tous les produits et appliquer les filtres
            int compteur = 0;
            foreach (Produit p in Utils.ListProduits)
            {
                // Vérifier chaque critère (un champ vide = critère ignoré)

                // Critère 1 : Référence
                bool correspondReference = string.IsNullOrWhiteSpace(reference) ||
                                           p.Reference.ToLower().Contains(reference);

                // Critère 2 : Nom du produit
                bool correspondNom = string.IsNullOrWhiteSpace(nomProduit) ||
                                    p.NomProduit.ToLower().Contains(nomProduit);

                // Critère 3 : Prix entre min et max
                bool correspondPrix = (p.PrixUnitaire >= prixMin) &&
                                     (p.PrixUnitaire <= prixMax);

                // CRITÈRE 4 : Produit Frais (NOUVEAU)
                bool correspondFrais = true;
                if (checkFRAIS.Checked)
                {
                    // Si checkbox cochée, accepter SEULEMENT les produits frais
                    correspondFrais = (p is ProduitFrais);
                }

                // Si TOUS les critères correspondent
                if (correspondReference && correspondNom && correspondPrix && correspondFrais)
                {
                    // Ajouter le produit aux résultats
                    Dgv_Resultats.Rows.Add(
                        p.Reference,
                        p.NomProduit,
                        p.PrixUnitaire,
                        p.QuantiteStock
                    );
                    compteur++;
                }
            }

            // Afficher le résultat de la recherche
            if (compteur == 0)
            {
                MessageBox.Show("Aucun produit trouvé!", "Recherche",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{compteur} produit(s) trouvé(s)!", "Recherche",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Recherche_Load(object sender, EventArgs e)
        {
        }
    }
}