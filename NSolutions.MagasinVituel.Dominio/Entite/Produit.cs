using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSolutions.MagasinVituel.Dominio.Entite
{
    class Produit
    {
        public int IdProduit { get; set; }
        public string Nom { get; set; }
        public string Descrition { get; set; }
        public decimal Prix { get; set; }
        public string Categorie { get; set; }
    }
}
