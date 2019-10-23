using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Domain.Entities
{
    public class Provider
    {
        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password")]
        public String ConfirmPassword { get; set; }
        public DateTime DateCreated { get; set; }
        [EmailAddress]
        [Required]
        public String Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; }
        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public String Password { get; set; }
        public String UserName { get; set; }

        public ICollection<Product> ListProduct { get; set; }


    }
}
