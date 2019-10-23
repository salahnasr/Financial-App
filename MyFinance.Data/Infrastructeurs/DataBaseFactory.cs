using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructeurs
{
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {
        private MyFinanceContext context;

        public MyFinanceContext DBcontext { get { return context; } }

        public DataBaseFactory()
        {
            this.context = new MyFinanceContext();
        }

        protected override void DisposeCore()
        {
            if(DBcontext != null)
            DBcontext.Dispose();
        }
    }
}
