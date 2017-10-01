namespace SalesMaster.Data.Repositories.Interfaces
{
    #region Using
    using SalesMaster.Data.Entities;
    using System.Collections.Generic;
    #endregion Using

    public interface ISalesRepository
    {
        IEnumerable<Sale> GetAll();
    }
}
