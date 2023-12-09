using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDeAdivinhacao.Entities;

namespace JogoDeAdivinhacao
{

    public partial class HistoricoForm : Form
    {
        public List<Historico> GridHistorico { get; set; }


        public HistoricoForm()
        {
            InitializeComponent();


        }
        private void btnExibir_Click(object sender, EventArgs e)
        {
            dgvHistorico.Rows.Clear();
            Historico historico = new Historico();
            var lista = historico.ListarHistorico();
            lista.ForEach(a =>
            {
                dgvHistorico.Rows.Add();
                dgvHistorico.Rows[lista.IndexOf(a)].Cells[dgvID.Index].Value = a.ID;
                dgvHistorico.Rows[lista.IndexOf(a)].Cells[dgvNome.Index].Value = a.Nome;
                dgvHistorico.Rows[lista.IndexOf(a)].Cells[dgvNumeroTentativa.Index].Value = a.NumerosTentativa;
                dgvHistorico.Rows[lista.IndexOf(a)].Cells[dgvData.Index].Value = a.DataJogada;
                dgvHistorico.Rows[lista.IndexOf(a)].Cells[dgvResultado.Index].Value = a.Resultado;
            });
        }
    }
}
