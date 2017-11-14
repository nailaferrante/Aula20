namespace ClasseInterface
{
    public class PF : Cliente, IAcao // estamos herdando "cliente" da classe pai e IAcao é a interface.
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public PF()
        {
            
        }
        public PF(int id, string nome, string cpf, string email, string telefone, Endereco endereco)
        {
            this.Id = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.End = endereco;
        }
        public string Cadastro()
        {
            string composicao = "Id do Cliente: "+Id+
                                "\nNome do Cliente: "+Nome+
                                "\nEndereço: "+End.Logradouro+" , "+End.Numero+" , "+End.Bairro+
                                "\ntelefone: "+Telefone+
                                "\nCPF: "+CPF+
                                "\nE-mail: "+Email;
            return "Dados do cliente\n\n"+composicao;

        }

        public string Consulta()
        {
            throw new System.NotImplementedException();
        }
    }
}