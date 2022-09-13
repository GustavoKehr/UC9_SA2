using ER2.Interfaces;

namespace ER2.Classes
{
    //classe PessoaJuridica herdando Pessoa
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        //atributos da classe PessoaJuridica
        public string? Cnpj { get; set; }
        public string? RazaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            if (rendimento <= 3000) 
            {   
                return rendimento * 0.03f;
            }
            else if (rendimento >= 3001 && rendimento <= 6000)
            {
                return rendimento * 0.05f;
            }
            else if (rendimento >= 6001 && rendimento <= 10000)
            {   
                return rendimento * 0.07f;
            }
            else
            {
                return rendimento * 0.09f;
            }
        
        }

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }
    }
}

