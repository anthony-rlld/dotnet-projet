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
    class StatutMapping : EntityTypeConfiguration<Statut>
    {
        public StatutMapping()
        {
            ToTable("APP_STATUT");
            HasKey(s => s.Id);

            Property(s => s.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(255);

            HasMany(s => s.Offres).WithRequired(o => o.Statut).HasForeignKey(o => o.StatutId);
        }
    }
}
