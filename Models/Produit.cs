using System;
using System.Linq;
namespace MVC.Models
{
    public class Produit
    {
        //Les champs...
        private int _id;
        private string _reference = "";
        private string _designation = "";
        private string _description = "";
        private bool _disponible;
        private Produit _famille;

        //Les propriétés...
        public int Id { get => _id; set => _id = value; }
        public string Reference { get => _reference; set => _reference = value; }
        public string Designation { get => _designation; set => _designation = value; }
        public string Description { get => _description; set => _description = value; }
        public bool Disponible { get => _disponible; set => _disponible = value; }
        public Produit Famille { get => _famille; set => _famille = value; }

        public static implicit operator Produit(Famille v)
        {
            throw new NotImplementedException();
        }
    }
}
