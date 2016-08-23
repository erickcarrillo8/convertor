using App.BLL;
using App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Web;
using System.Web.Mvc;


namespace App.Controllers
{
    public class CurrencyConvertorController : Controller
    {   
        

        // GET: CurrencyConvertor
        public ActionResult Index()
        {
      
           
            CurrencyViewModel currency = new CurrencyViewModel();
            CurrencyBusiness currency_Bll = new CurrencyBusiness();
            XmlNodeList nodes = currency_Bll.getCurrency();
            
            foreach (XmlElement node in nodes)
            {
                currency.value = Convert.ToSingle(node.GetAttribute("OBS_VALUE"));
                currency.date = node.GetAttribute("TIME_PERIOD");
            }
                        

            return View(currency);
        }
    }
}