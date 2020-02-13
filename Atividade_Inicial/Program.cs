using System;

namespace Atividade_Inicial
{
    class Program
    {
        static void Main(string[] args)
        {

            Calcular calcular = new Calcular();

            Console.Write("Valor Inicial: ");
            calcular.valorInicial = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de Parcelas: ");
            calcular.qtdParcelas = int.Parse(Console.ReadLine());

            Console.Write(calcular.CalcularParcelas());

            Console.ReadKey();

        }
        
    }
   
}
