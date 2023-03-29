using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PointOfSales.Application.Common;

using System.Threading.Tasks;
using PointOfSales.Application.Exceptions;

namespace PointOfSales.Application.Features.Login.Query.GetExistingUser
{
    public class ExistinUserQueryHandler : IRequestHandler<LoginQuery, TokenResult>
    {
        private readonly IAccountRepository accountRepository;
        public ExistinUserQueryHandler(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public async Task<TokenResult> Handle(LoginQuery request, CancellationToken cancellationToken)
        {
            var token = new TokenResult
            {
                Token = null
            };
            var validator = new ExistinUserValidation(this.accountRepository);
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                throw new ValidationException(validationResult);
            }
            var login = await accountRepository.GetAvaliable(request.UserName);
            var pass = EncryptPasswordService.VerifyPassword(request.Password, login.Password);
            if(!pass)
                throw new  BadRequestException("The password you entered is not the correct");
            if (login is not null && pass)
            {
                token.Token = GenerateToken.generateJwtToken(login);
            }
            return token;
        }
    }
}
