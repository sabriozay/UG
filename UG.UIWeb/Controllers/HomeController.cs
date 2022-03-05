using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UG.Bll.Repository;
using UG.Bll.Repository.Service;
using UG.DAL.Entities;
using UG.UIWeb.Models;
using UG.UIWeb.Models.Home;

namespace UG.UIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<Customer> RepoCustomer;
        IDapper _dapper;
        public HomeController(ILogger<HomeController> logger, IRepository<Customer> webRepository, IDapper dapper)
        {
            _logger = logger;
            RepoCustomer = webRepository;
            _dapper = dapper;
        }

        public IActionResult Index()
        {
            IndexVM ındexVM = new IndexVM();
            var Model = RepoCustomer.GetAll().ToList();
            ındexVM.Customers = Model;
            return View(ındexVM);
        }
        [HttpPost]
        public ActionResult Index(int MUSTERI_ID)
        {
            IndexVM ındexVM = new IndexVM();
            var Model = RepoCustomer.GetAll().ToList();
            var parameters = new DynamicParameters();
            parameters.Add("@MUSTERI_ID", MUSTERI_ID, DbType.Int32);
            var Data = _dapper.Get<BestQuantity>("PickQuantity", parameters);
            ındexVM.Customers = Model;
            ındexVM.bestQuantity = Data;

            return View(ındexVM);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
