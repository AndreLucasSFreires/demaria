using System;
using System.Collections.Generic;

namespace Aplicacao.DTO
{
    public class VendaDto
    {
        public int Id { get; set; }
        public ClienteDto Cliente { get; set; }

        public string NomeCliente
        {
            get {return Cliente.Nome; }
        }

        public DateTime DataEmissao { get; set; }
        public double Valor { get; set; }
        public List<ItemVendaDto> ItensVenda { get; set; } = new List<ItemVendaDto>();
    }
}
