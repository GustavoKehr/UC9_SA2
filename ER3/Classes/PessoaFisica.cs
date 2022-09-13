using ER2.Interfaces;

namespace ER2.Classes
{
    //classe PessoaFisica herdando Pessoa
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //atributos da classe PessoaFisica
        public string? Cpf { get; set; } 
        public DateTime DataNasc { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento >= 1501 && rendimento <= 3500)
            {
                return rendimento * 0.02f;
            }
            else if (rendimento >= 3501 && rendimento <= 6000)
            {
                return rendimento * 0.035f;
            }
            else
            {
                return rendimento * 0.05f;
            }
        }


        public bool ValidarDataNasc(DateTime datanasc)
        {
            throw new NotImplementedException();
        }
    }
}
