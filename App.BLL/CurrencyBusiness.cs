using System;
using System.Diagnostics;
using System.Xml;
using System.Threading;


namespace App.BLL
{
    /// <summary>
    /// Interacs with entities class and consumes Banxico web service
    /// </summary>
    public class CurrencyBusiness
    {
        Stopwatch stopWatch = new Stopwatch();
        


        #region Methods
        /// <summary>
        /// This method comsumes a Banxico WS brings an XML file and Serializes the File
        /// </summary>
        /// <returns>a node with the currency value</returns>
        public XmlNodeList getCurrency()
        {
            stopWatch.Start();
            BanxicoService.DgieWSPortClient banxico = new BanxicoService.DgieWSPortClient();

            var result = banxico.tiposDeCambioBanxico();
            XmlDocument document = new XmlDocument();
            document.LoadXml(result);
            Console.Write(result);

            XmlNodeList ser = document.GetElementsByTagName("bm:DataSet");
            XmlNodeList lista = ((XmlElement)ser[0]).GetElementsByTagName("bm:Series");

            XmlNodeList nodes = ((XmlElement)lista[0]).GetElementsByTagName("bm:Obs");
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            return nodes;

        }
        #endregion
    }
}
