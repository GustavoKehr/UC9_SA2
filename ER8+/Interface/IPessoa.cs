namespace ER4.Interfaces
{
    public interface IPessoa
    {   
        /// <summary>
        /// metodo para calcular os pagamentos de impostos
        /// </summary>
        /// <param name="rendimento">rendimento para basear o calculo de imposto</param>
        /// <returns>valor do importo a ser pago</returns>
        float PagarImposto(float rendimento);
    } 
}







