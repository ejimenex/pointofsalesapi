using PointOfSales.Application.Features.AllowedCountries.Queries;
using PointOfSales.Application.Features.LanguagePr.Queries.GetAllLanguage;

namespace PointOfSales.Application.Profiles
{
    public class AlloedCountriesProfile : Profile
    {
        public AlloedCountriesProfile()
        {
            CreateMap<InternalParamAllowredCountry, AllowedCountryVm>()
                .ForMember(c => c.Label, opt => opt.MapFrom(c => c.Name))
            .ForMember(c => c.Value, opt => opt.MapFrom(c => c.Id));

            CreateMap<Language, LanguageVm>()
            .ForMember(c => c.Label, opt => opt.MapFrom(c => c.Name))
        .ForMember(c => c.Value, opt => opt.MapFrom(c => c.Id));
        }
    }
}
