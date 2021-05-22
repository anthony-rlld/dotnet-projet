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
    class FormationMapping : EntityTypeConfiguration<Formation>
    {
        public FormationMapping()
        {
            ToTable("APP_FORMATION");
            HasKey(f => f.Id);

            Property(f => f.Id).HasColumnName("FOR_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(f => f.EmployeId).HasColumnName("EMP_ID").IsRequired();
            Property(f => f.Intitule).HasColumnName("FOR_INTITULE").IsRequired().HasMaxLength(255);
            Property(f => f.Date).HasColumnName("FOR_DATE").IsRequired();
        }
    }
}
