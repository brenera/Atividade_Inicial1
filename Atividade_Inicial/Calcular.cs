using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_Inicial
{
     public class Calcular
    {
        public double valorInicial;
        public int qtdParcelas;

        public double CalcularParcelas()
        {
            double resultado = valorInicial / qtdParcelas;

            if(qtdParcelas>= 5)
            {
                resultado = resultado + resultado * 1 / 100;
            }

            return (resultado);
        }
       
    }
}
