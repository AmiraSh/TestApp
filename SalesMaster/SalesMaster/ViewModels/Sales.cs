namespace SalesMaster.ViewModels
{
    #region Using
    using System.Collections.Generic;
    #endregion Using

    public class Sales
    {
        public List<Sale> Items { get; set; }
        public string BaseUrl { get; set; }
    }
}
