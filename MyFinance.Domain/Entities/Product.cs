using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyFinance.Domain.Entities
{
    public class Product
    {
        [DataType(DataType.DateTime)]
        [Display(Name = "Production Date")]
        public DateTime DateProd { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string Test { get; set; }
        public string BestTest { get; set; }
        public string LastTest { get; set; }

        [Required]
        [MaxLength(50)]
        [StringLength(25, ErrorMessage = "Max 25 !!")]
        [Display]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public int ProductId { get; set; }
        [Range(0,Int32.MaxValue)]
        public int Quantity { get; set; }

       
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category MyCategory { get; set; }
        public virtual ICollection<Provider> ListProvider { get; set; }
    }
}
