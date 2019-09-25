using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plawgoGitHub.Logic.Repositories;
using System.Data.Entity;

namespace plawgoGitHub.DataAccess
{
    public class UnitOfWork : IUnitOfWork

    {


        private readonly DataContext _context;

        public IGigRepository Gigs { get; private set; }
       

        public UnitOfWork(DataContext context)
        {
            _context = context;
            _context.Database.BeginTransaction();
            Gigs = new GigRepository(_context);
           

        }

        public void Complete()
        {

            _context.SaveChanges();
            _context.Database.CurrentTransaction.Commit();
        }



        

     
    }
}
