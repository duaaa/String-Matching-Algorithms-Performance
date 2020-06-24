using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestKMP.Models;
using TestKMP.Models.Utils;
using System.Threading;
using System.IO;
using System.Text;
using System.Web.Configuration;
using System.Configuration;

namespace TestKMP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search(TestKMP.Models.SearchInfo model)
        {
            // Initialize the dataset
            DataSet d = new DataSet();
      
            string filename = AppDomain.CurrentDomain.BaseDirectory + "Models\\DataSets\\" + ConfigurationManager.AppSettings["DataSetFile"];

            string text = d.textData(filename);
            // Get search pattern from the input from model
            string pat = model.SearchText;
            Performance result = new Performance();

            // Perform Search through KMP Algorithm
            if (model.Algorithm == 1)
            {
                result = new Models.Utils.KMP().Search(pat, text);
            }
            // Perform Search through BM Algorithm
            if (model.Algorithm == 2)
            {
                result = new Models.Utils.BM().Search(pat, text);
            }
            // Perform Search through Naive Algorithm
            if (model.Algorithm == 3)
            {
                result = new Models.Utils.Naive().Search(pat, text);
            }

            result.SearchTerm = model;
            return View("Index", result);
        }
       
    }
}