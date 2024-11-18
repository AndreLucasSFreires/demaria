using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.DTO.Clientes
{
    public class ValidacaoClienteDto : AbstractValidator<ClienteDto>
    {
        public ValidacaoClienteDto()
        {
            RuleFor(dto => dto.Nome).NotEmpty().WithMessage("O nome do cliente deve ser fornecido");
        }
    }
}
