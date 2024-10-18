﻿namespace SysTINSClass
{
    public class Class1
    {
       public int Id { get; set; }
        /// XML Docs
        /// <summary>
        /// Calcula o valor das parcelas pela divisão do montante pelo Número de Parcelas
        /// respeitando as RNs 25 e 26.
        /// </summary>
        /// <param name="valor">montante a ser parecelado</param>
        /// <param name="nparc">o número de parcelas (de acordo a RN25)</param>
        /// <returns>O valor de cada parcela(de acordo com a RN26)</returns>
        public double Calcular(double valor, int nparc)
        {
            return valor / nparc;
        }
    }
}
