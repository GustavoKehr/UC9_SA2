namespace ER2.Classes
{
    //classe PessoaFisica herdando Pessoa
    public class PessoaFisica : Pessoa
    {
        //atributos da classe PessoaFisica
        public string? Cpf { get; set; } 
        public DateTime DataNasc { get; set; }
    }
}