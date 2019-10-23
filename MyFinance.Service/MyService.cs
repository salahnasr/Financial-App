using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFinance.Domain.Entities;
using MyFinance.Data;
using MyFinance.Data.Infrastructeurs;
using Service.Patern;

namespace MyFinance.Service
{
    public class MyService : MyServiceGeneric<Product> , IMyService
    {
    
        private static IDataBaseFactory dbfac = new DataBaseFactory();

        private static IUnitOfWork utw = new UnitOfWork(dbfac);

        public MyService(): base(utw)
        {

        }

        public IEnumerable<Product> getProductsByCategory(string categoryName)
        {
            return utw.getRepository<Product>().GetMany(x => x.MyCategory.Name == categoryName);
        }
       
    }
}
