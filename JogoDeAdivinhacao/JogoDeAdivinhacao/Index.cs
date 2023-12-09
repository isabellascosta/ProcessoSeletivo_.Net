using System.Windows.Forms;
using System;
using JogoDeAdivinhacao.Entities;

namespace JogoDeAdivinhacao
{
    public partial class Index : Form
    {
        Random randomNumero = new Random();
        int numero = 0;
        int tentativas = 0;

        public Index()
        {
            InitializeComponent();
            CarregarQuestoes();
            cbDificuldade.DropDownStyle = ComboBoxStyle.DropDownList;
            txtEntrada.Enabled = false;
            cbDificuldade.SelectedIndexChanged += cbDificuldade_SelectedIndexChanged;
        }
        private int tentativasRestantes;
        private void btnJogar_Click(object sender, EventArgs e)
        {
            try
            {
                int entrada = Convert.ToInt32(txtEntrada.Text);
                string result = "a";
                string nomecompetidor = txtNome.Text;
                tentativas += 1;
                tentativasRestantes = tentativasRestantes - 1;
                if (entrada == numero)
                {
                    result = "Vit�ria";
                    MessageBox.Show("Parab�ns, voc� acertou! Tente Novamente");
                    Historico historico = new Historico(0, txtNome.Text, tentativas, DateTime.Now, result);
                    historico.Inserir();
                    CarregarQuestoes();
                    txtEntrada.Text = "";
                    tentativas = 0;
                }
                else if (tentativasRestantes == 0)
                {
                    result = "Derrota";
                    MessageBox.Show($"Voc� excedeu o n�mero de tentativas. O n�mero correto era {numero}. Tente Novamente");
                    Historico historico = new Historico(0, txtNome.Text, tentativas, DateTime.Now, result);
                    historico.Inserir();
                    CarregarQuestoes();
                    txtEntrada.Text = "";
                    tentativasRestantes = 0;
                    tentativas = 0;
                }

                else if (entrada < numero)
                {
                    MessageBox.Show("Mais Alto");
                    txtEntrada.Clear();
                }
                else if (entrada > numero)
                {

                    MessageBox.Show("Mais baixo");
                    txtEntrada.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarQuestoes()
        {
            if (cbDificuldade.Text == "F�cil (3 Tentativas)")
            {

                numero = randomNumero.Next(0, 10);
                lblPergunta.Text = "estou pensando em um numero entre: 0 e 10 ";
                tentativasRestantes = 3;
            }

            if (cbDificuldade.Text == "M�dio (5 Tentativas)")
            {
                numero = randomNumero.Next(0, 20);
                lblPergunta.Text = "estou pensando em um numero entre: 0 e 20 ";
                tentativasRestantes = 5;
            }


            if (cbDificuldade.Text == "Dif�cil (8 Tentativas)")
            {
                lblPergunta.Text = "estou pensando em um numero entre: 0 e 10 ";
                numero = randomNumero.Next(0, 30);
                tentativasRestantes = 8;
            }

        }
        private void cbDificuldade_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarQuestoes();
            txtEntrada.Enabled = true;
        }


        private void btnHistorico_Click(object sender, EventArgs e)
        {

            HistoricoForm historico = new HistoricoForm();
            historico.Show();
        }
    }
}