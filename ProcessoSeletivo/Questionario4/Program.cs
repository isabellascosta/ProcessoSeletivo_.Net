using Questionario4.Entidades;

namespace Questionario4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Escolha o seu produto: ");
                string nome = Console.ReadLine();
                Console.Write("Escolha a quantia: ");
                double quantidade = double.Parse(Console.ReadLine());
                Console.WriteLine("Metodo de pagamento: ");
                string pagamento = Console.ReadLine();
                Venda venda = new Venda(nome, quantidade, pagamento);

                Console.WriteLine("------------");
                Console.WriteLine("Nota fiscal");
                Console.WriteLine(venda);
                Console.WriteLine("------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 

            }
            


        }
    }
}