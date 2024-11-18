using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.DTO.Produtos
{
    public class ValidacaoProdutoDto : AbstractValidator<ProdutoDto>
    {
        public ValidacaoProdutoDto()
        {
            RuleFor(dto => dto.Preco).GreaterThan(0.05).
                WithMessage("O produto precisa ter o valor mínimo de 5 centavos");
            RuleFor(dto => dto.Estoque).GreaterThan(0).
                WithMessage("O produto precisa ter o estoque mínimo de 1 unidade");
            RuleFor(dto => dto.Nome).NotEmpty()
                .WithMessage("O produto precisa ter um nome");
        }
    }
}
