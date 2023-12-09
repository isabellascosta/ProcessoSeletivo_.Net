using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionario2.Entidades
{
    internal class Votacao
    {
        public int[] Votos;
        public string[] Opcoes = { "Windows Server", "Unix", "Linux", "Netware", "Mac OS", "Outro" };
        public double TotVotos;
        public Votacao()
        {
            Votos = new int[6];
            TotVotos = 0;
        }
        public void AdicionarVoto(int voto)
        {
            if(voto >=1 && voto <= 6)
            {
                Votos[voto - 1]++;
                TotVotos++;
            }
            else
            {
                Console.WriteLine("insira um valor valido entre 1 e 6");
            }
        }
        private int OSMaisVotado()
        {
            int MaisVotado = 0;
            for (int i = 1; i < Votos.Length; i++)
            {
                if (Votos[i] > Votos[MaisVotado])
                {
                    MaisVotado = i;
                }
            }

            return MaisVotado;
        }
        public void ResultadoFinal()
        {
            Console.WriteLine("\nSistema Operacional     Votos     %");
            Console.WriteLine("---------------------     -----     --");

            for(int i = 0; i < Votos.Length; i++)
            {
                double percentual = (Votos[i] / TotVotos) * 100;
                Console.WriteLine($"{Opcoes[i],-25}{Votos[i],-10}{percentual,3:F}%");
            }
            Console.WriteLine("---------------------     -----     --");
            Console.WriteLine($"Total                    {TotVotos,-10}");
            int MaisVotado = OSMaisVotado();
            Console.WriteLine($"\nO Sistema Operacional mais votado foi o {Opcoes[MaisVotado]}, com {Votos[MaisVotado]} votos, correspondendo a {((Votos[MaisVotado]/TotVotos) *100),3:F}% dos votos. ");
        }
 
    }
}
