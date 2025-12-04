using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_produits.Classes
{
    public class Produit
    {
        public string Reference { get; set; }
        public string NomProduit { get; set; }
        public float PrixUnitaire { get; set; }
        public float QuantiteStock { get; set; }

        public Produit(string reference, string nom, float prix, float quantite)
        {
            Reference = reference;
            NomProduit = nom;
            PrixUnitaire = prix;
            QuantiteStock = quantite;
        }

        public void AjouterQuantite(float quantite)
        {
            QuantiteStock += quantite;
        }

        public void RetirerQuantite(float quantite)
        {
            if (quantite >= QuantiteStock)
                QuantiteStock = 0;
            else
                QuantiteStock -= quantite;
        }

        public override string ToString()
        {
            return $"Référence: {Reference}, Nom: {NomProduit}, Prix: {PrixUnitaire} , Quantité de Stock: {QuantiteStock}";
        }
    }
}

