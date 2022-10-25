using System.Text.RegularExpressions;
using ER4.Interfaces;

namespace ER4.Classes
{
        public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string Cpf { get; set; } 
        public DateTime DataNasc { get; set; }
        public string DataNascimento { get; set; }
        public string CaminhoPF { get; private set; } = "Database/PessoaFisica.csv";

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
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - datanasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }
            return false;

        }

            public bool ValidarDataNasc(string datanasc)
                    {
                        DateTime dataConvertida;

                        //condicao de verificacao se a string pode ser convertida em DateTime, verificar se esta em um formato valido
                        //DateTime.TryParse tenta converter a data passada em string para DateTime e coloca na saida (out)

                        if (DateTime.TryParse(datanasc, out dataConvertida))
                        {
                            DateTime dataAtual = DateTime.Today;

                            double anos = (dataAtual - dataConvertida).TotalDays / 365;

                            if (anos >= 18)
                            {
                                return true;
                            }
                            return false;
                        }
                        return false;
        }

        public void Inserir(PessoaFisica novaPF)
        {
            Utils.VerificarPastaArquivo(CaminhoPF);

            string[] pfStrings = {$"{novaPF.Nome}, {novaPF.Cpf}, {novaPF.DataNascimento}"};

            File.AppendAllLines(CaminhoPF, pfStrings);
        }

        public List<PessoaFisica> LerArqPF()
        {
            List<PessoaFisica> listaPF = new List<PessoaFisica>();

            string[] linhas = File.ReadAllLines(CaminhoPF);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaFisica cadaPF = new PessoaFisica();

                cadaPF.Nome = atributos[0];
                cadaPF.Cpf = atributos[1];
                cadaPF.DataNascimento = atributos[2];

                listaPF.Add(cadaPF);
            }
            return listaPF;
        }
    }
}