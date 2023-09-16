namespace FormProgramCamadas.Code.DTO
{
    internal class ClienteDTO
    {
        private int id;
        private DateTime dataNascimento; 
        private string cpf;
        private string nome;
        private string email;

        //encapsulamento
        public int Id { get => id; set => id = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; } 
        public string CPF { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
    }
}
