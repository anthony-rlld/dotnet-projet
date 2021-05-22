using ClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Mapping
{
    class OffreMapping : EntityTypeConfiguration<Offre>
    {
        public OffreMapping()
        {
            ToTable("APP_OFFRE");
            HasKey(o => o.Id);

            Property(o => o.Id).HasColumnName("OFF_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(o => o.Intitule).HasColumnName("OFF_INTITULE").IsRequired().HasMaxLength(255);
            Property(o => o.Date).HasColumnName("OFF_DATE").IsRequired();
            Property(o => o.Salaire).HasColumnName("OFF_SALAIRE").IsRequired();
            Property(o => o.Description).HasColumnName("OFF_DESCRIPTION");
            Property(o => o.StatutId).HasColumnName("STA_ID").IsRequired();
            Property(o => o.Responsable).HasColumnName("OFF_RESPONSABLE").IsRequired().HasMaxLength(255);

            HasMany(o => o.Postulations).WithRequired(p => p.Offre).HasForeignKey(p => p.OffreId);
        }
    }
}
