namespace Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Cliente() { }

        public Cliente(string nome, string telefone, string endereco, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
        }
    }
}
