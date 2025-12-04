using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Gestion_de_produits.Classes;

namespace Gestion_de_produits
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=produits.db;Version=3;";

        public DatabaseHelper()
        {
            CreerBaseDeDonnees();
        }

        private void CreerBaseDeDonnees()
        {
            if (!File.Exists("produits.db"))
            {
                SQLiteConnection.CreateFile("produits.db");
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Produits (
                        Reference TEXT PRIMARY KEY,
                        NomProduit TEXT NOT NULL,
                        PrixUnitaire REAL NOT NULL,
                        QuantiteStock REAL NOT NULL,
                        DateLimite TEXT,
                        EstFrais INTEGER DEFAULT 0
                    )";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool AjouterProduit(Produit produit)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO Produits (Reference, NomProduit, PrixUnitaire, QuantiteStock, DateLimite, EstFrais)
                        VALUES (@ref, @nom, @prix, @qte, @date, @frais)";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ref", produit.Reference);
                        command.Parameters.AddWithValue("@nom", produit.NomProduit);
                        command.Parameters.AddWithValue("@prix", produit.PrixUnitaire);
                        command.Parameters.AddWithValue("@qte", produit.QuantiteStock);

                        if (produit is ProduitFrais)
                        {
                            ProduitFrais pf = (ProduitFrais)produit;
                            command.Parameters.AddWithValue("@date", pf.DateLimite.ToString("yyyy-MM-dd"));
                            command.Parameters.AddWithValue("@frais", 1);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@date", DBNull.Value);
                            command.Parameters.AddWithValue("@frais", 0);
                        }

                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Produit> ChargerTousProduits()
        {
            List<Produit> produits = new List<Produit>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Produits";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string reference = reader["Reference"].ToString();
                        string nomProduit = reader["NomProduit"].ToString();
                        float prixUnitaire = Convert.ToSingle(reader["PrixUnitaire"]);
                        float quantiteStock = Convert.ToSingle(reader["QuantiteStock"]);
                        int estFrais = Convert.ToInt32(reader["EstFrais"]);

                        if (estFrais == 1 && !reader.IsDBNull(reader.GetOrdinal("DateLimite")))
                        {
                            DateTime dateLimite = DateTime.Parse(reader["DateLimite"].ToString());
                            ProduitFrais produitFrais = new ProduitFrais(reference, nomProduit, prixUnitaire, quantiteStock, dateLimite);
                            produits.Add(produitFrais);
                        }
                        else
                        {
                            Produit produit = new Produit(reference, nomProduit, prixUnitaire, quantiteStock);
                            produits.Add(produit);
                        }
                    }
                }
            }

            return produits;
        }

        public bool SupprimerProduit(string reference)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Produits WHERE Reference = @ref";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ref", reference);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool MettreAJourQuantite(string reference, float nouvelleQuantite)
        {
            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Produits SET QuantiteStock = @qte WHERE Reference = @ref";

                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@qte", nouvelleQuantite);
                        command.Parameters.AddWithValue("@ref", reference);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ReferenceExiste(string reference)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Produits WHERE Reference = @ref";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ref", reference);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
