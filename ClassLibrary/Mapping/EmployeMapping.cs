using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ClassLibrary.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary.Mapping
{
    public class EmployeMapping : EntityTypeConfiguration<Employe>
    {
        public EmployeMapping()
        {
            ToTable("APP_EMPLOYE");
            HasKey(e => e.Id);

            Property(e => e.Id).HasColumnName("EMP_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).HasColumnName("EMP_NOM").IsRequired().HasMaxLength(50);
            Property(e => e.Prenom).HasColumnName("EMP_PRENOM").IsRequired().HasMaxLength(50);
            Property(e => e.DateNaissance).HasColumnName("EMP_DATENAISSANCE").IsRequired();
            Property(e => e.Anciennete).HasColumnName("EMP_ANCIENNETE").IsRequired();
            Property(e => e.Biographie).HasColumnName("EMP_BIOGRAPHIE").HasMaxLength(255);

            HasMany(e => e.Postulations).WithRequired(p => p.Employe).HasForeignKey(p => p.EmployeId);
            HasMany(e => e.Experiences).WithRequired(exp => exp.Employe).HasForeignKey(exp => exp.EmployeId);
            HasMany(e => e.Formations).WithRequired(f => f.Employe).HasForeignKey(f => f.EmployeId);
        }
    }
}
