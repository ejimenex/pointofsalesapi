
using System.Linq;
using System.Text;
using PointOfSales.Application.Exceptions;
using System.Threading.Tasks;
using PointOfSales.Application.Common;

namespace PointOfSales.Application.Features.Account.Command.CreateAccountCommand
{
    public class CreateAccountCommandHandler : IRequestHandler<CreateAccountCommand, CreateAccountResponse>

    {
        private readonly IMapper _mapper;
        private readonly IAccountRepository accountRepository;
        public CreateAccountCommandHandler(IMapper mapper, IAccountRepository accountRepository)
        {
            _mapper = mapper;
            this.accountRepository = accountRepository;
        }
        public async Task<CreateAccountResponse> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var createAccountResponse = new CreateAccountResponse();
                var validator = new CreateAccountCommandValidation(this.accountRepository);
                var validationResult = await validator.ValidateAsync(request);
                if (validationResult.Errors.Any())
                {
                    createAccountResponse.Success = false;
                    throw new ValidationException(validationResult);
                }
                if (createAccountResponse.Success)
                {
                    var account = _mapper.Map<UserRegistrered>(request);
                    account.Password = EncryptPasswordService.EncryptPasswordHash(account.Password);
                    account.UserEmail = request.Email;
                    account = await accountRepository.AddAsync(account);
                    createAccountResponse.UserRegistrered = _mapper.Map<CreateAccountDto>(account);

                }
                return createAccountResponse;
            }
            catch (Exception es)
            {

                throw;
            }
         
        }
    }
}
