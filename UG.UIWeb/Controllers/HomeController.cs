using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UG.Bll.Repository;
using UG.Bll.Repository.Service;
using UG.DAL.Entities;
using UG.UIWeb.Models;

namespace UG.UIWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IRepository<Customer> RepoCustomer;
        public HomeController(ILogger<HomeController> logger, IRepository<Customer> webRepository)
        {
            _logger = logger;
            RepoCustomer = webRepository;
        }

        public IActionResult Index()
        {
            var Model = RepoCustomer.GetAll().Include(P => P.CustomerInvoices).ToList();
            foreach (var item in Model)
            {

                var BestQuantity = item.CustomerInvoices.OrderByDescending(p => p.FATURA_TUTARI).FirstOrDefault();
                item.CustomerInvoices.Clear();
                item.CustomerInvoices.Add(BestQuantity);
            }
            return View(Model);
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
