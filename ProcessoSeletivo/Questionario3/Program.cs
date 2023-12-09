
using System.Globalization;

namespace Questionario3
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int[] salarios = { 110, 220, 330, 440, 550, 660, 770, 880, 990, 1010, 1020 };
                int[] contagemDeFaixaSalarial = new int[9];

                for (int i = 0; i < salarios.Length; i++)
                {
                    int indice = salarios[i] / 100 - 2;
                    Console.WriteLine($"Índice: {indice}");
                    if (indice >= 0 && indice < contagemDeFaixaSalarial.Length)
                    {
                        contagemDeFaixaSalarial[indice]++;
                    }
                }

                Console.WriteLine("\nContagem de Faixa Salarial:");
                for (int i = 0; i < contagemDeFaixaSalarial.Length; i++)
                {
                    Console.WriteLine($"Faixa {i + 1}: {contagemDeFaixaSalarial[i]} trabalhadores");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
   
        }

    }
}