using PointOfSales.Application.Common;
using PointOfSales.Application.Exceptions;

namespace PointOfSales.Application.Features.Account.Command.ChangePasswordCommand
{
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordAccountCommand, bool>
    {

        private readonly IAccountRepository accountRepository;
        public ChangePasswordCommandHandler(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public async Task<bool> Handle(ChangePasswordAccountCommand request, CancellationToken cancellationToken)
        {
            var validator = new ChangePasswodCommandValidation();
            var validationResult = await validator.ValidateAsync(request);
            if (validationResult.Errors.Any())
            {
                ;
                throw new ValidationException(validationResult);
            }
            var user = await accountRepository.GetByIdAsync(request.UserId);
            var oldPasswordSuccess = EncryptPasswordService.VerifyPassword(request.OldPassword, user.Password);
            if (!oldPasswordSuccess) throw new BadRequestException("The old password is not matching with the current password");
            user.Password = EncryptPasswordService.EncryptPasswordHash(request.NewPassword);
            await accountRepository.UpdateAsync(user);
            return true;
        }
    }
}
