//sempre quando temos uma interface no c#, pra indentificar que e uma interface, comecamos com o I maiusculo, para representar que é uma interface

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









//atributo : letra inicial maiuscula
//classe : letras iniciais maiusculas
//interfaces : primeira letra I + nome da classe letras com letra maiuscula ex: IPessoa
//metodo : iniciais com letras maiusculas e parametros(argumento) com minusculas