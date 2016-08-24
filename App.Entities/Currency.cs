namespace App.Entities
{
    /// <summary>
    /// This class defines de Currency Date and Value 
    /// </summary>
    class Currency
    {
        #region Properties
        /// <summary>
        /// Date of currency value, individually
        /// </summary>
        public string date { get; set; }
        /// <summary>
        /// Currency value in pesos
        /// </summary>
        public float value { get; set; }
        #endregion

    }
}