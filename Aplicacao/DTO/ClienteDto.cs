﻿namespace Aplicacao.DTO
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
