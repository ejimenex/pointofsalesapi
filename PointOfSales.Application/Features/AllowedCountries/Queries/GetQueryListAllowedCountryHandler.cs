namespace PointOfSales.Application.Features.AllowedCountries.Queries
{
    public class GetQueryListAllowedCountryHandler : IRequestHandler<GetAllowedCountryQuery, List<AllowedCountryVm>>
    {
        private readonly IAsyncRepository<InternalParamAllowredCountry> countryRepository;
        private readonly IMapper mapper;
        public GetQueryListAllowedCountryHandler(IAsyncRepository<InternalParamAllowredCountry> countryRepository, IMapper mapper)
        {
            this.countryRepository = countryRepository;
            this.mapper = mapper;
        }

        public async Task<List<AllowedCountryVm>> Handle(GetAllowedCountryQuery request, CancellationToken cancellationToken)
        {
            var result = await countryRepository.ListAllAsync();
            var countries = mapper.Map<List<AllowedCountryVm>>(result);
            return countries;
        }
    }
}
