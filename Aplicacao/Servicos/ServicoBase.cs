using FluentValidation.Results;
using System;
using System.Linq;

namespace Aplicacao.Servicos
{
    public class ServicoBase
    {
        protected string MensagemFalha { get; set; } = string.Empty;
        public ValidationResult resultadoValidacao = new ValidationResult();

        public void LancarExcecaoValidacao()
        {
            string mensagensValidacao = string.Empty;
            if (!resultadoValidacao.IsValid)
            {
                resultadoValidacao
                    .Errors
                    .Select(x => mensagensValidacao += $"{x.ErrorMessage}\r\n").ToList();
                throw new Exception($"Falhas de validação:\r\n{mensagensValidacao}");
            }
        }

        public string ObterMensagemFalha()
        {
            string mensagem = MensagemFalha; MensagemFalha = string.Empty;
            return mensagem;
        }
    }
}
