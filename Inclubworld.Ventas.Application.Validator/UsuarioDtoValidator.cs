using FluentValidation;
using Inclubworld.Ventas.Application.DTO;

namespace Inclubworld.Ventas.Application.Validator
{
    public class UsuarioDtoValidator : AbstractValidator<UsuarioDto>
    {
        public UsuarioDtoValidator()
        {
            RuleFor(z => z.user_name).NotNull().NotEmpty();
            RuleFor(z => z.user_pass).NotNull().NotEmpty();
        }
    }
}
