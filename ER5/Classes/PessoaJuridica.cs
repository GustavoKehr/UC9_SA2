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
        
        //05.743.368/0001-63 = 18 c @"^\d{2}.\d{3}.\d{3}/\d{4}-\d{2}$"
        //05743368000163 = 14 c
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
    }
}




