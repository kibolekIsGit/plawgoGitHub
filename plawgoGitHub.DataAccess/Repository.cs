using plawgoGitHub.Logic.Repositories;
using plawgoGitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plawgoGitHub.DataAccess
{
    public class Repository<T> : IRepository<T> where T:BaseModel
    {
        protected DataContext Db { get; set; }

        public Repository(DataContext db)
        {
            Db = db;
        }

        public void Add(T model)
        {
            
            Db.Set<T>().Add(model);
        }

        public void Delete(T model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        //public void SaveChanges()
        //{
        //    Db.SaveChanges();
        //}
    }
}
