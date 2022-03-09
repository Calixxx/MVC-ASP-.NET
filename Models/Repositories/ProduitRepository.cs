using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Models.Repositories
{
    public class ProduitRepository : IRepository<Produit>
    {
        //Le champ
        private IList<Produit> _produits;

        //La propriété
        public IList<Produit> Produits { get => _produits; set => _produits = value; }

        //Le constructor

        public ProduitRepository()
        {
            Produits = new List<Produit>
            {
                new Produit
                {
                    Id = 1,
                    Reference ="Ma reférence",
                    Description = "Ma description",
                    Designation = "Ma désignation",
                    Disponible = true,
                    Famille = new Famille{ Id = 1 , Nom ="Imprimantes" }
                },

                new Produit
                {
                    Id = 2,
                    Reference ="Ma reférence",
                    Description = "Ma description",
                    Designation = "Ma désignation",
                    Disponible = false,
                    Famille = new Famille{ Id = 1 , Nom ="Ordinateurs" }
                },

                new Produit
                {
                    Id = 3,
                    Reference ="Ma reférence",
                    Description = "Ma description",
                    Designation = "Ma désignation",
                    Disponible = true,
                    Famille = new Famille{ Id = 1 , Nom ="Souris" }
                },
            };
        }

        public void Ajouter(Produit element)
        {
            //  element.Id = Produits.Max(a => a.id);
            Produits.Add(element);
        }

        public IList<Produit> Lister()
        {
            return Produits;
        }

        public Produit ListerSelonId(int id)
        {
            return Produits.SingleOrDefault(produit => produit.Id == id);
        }

        public void Modifier(int id, Produit element)
        {
            var ancienProduit = ListerSelonId(id);
            ancienProduit.Reference = element.Reference;
            ancienProduit.Designation = element.Designation;
            ancienProduit.Description = element.Description;
            ancienProduit.Famille = element.Famille;
            ancienProduit.Disponible = element.Disponible;
        }

        public void Supprimer(int id)
        {
            var produit = ListerSelonId(id);
            Produits.Remove(produit);
        }
    }
}
