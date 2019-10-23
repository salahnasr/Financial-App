using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public ICollection<Product> ListProduct { get; set; }
    }
}
