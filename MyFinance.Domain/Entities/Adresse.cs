using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain
{
 

public class Adresse
    {
        public string City { get; set; }
        public string StreetAddress { get; set; }
    }
}
