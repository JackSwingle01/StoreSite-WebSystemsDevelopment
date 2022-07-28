using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStore.Models.ViewModels;
using SportsStore.Models;


namespace SportsStore.Controllers
{
    public class InfoController : Controller
    {
        public ViewResult About(string returnUrl)
        {
            return View(new InfoViewModel
            {
                ReturnUrl = returnUrl
            });
        }
        public ViewResult Contact(string returnUrl)
        {
            return View(new InfoViewModel
            {

                ReturnUrl = returnUrl
            });
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new InfoViewModel
            {
                ReturnUrl = returnUrl
            });
        }
    }

}


