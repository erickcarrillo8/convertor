using App.BLL;
using App.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace App.Controllers
{
    public class CurrencyConvertorController : AsyncController
    {
        private CurrencyBusiness currency_Bll;
        


        // GET: CurrencyConvertor
        public ActionResult Index()
        {
            string[] currency_array = new string[1];
            CurrencyViewModel currency = new CurrencyViewModel();
            currency_Bll = new CurrencyBusiness();

            currency_array = currency_Bll.getCurrency();
            currency.value = Convert.ToSingle(currency_array[0]);
            currency.date = currency_array[1];

            return View(currency);
        }

         

    }
}