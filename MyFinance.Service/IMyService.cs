using MyFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Patern;

namespace MyFinance.Service
{
    public interface IMyService : IMyServiceGeneric<Product>
    {
        
    }
}
