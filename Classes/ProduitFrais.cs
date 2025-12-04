using System;

namespace Gestion_de_produits.Classes
{
    public class ProduitFrais : Produit
    {
        // SEULEMENT la propriété en plus !
        public DateTime DateLimite { get; set; }



        public ProduitFrais(string reference, string nom, float prix, float quantite, DateTime dateLimite)
            : base(reference, nom, prix, quantite)
        {
            DateLimite = dateLimite;
        }

        public int JoursRestants()
        {
            TimeSpan diff = DateLimite - DateTime.Now;
            return diff.Days;
        }

        public override string ToString()
        {
            return base.ToString() + $", Date Limite : {DateLimite.ToShortDateString()}, " +
                   $"Jours restants : {JoursRestants()}";
        }
    }
}