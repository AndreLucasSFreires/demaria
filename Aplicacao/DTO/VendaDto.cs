using System;

namespace Aplicacao.DTO
{
    public class VendaDto
    {
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public ClienteDto Cliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public double Valor { get; set; }
    }
}
