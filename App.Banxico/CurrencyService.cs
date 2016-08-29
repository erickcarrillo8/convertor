using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Banxico
{
    public class CurrencyService
    {
        #region Properties
        /// <summary>
        /// Date of currency value, individually
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// Currency value in pesos
        /// </summary>
        public float Value { get; set; }
        #endregion
    }
}
