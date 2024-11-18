using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.DTO
{
    public class ValidacaoVendaDto : AbstractValidator<VendaDto>
    {
        public ValidacaoVendaDto()
        {
            RuleFor(dto => dto.Valor).GreaterThan(0).WithMessage("O valor da venda " +
                "deve ser maior que zero reais ( R$ 0 ) !");
            RuleFor(dto => dto.Cliente).NotNull().WithMessage("O Cliente precisa ser escolhido");
        }
    }
}
