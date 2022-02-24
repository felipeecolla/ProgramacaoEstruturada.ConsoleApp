using System;

namespace ProgramacaoEstruturada.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            ObterValores(vetor);


            ObterMaiorValor(vetor);


            ObterMenorValor(vetor);


            ObterMedia(vetor);

            ObterTresMaioresValores(vetor);

            ObterValorNegativo(vetor);

            ValorAleatorio(vetor);

            ValoresNaSequencia(vetor);
            Console.ReadKey();
        }

        private static void ValoresNaSequencia(int[] vetor)
        {
            Console.WriteLine("Os valores na sequência são:" + vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4] + vetor[5] +
             vetor[6] + vetor[7] + vetor[8] + vetor[9]);

        } //não ta aparecendo no programa

        private static void ValorAleatorio(int[] vetor)
        {
            int ValorAleatorio = vetor[10];
            for (int i = 0; i < vetor.Length; i++)
                if (ValorAleatorio > -100000 && ValorAleatorio < 100000)
                    Console.WriteLine("O valor aleatório é:" + ValorAleatorio);
        } //não ta aparecendo no programa

        private static void ObterTresMaioresValores(int[] vetor)
        {
            Array.Sort(vetor);

            Console.WriteLine("Os três maiores valores são: " + vetor[7] + "," + vetor[8] + "," + vetor[9] + ".");
            Console.ReadKey();
        }

        private static void ObterMedia(int[] vetor)
        {
            decimal total = 0;

            for (int i = 0; i < 10; i++)
                total = total + vetor[i];
            decimal media = total / 10;

            Console.WriteLine("A média é: " + media);
        }

        private static void ObterMenorValor(int[] vetor)
        {
            int MenorValor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < MenorValor)
                {
                    MenorValor = vetor[i];
                }

            }
            Console.WriteLine("O menor valor é: " + MenorValor);
        }

        private static void ObterMaiorValor(int[] vetor)
        {
            int MaiorValor = vetor[0];
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > MaiorValor)
                {
                    MaiorValor = vetor[i];
                }

            }
            Console.WriteLine("O maior valor é: " + MaiorValor);
        }

        private static void ObterValores(int[] vetor)   
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("insira um valor:");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

            }
        }

        private static void ObterValorNegativo(int[] vetor)
        {        
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                    Console.WriteLine("Números negativos: " + vetor[i]);
            }
        } //não ta aparecendo no programa
    }
}
