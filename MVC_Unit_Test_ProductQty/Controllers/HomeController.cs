using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Unit_Test_ProductQty.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Unit_Test_ProductQty.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
       
        
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.result = "";
            return View();
        }

        [HttpPost]
        public IActionResult Index(string txtQty)
        {                 
            //CheckQuantity
            if(CheckQuantity(Convert.ToInt32(txtQty)))
            {
                ViewBag.result = "<span style = 'color:green'> Quantity valid. </span>";
            }
            else
            {
                ViewBag.result = "<span style = 'color:red'>Quantity does not valid.</span>";
            }
            return View();
        }

        public bool CheckQuantity(int qty)
        {
            return (qty >= 0 ? true : false);
        }


    }
}
