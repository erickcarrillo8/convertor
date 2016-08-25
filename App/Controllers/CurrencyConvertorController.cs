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
        CurrencyViewModel _currency;
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
             _currency = new CurrencyViewModel();
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
            string[] currencyArray = new string[1];

            currencyArray = _currencyBll.getCurrency();
            _currency.Value = Convert.ToSingle(currencyArray[0]);
            _currency.Date = currencyArray[1];
            _stopWatch.Stop();
            TimeSpan timeSpan = _stopWatch.Elapsed;

            ViewBag.timeSpan = timeSpan;

            return View(_currency);
        }
        #endregion
    }
}