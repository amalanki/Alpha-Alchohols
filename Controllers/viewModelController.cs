using Alpha_Alchohols.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Alpha_Alchohols.Models
{
    public class viewModelController : Controller
    {
        public static LiquorContext context = new LiquorContext();

        // GET: viewModel
        public ActionResult Index()
        {
            var liquorVM = new viewModel();
            return View(liquorVM);
        }
    }
}