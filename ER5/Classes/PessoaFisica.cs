using System.Text.RegularExpressions;
using ER4.Interfaces;

namespace ER4.Classes
{
    //classe PessoaFisica herdando Pessoa
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        //atributos da classe PessoaFisica
        public string? Cpf { get; set; } 
        public DateTime DataNasc { get; set; }
        public string? DataNascimento { get; set; }

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
            //DateTime.Today faz com que pegue a data atual //DateTime.Now pega data e hora
            DateTime dataAtual = DateTime.Today;

            //Total.Days converte para dias
            double anos = (dataAtual - datanasc).TotalDays / 365;

            //condicional para verificacao da idade
            if (anos >= 18)
            {
                return true;
            }
            // nao precisamos do else, pq caso seja true o primeiro return é true, caso contrario, false
            return false;
            
        }
        public bool ValidarDataNasc(string datanascimento)
        {
            if (Regex.IsMatch(datanascimento, @"(^(\d{2}/\d{2}/\d{4})|(\d{8})$)"))
            {
                if (datanascimento.Length == 10)
                {
                    if (datanascimento.Substring(6, 4) == "2002")
                    {
                        return true;
                    }
                }
                else if (datanascimento.Length == 8)
                {
                    if (datanascimento.Substring(4, 4) == "2002")
                    {
                        return true; 
                    }
                }
            }
            return false;
        }
    }
}


 // public bool ValidarDataNasc(DateTime datanasc)
        // {   
        //     //DateTime.Today faz com que pegue a data atual //DateTime.Now pega data e hora
        //     DateTime dataAtual = DateTime.Today;

        //     //Total.Days converte para dias
        //     double anos = (dataAtual - datanasc).TotalDays / 365;

        //     //condicional para verificacao da idade
        //     if (anos >= 18)
        //     {
        //         return true;
        //     }
        //     // nao precisamos do else, pq caso seja true o primeiro return é true, caso contrario, false
        //     return false;
            
        // }

//  public bool ValidarDataNasc(string datanasc)
//         {
//             DateTime dataConvertida;

//             //condicao de verificacao se a string pode ser convertida em DateTime, verificar se esta em um formato valido
//             //DateTime.TryParse tenta converter a data passada em string para DateTime e coloca na saida (out)
            
//             if (DateTime.TryParse(datanasc, out dataConvertida))
//             {
//                 DateTime dataAtual = DateTime.Today;

//                 double anos = (dataAtual - dataConvertida).TotalDays / 365;

//                 if (anos >= 18)
//                 {
//                     return true;
//                 }
//                 return false;
//             }
//             return false;
//         }