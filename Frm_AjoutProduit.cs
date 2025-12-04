using Gestion_de_produits.Classes;
using System;
using System.Windows.Forms;

namespace Gestion_de_produits
{
    public partial class Frm_AjoutProduit : Form
    {
        public Frm_AjoutProduit()
        {
            InitializeComponent();
        }

        private void Frm_AjoutProduit_Load(object sender, EventArgs e)
        {
            // Initialisation au chargement du formulaire
            Txt_ProduitFrais.Enabled = false;
        }

        private void Btn_AjoutPdt_Click(object sender, EventArgs e)
        {
            // VÉRIFICATION 1 : Les zones ne sont pas vides
            if (string.IsNullOrWhiteSpace(Txt_Reference.Text) ||
                string.IsNullOrWhiteSpace(Txt_NomProduit.Text) ||
                string.IsNullOrWhiteSpace(Txt_PrixUnit.Text) ||
                string.IsNullOrWhiteSpace(Txt_QteStock.Text))
            {
                MessageBox.Show("Vérifiez votre saisie!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VÉRIFICATION 2 : Conversion des nombres
            float prixUnitaire;
            float quantiteStock;

            string prixText = Txt_PrixUnit.Text.Replace('.', ',');
            string qteText = Txt_QteStock.Text.Replace('.', ',');

            if (!float.TryParse(prixText, out prixUnitaire) ||
                !float.TryParse(qteText, out quantiteStock))
            {
                MessageBox.Show("Vérifiez votre saisie!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VÉRIFICATION 3 : Référence unique
            string reference = Txt_Reference.Text.Trim();

            if (Utils.DB.ReferenceExiste(reference))
            {
                MessageBox.Show("Produit existant!", "Erreur",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VÉRIFICATION 4 : Produit Frais ou Normal ?
            if (Chk_ProduitFrais.Checked)
            {
                if (string.IsNullOrWhiteSpace(Txt_ProduitFrais.Text))
                {
                    MessageBox.Show("Vérifiez votre saisie!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dateLimite;

                if (DateTime.TryParse(Txt_ProduitFrais.Text, out dateLimite))
                {
                    ProduitFrais produitFrais = new ProduitFrais(
                        reference,
                        Txt_NomProduit.Text.Trim(),
                        prixUnitaire,
                        quantiteStock,
                        dateLimite
                    );

                    Utils.ListProduits.Add(produitFrais);
                    Utils.DB.AjouterProduit(produitFrais);
                }
                else
                {
                    MessageBox.Show("Vérifiez votre saisie!", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                Produit produit = new Produit(
                    reference,
                    Txt_NomProduit.Text.Trim(),
                    prixUnitaire,
                    quantiteStock
                );

                Utils.ListProduits.Add(produit);
                Utils.DB.AjouterProduit(produit);
            }

            // MESSAGE DE SUCCÈS
            MessageBox.Show("Produit ajouté avec succès!", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Vider les champs
            Txt_Reference.Clear();
            Txt_NomProduit.Clear();
            Txt_PrixUnit.Clear();
            Txt_QteStock.Clear();
            Txt_ProduitFrais.Clear();
            Chk_ProduitFrais.Checked = false;
        }

        private void Chk_ProduitFrais_CheckedChanged(object sender, EventArgs e)
        {
            Txt_ProduitFrais.Enabled = Chk_ProduitFrais.Checked;

            if (!Chk_ProduitFrais.Checked)
            {
                Txt_ProduitFrais.Clear();
            }
        }

        private void Btn_ListePdt_Click(object sender, EventArgs e)
        {
            Frm_ListPdt frmListe = new Frm_ListPdt();
            frmListe.ShowDialog();
        }

        private void Btn_Rech_Click(object sender, EventArgs e)
        {
            Frm_Recherche frmRecherche = new Frm_Recherche();
            frmRecherche.ShowDialog();
        }


    }
}