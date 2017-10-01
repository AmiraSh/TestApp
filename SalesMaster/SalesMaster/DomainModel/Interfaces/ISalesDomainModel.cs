namespace SalesMaster.DomainModel.Interfaces
{
    #region Using
    using System.Collections.Generic;
    using SalesMaster.ViewModels;
    #endregion Using

    public interface ISalesDomainModel
    {
        Sales GetAll();
    }
}
