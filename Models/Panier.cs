using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class Panier
    {
        public string ProduitNom { get; set; }
        public int Quantite { get; set; }
        public decimal Prix { get; set; }
    }
}