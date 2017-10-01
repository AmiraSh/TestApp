namespace SalesMaster.Controllers
{
    #region Using
    using Microsoft.AspNetCore.Mvc;
    using SalesMaster.DomainModel.Interfaces;
    using SalesMaster.ViewModels;
    #endregion Using

    [Route("api/[controller]")]
    public class SalesController : Controller
    {
        private readonly ISalesDomainModel _domainModel;
        
        public SalesController(ISalesDomainModel domainModel)
        {
            _domainModel = domainModel;
        }
        
        [HttpGet]
        public Sales Get()
        {
            return _domainModel.GetAll();
        }
    }
}
