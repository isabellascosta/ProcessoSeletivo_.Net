using ProcessoSeletivo.Entidades;
using System.Globalization;

namespace ProcessoSeletivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe o salário do colaborador: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionarios funcionario = new Funcionarios(salario);

                Console.WriteLine("");
                Console.WriteLine("informações:");
                Console.WriteLine(funcionario.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
  
        }
    }
}