namespace SalesMaster.Data.Repositories
{
    #region Using
    using Newtonsoft.Json;
    using SalesMaster.Data.Entities;
    using SalesMaster.Data.Repositories.Interfaces;
    using System.Collections.Generic;
    #endregion Using

    public class SalesRepository : ISalesRepository
    {
        public IEnumerable<Sale> GetAll()
        {
            var jsonData = System.IO.File.ReadAllText(@"..\App_Data\data.json");
            var data = JsonConvert.DeserializeObject<SalesData>(jsonData);

            return data.Results;
        }
    }
}
