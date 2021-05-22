using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Statut
    {
        public long Id { get; set; }
        public string Libelle { get; set; }
        public ICollection<Offre> Offres { get; set; }
    }
}
