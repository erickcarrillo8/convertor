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
        /// <summary>
        /// Banxico Service declaration
        /// </summary>
        BanxicoService.DgieWSPortClient _banxico;
        /// <summary>
        /// Currency Service object declaration
        /// </summary>
        CurrencyService _currency;
        #endregion


        #region Constructor
        /// <summary>
        /// Initialices instances
        /// </summary>
        public CurrencyBusiness()
        {
            _stopWatch = new Stopwatch();
            _banxico = new BanxicoService.DgieWSPortClient();
            _currency = new CurrencyService();
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
            string idSerie , idSerieDolar = "SF60653";
            var result = _banxico.tiposDeCambioBanxico();
            XmlDocument document = new XmlDocument();
            document.LoadXml(result);
            XmlNodeList list = document.GetElementsByTagName("bm:Series");
            foreach (XmlElement node in list){
                idSerie = node.Attributes["IDSERIE"].Value;
                if (String.Equals(idSerie, idSerieDolar)){
                    XmlNode currency = node.FirstChild;
                    _currency.Value = Convert.ToSingle(currency.Attributes["OBS_VALUE"].Value);
                    _currency.Date = currency.Attributes["TIME_PERIOD"].Value;
                }
            }
            _stopWatch.Stop();
            TimeSpan timeSpan = _stopWatch.Elapsed;
            return _currency;
        }                
        #endregion
    }
}
