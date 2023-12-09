using Questionario2.Entidades;

namespace Questionario2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Qual o melhor Sistema Operacional para uso em servidores?");
                Console.WriteLine("");
                Console.WriteLine("As possíveis respostas são:");
                Console.WriteLine("1- Windows Server \n2- Unix \n3-Linux \n4- Netware \n5- Mac OS \n6- Outro");

                Votacao votacao = new Votacao();
                while (true)
                {
                    int voto;
                    if (int.TryParse(Console.ReadLine(), out voto))
                    {
                        if (voto == 0)
                        {
                            break;
                        }
                        votacao.AdicionarVoto(voto);
                    }
                    else
                    {
                        Console.WriteLine("Somente adicione números inteiros entre 1 e 6.");
                    }
                }
                votacao.ResultadoFinal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
      

        }
    }
}