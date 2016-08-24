using App.BLL;
using App.ViewModels;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace App.Controllers
{
    public class CurrencyConvertorController : AsyncController
    {
        #region Instances
        /// <summary>
        /// View Currency View Model Declaration
        /// </summary>
        CurrencyViewModel currency;
        /// <summary>
        /// Currency Business Object declaration
        /// </summary>
        CurrencyBusiness currency_Bll;
        /// <summary>
        /// StopWatch declaration
        /// </summary>
        Stopwatch stopWatch;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes instances
        /// </summary>
        public CurrencyConvertorController()
        {
             stopWatch = new Stopwatch();
             currency = new CurrencyViewModel();
             currency_Bll = new CurrencyBusiness();
        }
        #endregion
        
        // GET: CurrencyConvertor
        public ActionResult Index()
        {

            stopWatch.Start();
            string[] currency_array = new string[1];
            CurrencyViewModel currency = new CurrencyViewModel();
            currency_Bll = new CurrencyBusiness();

            currency_array = currency_Bll.getCurrency();
            currency.value = Convert.ToSingle(currency_array[0]);
            currency.date = currency_array[1];
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            ViewBag.ts = ts;

            return View(currency);
        }
    }
}