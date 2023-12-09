using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Questionario4.Entidades
{
    internal class Venda
    {
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public string Pagamento { get; set; }

        public Venda(string nome, double quantidade, string pagamento)
        {
            Nome = nome;
            Quantidade = quantidade;
            Pagamento = pagamento;
                
        }
        public double ValorCompra()
        {
            double total=0;
            if (Nome == "File Duplo" && Quantidade <= 5)
            {
                total = Quantidade * 4.90;
            }
            else if (Nome == "File Duplo" && Quantidade > 5)
            {
                total = Quantidade * 5.80;
            }
            else if (Nome == "Alcatra" && Quantidade <= 5)
            {
                total = Quantidade * 5.90;
            }
            else if (Nome == "Alcatra" && Quantidade > 5)
            {
                total = Quantidade * 6.80;
            }
            else if (Nome == "Picanha" && Quantidade <= 5)
            {
                total = Quantidade * 6.90;
            }
            else if (Nome == "Picanha" && Quantidade > 5)
            {
                total = Quantidade * 7.80;
            }
            return total;
        }
        public double PromocaoCartao()
        {
            double promocao = 0;
            if(Pagamento == "Tabajara")
            {
                promocao = (ValorCompra() - (ValorCompra() * 0.05));
            }
            return promocao;
        }
        public double ValorDesconto()
        {
            return ValorCompra() - PromocaoCartao();
        }

        public override string ToString()
        {
            string resposta;
            if (Pagamento == "Tabajara")
            {
                resposta = "Nome Carne: "
             + Nome
             + "\nPreço Total: "
             + ValorCompra().ToString("f2", CultureInfo.InvariantCulture)
             + "\nTipo de pagamento: "
             + Pagamento
             + "\nValor do Desconto: "
             +ValorDesconto().ToString("f2",CultureInfo.InvariantCulture)
             + "\nValor Total a pagar: "
             +PromocaoCartao().ToString("f2", CultureInfo.InvariantCulture);
            }
            else
            {
                resposta = "Nome Carne: "
             + Nome
             + "\nTipo de pagamento: "
             + Pagamento
             + "\nValor do Desconto: Sem desconto"
             
             + "\nValor Total a pagar: "
             + ValorCompra().ToString("f2",CultureInfo.InvariantCulture);
            }

            return resposta;

        }
    }
}

