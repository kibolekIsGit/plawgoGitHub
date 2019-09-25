using plawgoGitHub.DataAccess;
using plawgoGitHub.Logic.Gigs;
using plawgoGitHub.Logic.Interfaces;
using plawgoGitHub.Logic.Repositories;
using plawgoGitHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace plawgoGitHub.Web.Controllers
{
    public class GigsController : Controller
    {
        private Lazy<IGigLogic> _logic;
        // GET: Products
        public GigsController(Lazy<IGigLogic> logic)
        {
            //  _logic = new Lazy<IGigLogic>(() => new GigLogic(unitOfWork));
            _logic = logic;



        }


        //public GigsController()
        //{
        //     DataContext ole = new DataContext();
        //    Lazy<IUnitOfWork> ole2 = new Lazy<IUnitOfWork>(() => new UnitOfWork(ole));
        //    //  Lazy<IGigRepository> ole2 = new Lazy<IGigRepository>(() => new GigRepository(ole));
        //    //Lazy<IGigRepository> ole2 =new GigRepository(ole);

        //    _logic = new Lazy<IGigLogic>(() => new GigLogic(ole2));
        //}
        protected IGigLogic Logic
        {
            get
            {
                return _logic.Value;
            }
        }

        public virtual ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public virtual ActionResult Create(Gig gig)
        {
            Logic.Add(gig);

            //if (ModelState.IsValid == false)
            //{
            //    return View(viewModel);

            //}

            //var product = Mapper.Map<Product>(viewModel);

            //var result = Logic.Add(product);

            //if (result.Success == false)
            //{
            //    result.AddErrors(ModelState);
            //    return View(viewModel);
            //}

            return RedirectToAction("Create");
            //return RedirectToAction(MVC.Products.Index());
        }
    }
}