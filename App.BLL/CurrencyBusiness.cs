using App.Banxico;
using System;
using System.Diagnostics;
using System.Xml;

namespace App.BLL
{
    /// <summary>
    /// Interacs with entities class and consumes Banxico web service
    /// </summary>
    public class CurrencyBusiness
    {
        #region Instances
        /// <summary>
        /// StopWatch declaration
        /// </summary>
        Stopwatch _stopWatch;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialices instances
        /// </summary>
        public CurrencyBusiness()
        {
             _stopWatch = new Stopwatch();
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method comsumes a Banxico WS brings an XML file and Serializes the File
        /// </summary>
        /// <returns>a node with the currency value</returns>
        public  CurrencyService getCurrency()
        {
            _stopWatch.Start();

            BanxicoService.DgieWSPortClient banxico = new BanxicoService.DgieWSPortClient();
            CurrencyService _currency = new CurrencyService();

            var result = banxico.tiposDeCambioBanxico();
            XmlDocument document = new XmlDocument();
            document.LoadXml(result);

            XmlNodeList dataSet = document.GetElementsByTagName("bm:DataSet");

            XmlNodeList list = ((XmlElement)dataSet[0]).GetElementsByTagName("bm:Series");
            XmlNodeList nodes = ((XmlElement)list[0]).GetElementsByTagName("bm:Obs");
           
            foreach (XmlElement node in nodes)
            {
                _currency.Value = Convert.ToSingle( node.GetAttribute("OBS_VALUE"));
                _currency.Date = node.GetAttribute("TIME_PERIOD");
            }
            _stopWatch.Stop();
            TimeSpan timeSpan = _stopWatch.Elapsed;
            return _currency;
        }                
        #endregion
    }
}
