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
        public  XmlNodeList getCurrency()
        {

             

            
            BanxicoService.DgieWSPortClient banxico = new BanxicoService.DgieWSPortClient();

            var result = banxico.tiposDeCambioBanxico();
            XmlDocument document = new XmlDocument();
            document.LoadXml(result);
            Console.Write(result);

            XmlNodeList ser = document.GetElementsByTagName("bm:DataSet");
            XmlNodeList lista = ((XmlElement)ser[0]).GetElementsByTagName("bm:Series");

            XmlNodeList nodes = ((XmlElement)lista[0]).GetElementsByTagName("bm:Obs");

            

            return nodes;
            
            

        }
    }
}
