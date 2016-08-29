using App.BLL;
using App.Banxico;
using System;
using System.Diagnostics;
using System.Web.Mvc;

namespace App.Controllers
{
    public class CurrencyConvertorController : AsyncController
    {
        #region Instances
        /// <summary>
        /// Currency Service  Declaration
        /// </summary>
        CurrencyService _currency;
        /// <summary>
        /// Currency Business Object declaration
        /// </summary>
        CurrencyBusiness _currencyBll;
        /// <summary>
        /// StopWatch declaration
        /// </summary>
        Stopwatch _stopWatch;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes instances
        /// </summary>
        public CurrencyConvertorController()
        {
             _stopWatch = new Stopwatch();
             
             _currencyBll = new CurrencyBusiness();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Brings an array from bussines and asigns it to an object
        /// Sends it to the view
        /// </summary>
        /// <returns>Returns a currency object</returns>
        public ActionResult Index()
        {
            _stopWatch.Start();
            CurrencyService _currency = new CurrencyService();
            _currency = _currencyBll.getCurrency();
            _stopWatch.Stop();
            TimeSpan timeSpan = _stopWatch.Elapsed;
            ViewBag.timeSpan = timeSpan;

            return View(_currency);
        }
        #endregion
    }
}