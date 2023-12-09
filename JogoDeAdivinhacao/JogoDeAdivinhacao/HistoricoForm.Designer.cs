namespace JogoDeAdivinhacao
{
    partial class HistoricoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvHistorico = new DataGridView();
            dgvID = new DataGridViewTextBoxColumn();
            dgvNome = new DataGridViewTextBoxColumn();
            dgvNumeroTentativa = new DataGridViewTextBoxColumn();
            dgvData = new DataGridViewTextBoxColumn();
            dgvResultado = new DataGridViewTextBoxColumn();
            btnExibir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(235, 88);
            label1.Name = "label1";
            label1.Size = new Size(374, 47);
            label1.TabIndex = 0;
            label1.Text = "Histórico de jogadas";
            // 
            // dgvHistorico
            // 
            dgvHistorico.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dgvHistorico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorico.BackgroundColor = Color.MistyRose;
            dgvHistorico.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistorico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Columns.AddRange(new DataGridViewColumn[] { dgvID, dgvNome, dgvNumeroTentativa, dgvData, dgvResultado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistorico.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorico.GridColor = Color.Firebrick;
            dgvHistorico.Location = new Point(147, 199);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Bahnschrift Light SemiCondensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHistorico.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dgvHistorico.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvHistorico.RowTemplate.Height = 25;
            dgvHistorico.Size = new Size(540, 173);
            dgvHistorico.TabIndex = 1;
            // 
            // dgvID
            // 
            dgvID.HeaderText = "ID";
            dgvID.Name = "dgvID";
            dgvID.ReadOnly = true;
            // 
            // dgvNome
            // 
            dgvNome.HeaderText = "Nome";
            dgvNome.Name = "dgvNome";
            dgvNome.ReadOnly = true;
            // 
            // dgvNumeroTentativa
            // 
            dgvNumeroTentativa.HeaderText = "Numero Tentativas";
            dgvNumeroTentativa.Name = "dgvNumeroTentativa";
            dgvNumeroTentativa.ReadOnly = true;
            // 
            // dgvData
            // 
            dgvData.HeaderText = "Data e Hora";
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            // 
            // dgvResultado
            // 
            dgvResultado.HeaderText = "Resultado";
            dgvResultado.Name = "dgvResultado";
            dgvResultado.ReadOnly = true;
            // 
            // btnExibir
            // 
            btnExibir.BackColor = Color.Transparent;
            btnExibir.FlatStyle = FlatStyle.Flat;
            btnExibir.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExibir.ForeColor = Color.Firebrick;
            btnExibir.Location = new Point(305, 435);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(199, 54);
            btnExibir.TabIndex = 3;
            btnExibir.Text = "Exibir dados";
            btnExibir.UseVisualStyleBackColor = false;
            btnExibir.Click += btnExibir_Click;
            // 
            // HistoricoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = Properties.Resources.Design_sem_nome;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 608);
            Controls.Add(btnExibir);
            Controls.Add(dgvHistorico);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HistoricoForm";
            Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public DataGridView dgvHistorico;
        private Button btnExibir;
        private DataGridViewTextBoxColumn dgvID;
        private DataGridViewTextBoxColumn dgvNome;
        private DataGridViewTextBoxColumn dgvNumeroTentativa;
        private DataGridViewTextBoxColumn dgvData;
        private DataGridViewTextBoxColumn dgvResultado;
    }
}