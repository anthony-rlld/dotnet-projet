using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Postulation
    {
        public long OffreId { get; set; }
        public Offre Offre { get; set; }
        public long EmployeId { get; set; }
        public Employe Employe { get; set; }
        public DateTime Date { get; set; }
        public string Statut { get; set; }
    }
}
