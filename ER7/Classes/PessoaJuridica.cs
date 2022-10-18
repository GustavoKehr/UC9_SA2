using System.Text.RegularExpressions;
using ER4.Interfaces;

namespace ER4.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
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
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;            
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }
                    
                }
            }
            return false;    
        }

        public bool ValidarDataNascJ(DateTime datanascpj)
        {   
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - datanascpj).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            return false;
            
        }
    }
}





