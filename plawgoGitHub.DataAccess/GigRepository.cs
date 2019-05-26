using plawgoGitHub.Logic.Repositories;
using plawgoGitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plawgoGitHub.DataAccess
{
    public class GigRepository : Repository<Gig>, IGigRepository
    {
        public GigRepository(DataContext db) : 
            base(db)
        {
        }
    }
}
