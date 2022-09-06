namespace ER2.Classes
{
    //classe PessoaJuridica herdando Pessoa
    public class PessoaJuridica : Pessoa
    {
        //atributos da classe PessoaJuridica
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }
    }
}