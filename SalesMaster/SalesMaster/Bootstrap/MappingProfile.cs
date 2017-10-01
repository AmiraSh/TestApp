namespace SalesMaster.Bootstrap
{
    #region Using
    using AutoMapper;
    #endregion Using

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Entities.Sale, ViewModels.Sale>();
        }
    }
}
