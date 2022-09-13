namespace ER2.Interfaces
{
    public interface IPessoaJuridica
    {
        /// <summary>
        /// metodo para validar o cnpj
        /// </summary>
        /// <param name="cnpj">cnpj para validar</param>
        /// <returns>validacao do cnpj</returns>
        bool ValidarCnpj(string cnpj);
    }
}