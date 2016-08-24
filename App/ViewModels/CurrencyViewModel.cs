namespace App.ViewModels
{
    /// <summary>
    /// View model that returns a Currency Date and Value
    /// </summary>
    public class CurrencyViewModel
    {
        #region Properties
        /// <summary>
        /// Date of currency value, individually
        /// </summary>
        public string date { get; set;  }
        /// <summary>
        /// Currency value in pesos
        /// </summary>
        public float value { get; set;  }
        #endregion

    }
}