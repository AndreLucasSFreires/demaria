using Aplicacao.DTO;
using AutoMapper;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Mapeamento
{
    public class Mappings
    {
        public static MapperConfiguration ConfigurarAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ItemVenda, ItemVendaDto>()
                    .ForMember(dest => dest.ProdutoDto, map => map.MapFrom(src => src.Produto))
                    .ForMember(dest => dest.Venda, map => map.MapFrom(src => src.Venda));

                cfg.CreateMap<Produto, ProdutoDto>();

                cfg.CreateMap<Venda, VendaDto>()
                    .ForMember(dest => dest.ItensVenda, map => map.Ignore());

                cfg.CreateMap<VendaDto, Venda>()
                    .ForMember(dest => dest.CodigoCliente, map => map.MapFrom(src => src.Cliente.Id))
                    .ForMember(dest => dest.ItensVenda, map => map.MapFrom(src => src.ItensVenda));

                cfg.CreateMap<ItemVendaDto, ItemVenda>()
                .ForMember(dest => dest.Produto, map => map.MapFrom(src => src.ProdutoDto)).
                ForMember(dest => dest.Venda, map => map.MapFrom(src => src.Venda));

                cfg.CreateMap<Cliente, ClienteDto>();
            });
            return config;
        }
    }
}
