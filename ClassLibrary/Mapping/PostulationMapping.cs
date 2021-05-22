using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapping
{
    class PostulationMapping : EntityTypeConfiguration<Postulation>
    {
        public PostulationMapping()
        {
            ToTable("APP_POSTULATION");
            HasKey(p => new { p.EmployeId, p.OffreId });

            Property(p => p.EmployeId).HasColumnName("EMP_ID").IsRequired();
            Property(p => p.OffreId).HasColumnName("OFF_ID").IsRequired();
            Property(p => p.Date).HasColumnName("POS_DATE").IsRequired();
            Property(p => p.Statut).HasColumnName("POS_STATUT").IsRequired().HasMaxLength(255);
        }
    }
}
