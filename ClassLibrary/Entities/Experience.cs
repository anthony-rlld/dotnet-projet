using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Experience
    {
        public long Id { get; set;  }
        public long EmployeId { get; set; }
        public Employe Employe { get; set; }
        public string Intitule { get; set; }
        public DateTime Date { get; set; }
    }
}
