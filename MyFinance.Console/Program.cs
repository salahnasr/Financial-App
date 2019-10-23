using MyFinance.Domain.Entities;
using MyFinance.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Begin");

            IMyService service = new MyService();
            Product p = new Product { Name = "kkk",
                                      Price = 1.2,
                                      Description ="test",
                                      DateProd = new DateTime(2016,08,20)};
            service.Add(p);
            service.commit();
            service.Dispose();

            System.Console.WriteLine("End");
        }
    }
}
