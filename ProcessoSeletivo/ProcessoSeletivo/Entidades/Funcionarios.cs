using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessoSeletivo.Entidades
{
    internal class Funcionarios
    {
        public double Salario { get; set; }

        public Funcionarios( double salario)
        {
            Salario = salario;
        }
        public double ReajusteSalario()
        {
            double aumento=0;
            if(Salario <= 280.00)
            {
                aumento += (Salario * 0.2) + Salario;
            }
            else if(Salario >= 280.00 && Salario <= 700.00 )
            {
                aumento += (Salario * 0.15) + Salario;
            }
            else if(Salario >=700.00 && Salario <=1500.00)
            {
                aumento += (Salario * 0.1) +Salario;
            }
            else
            {
                aumento += (Salario * 0.05) + Salario;
            }
            return aumento;
        }
        public double ValorAumento()
        {
            double aumento = 0;
           
               aumento = ReajusteSalario() - Salario;
            return aumento;
        }
        public string PercentualAumento()
        {
            string resposta;
            if (Salario <= 280.00)
            {
                resposta = $"Percentual de aumento aplicado: 20%";
            }
            else if (Salario >= 280.00 && Salario <= 700.00)
            {
                resposta= $"Percentual de aumento aplicado: 15%";
            }
            else if (Salario >= 700.00 && Salario <= 1500.00)
            {
                resposta = $"Percentual de aumento aplicado: 10%";
            }
            else
            {
                resposta = $"Percentual de aumento aplicado: 5%";
            }
            return resposta;
        }
        public override string ToString()
        {
            return "Salario Antes do reajuste: " 
                + Salario.ToString("F2", CultureInfo.InvariantCulture)
                + "\n" 
                + PercentualAumento()
                +"\nValor do aumento: "+ValorAumento().ToString("F2", CultureInfo.InvariantCulture)
                + "\nSalario após reajuste: "+ReajusteSalario().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
