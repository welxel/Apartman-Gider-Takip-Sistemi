using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETSWebApp.DataAccess;
using ETSWebApp.Models;
using ETSWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ETSWebApp.Controllers
{
    public class HomeController : Controller
    {
        IOperation operation;
        OdemeService odemeService ;

        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult Listeleme()
        {
            operation = new FileOperation();
            odemeService = new OdemeService(operation);

            List<OdemeModel> odemeModels = new List<OdemeModel>();
            odemeModels = odemeService.GetList();
            ViewData["Odeme"] = odemeModels;
            return View();
        }
        [HttpGet]
        public IActionResult Odeme()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Odeme(OdemeModel model)
        {
            operation = new FileOperation();
            odemeService = new OdemeService(operation);
    
            odemeService.AddList(model);


            return View();
        }
    }
}
