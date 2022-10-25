using System.Text.RegularExpressions;
using ER4.Interfaces;

namespace ER4.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public static string Caminho { get; private set; } = "Database/PessoaJuridica.csv";


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
        public void Inserir(PessoaJuridica novaPJ)
        {
            Utils.VerificarPastaArquivo(Caminho);

            string[] pjStrings = {$"{novaPJ.Nome}, {novaPJ.Cnpj}, {novaPJ.RazaoSocial}"};

            File.AppendAllLines(Caminho, pjStrings);
        }

        public List<PessoaJuridica> LerArqPJ()
        {
            List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(Caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPJ = new PessoaJuridica();

                cadaPJ.Nome = atributos[0];
                cadaPJ.Cnpj = atributos[1];
                cadaPJ.RazaoSocial = atributos[2];

                listaPJ.Add(cadaPJ);
            }
            return listaPJ;
        }
    }
}






