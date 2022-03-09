using System;
using System.Linq;
namespace MVC.Models
{
    public class Famille
    {
        //Les champs...
        private int _id;
        private string _nom = "";

        //Les propriétés...
        public int Id{ get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        
    }
}
