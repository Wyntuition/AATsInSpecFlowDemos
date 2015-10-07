using Demo.Simple.AAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VendingMachine.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IRegister register;
        
        public HomeController(IRegister register)
        {
            this.register = register; 
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayConsole()
        {
            return View(register.Payment);
        }

        public ActionResult InsertCoin()
        {
            register.InsertCoin();

            return View(register.Payment);
        }

        public ActionResult BuyProduct()
        {
            throw new NotImplementedException();
        }

        public HomeController()
        {
        }
    }
}
