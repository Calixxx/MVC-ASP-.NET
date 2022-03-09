using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC.Models.Repositories
{
    public class FamilleRepository : IRepository<Famille>
    {

        //Le champ
        private IList<Famille> _familles;
        //Une propriété
        public IList<Famille> Familles { get => _familles; set => _familles = value; }

        //Le constructor -ctor
        public FamilleRepository()
        {
            Familles = new List<Famille>()
            {
                new Famille
                {
                    Id = 1, Nom = "Imprimantes"
                },
                new Famille
                {
                    Id = 2, Nom = "Ordinateurs"
                },
                new Famille
                {
                    Id = 3, Nom = "Souris"
                },
            };
        }

        //Create
        public void Ajouter(Famille element)
        {
            Familles.Add(element);
        }

        //Read (1) and (2)
        public IList<Famille> Lister()
        {
            return Familles;
        }

        public Famille ListerSelonId(int id)
        {
            return Familles.SingleOrDefault(famille => famille.Id == id);
        }

        //Update
        public void Modifier(int id, Famille element)
        {
            //var ancienneFamille = Familles.SingleOrDefault(famille => famille.Id == id);
            var ancienneFamille = ListerSelonId(id);
            ancienneFamille.Nom = element.Nom; 
        }

        //Delete
        public void Supprimer(int id)
        {
            //var famille = Familles.Single(famille => famille.Id == id);
            var famille = ListerSelonId(id);
            Familles.Remove(famille);
        }
    }
}
