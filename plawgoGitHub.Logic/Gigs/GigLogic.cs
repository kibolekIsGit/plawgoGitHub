using plawgoGitHub.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plawgoGitHub.Models;
using plawgoGitHub.Logic.Repositories;

namespace plawgoGitHub.Logic.Gigs
{
    public class GigLogic : IGigLogic
    {

        private readonly Lazy<IUnitOfWork> _unitofwork;

        protected IUnitOfWork UnitOfWork
        {
            get
            {
                return _unitofwork.Value;
            }

        }


        public GigLogic(Lazy<IUnitOfWork> unitofwork)
        {
            _unitofwork = unitofwork;
        }



        public void Add(Gig gig)
        {
            UnitOfWork.Gigs.Add(gig);

            UnitOfWork.Complete();
        }



        //private readonly Lazy<IGigRepository> _repository;

        //protected IGigRepository Repository
        //{
        //    get
        //    {
        //        return _repository.Value;
        //    }

        //}


        //public GigLogic(Lazy<IGigRepository> repository)
        //{
        //    _repository = repository;
        //}



        //public void Add(Gig gig)
        //{
        //    Repository.Add(gig);
        //    Repository.SaveChanges();
        //}
    }
}
