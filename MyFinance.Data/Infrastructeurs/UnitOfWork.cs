﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Data.Infrastructeurs
{
    public class UnitOfWork : IUnitOfWork
    {

        private MyFinanceContext context;
        IDataBaseFactory dbfac;

        public UnitOfWork(IDataBaseFactory dbfac)
        {
            this.dbfac = dbfac;
            context = dbfac.DBcontext;
        }

        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(context);
        }
        public void commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            //liberer l'espace memoire du context
            context.Dispose();
        }
    }
}
