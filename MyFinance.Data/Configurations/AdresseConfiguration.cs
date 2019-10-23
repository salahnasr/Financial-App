using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain;

namespace MyFinance.Data
{
    public class AdresseConfiguration:ComplexTypeConfiguration<Adresse>
    {
        public AdresseConfiguration()
        {
            Property(p => p.City).IsRequired();
            Property(p => p.StreetAddress).IsOptional().HasMaxLength(50);
        }
    }
}
