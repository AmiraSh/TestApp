namespace SalesMaster.DomainModel
{
    #region Using
    using AutoMapper;
    using SalesMaster.Data.Repositories.Interfaces;
    using SalesMaster.DomainModel.Interfaces;
    using SalesMaster.ViewModels;
    using System.Collections.Generic;
    using System.Linq;
    #endregion Using

    public class SalesDomainModel : ISalesDomainModel
    {
        private const string BASE_URL = "https://beta.twa.nl/nl";
        private readonly IMapper _mapper;
        private readonly ISalesRepository _salesRepository;

        public SalesDomainModel(IMapper mapper, ISalesRepository salesRepository)
        {
            _mapper = mapper;
            _salesRepository = salesRepository;
        }

        public Sales GetAll()
        {
            var sales = _salesRepository.GetAll().ToList();
            var model = new Sales()
            {
                BaseUrl = BASE_URL,
                Items = _mapper.Map<IEnumerable<Data.Entities.Sale>, IEnumerable<Sale>>(sales).ToList()
            };

            return model;
        }
    }
}
