namespace ER4.Interfaces
{
    public interface IPessoaFisica
    {
        /// <summary>
        /// metodo para validar a data de nascimento
        /// </summary>
        /// <param name="datanasc">data de nascimento para validar</param>
        /// <returns>a validacao da data de nascimento</returns>
        bool ValidarDataNasc(DateTime datanasc);

        // bool ValidarCpf(string cpf);
    } 
}