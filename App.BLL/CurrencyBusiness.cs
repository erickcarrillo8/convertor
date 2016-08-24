using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using App.DAL;

namespace App.BLL
{
   public class CurrencyBusiness
    {
        public  string[] getCurrency()
        {
            BanxicoService.DgieWSPortClient banxico = new BanxicoService.DgieWSPortClient();
            string[] data = new string[2];

            var result = banxico.tiposDeCambioBanxico();
            XmlDocument document = new XmlDocument();
            document.LoadXml(result);
            XmlNodeList ser = document.GetElementsByTagName("bm:DataSet");
            XmlNodeList list = ((XmlElement)ser[0]).GetElementsByTagName("bm:Series");
            XmlNodeList nodes = ((XmlElement)list[0]).GetElementsByTagName("bm:Obs");
           
            foreach (XmlElement node in nodes)
            {
                data[0] = node.GetAttribute("OBS_VALUE");
                data[1] = node.GetAttribute("TIME_PERIOD");
            }

            return data;
        }

    }
}
