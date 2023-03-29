using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSales.Application.Features.LanguagePr.Queries.GetAllLanguage
{
    public class GetLanguageQueryHandler:IRequestHandler<AllLanguageQuery,List<LanguageVm>>
    {
        private readonly IAsyncRepository<Language> langRepository;
        private readonly  IMapper mapper;
        public GetLanguageQueryHandler(IAsyncRepository<Language> langRepository, IMapper mapper)
        {
            this.langRepository = langRepository;
            this.mapper = mapper;   
        }

        public async Task<List<LanguageVm>> Handle(AllLanguageQuery request, CancellationToken cancellationToken)
        {
            var result = await langRepository.ListAllAsync();
            var languages = mapper.Map<List<LanguageVm>>(result);
            return languages;   
        }
    }
}
