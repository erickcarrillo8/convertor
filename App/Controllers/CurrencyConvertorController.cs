﻿using App.BLL;
using App.ViewModels;
using System;
using System.Diagnostics;
using System.Web.Mvc;
using System.Xml;


namespace App.Controllers
{
    /// <summary>
    /// Controller class that interacs with Business and View
    /// </summary>
    public class CurrencyConvertorController : Controller
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

        #region Methods
        /// <summary>
        /// Invoques a methods from Business layers and brings
        /// </summary>
        /// <returns>a Value and a Date</returns>
        public ActionResult Index()
        {
            stopWatch.Start();
            XmlNodeList nodes = currency_Bll.getCurrency();
            
            foreach (XmlElement node in nodes)
            {
                currency.value = Convert.ToSingle(node.GetAttribute("OBS_VALUE"));
                currency.date = node.GetAttribute("TIME_PERIOD");
            }
            stopWatch.Stop();

            return View(currency);
        }
        #endregion
    }
}