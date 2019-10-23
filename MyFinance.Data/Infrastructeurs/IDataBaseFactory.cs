using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructeurs
{
    public interface IDataBaseFactory
    {
        MyFinanceContext DBcontext {get; }
    }
}
