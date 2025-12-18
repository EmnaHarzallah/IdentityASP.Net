using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp1.Models
{
    public class PanierParUser
    {
        public Guid Id { get; set; }
        public string? UserID { get; set; }
        public Guid ProduitId { get; set; }
        public List<Produit> Produits { get; set; }
    }
}