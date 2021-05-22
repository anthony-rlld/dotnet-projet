using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Offre
    {
        public long Id { get; set; }
        public string Intitule { get; set; }
        public DateTime Date { get; set; }
        public float Salaire { get; set; }
        public string Description { get; set; }
        public long StatutId { get; set; }
        public Statut Statut { get; set; }
        public string Responsable { get; set; }
        public ICollection<Postulation> Postulations { get; set; }
    }
}
