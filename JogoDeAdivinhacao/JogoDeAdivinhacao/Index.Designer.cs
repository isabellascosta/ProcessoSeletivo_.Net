namespace JogoDeAdivinhacao
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTentativas = new Label();
            btnJogar = new Button();
            btnHistorico = new Button();
            txtEntrada = new TextBox();
            cbDificuldade = new ComboBox();
            lblEnunciado = new Label();
            lblPergunta = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblTentativas
            // 
            lblTentativas.BackColor = Color.Transparent;
            lblTentativas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTentativas.ForeColor = Color.IndianRed;
            lblTentativas.Location = new Point(637, 497);
            lblTentativas.Name = "lblTentativas";
            lblTentativas.Size = new Size(212, 32);
            lblTentativas.TabIndex = 4;
            lblTentativas.Text = "tentativa: 0 vezes";
            lblTentativas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            btnJogar.BackColor = Color.Transparent;
            btnJogar.FlatStyle = FlatStyle.Flat;
            btnJogar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnJogar.ForeColor = Color.Brown;
            btnJogar.Location = new Point(481, 309);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(113, 48);
            btnJogar.TabIndex = 5;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = false;
            btnJogar.Click += btnJogar_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.Transparent;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorico.ForeColor = Color.Brown;
            btnHistorico.Location = new Point(24, 463);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(181, 66);
            btnHistorico.TabIndex = 6;
            btnHistorico.Text = "histórico de partidas";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // txtEntrada
            // 
            txtEntrada.BorderStyle = BorderStyle.None;
            txtEntrada.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtEntrada.Location = new Point(447, 249);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(184, 43);
            txtEntrada.TabIndex = 2;
            txtEntrada.TextAlign = HorizontalAlignment.Center;
            // 
            // cbDificuldade
            // 
            cbDificuldade.FlatStyle = FlatStyle.Flat;
            cbDificuldade.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cbDificuldade.ForeColor = Color.LightCoral;
            cbDificuldade.FormattingEnabled = true;
            cbDificuldade.Items.AddRange(new object[] { "Fácil (3 Tentativas)", "Médio (5 Tentativas)", "Difícil (8 Tentativas)" });
            cbDificuldade.Location = new Point(181, 329);
            cbDificuldade.Name = "cbDificuldade";
            cbDificuldade.Size = new Size(154, 28);
            cbDificuldade.TabIndex = 7;
            cbDificuldade.SelectedIndexChanged += cbDificuldade_SelectedIndexChanged;
            // 
            // lblEnunciado
            // 
            lblEnunciado.AutoSize = true;
            lblEnunciado.BackColor = Color.Transparent;
            lblEnunciado.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnunciado.ForeColor = Color.IndianRed;
            lblEnunciado.Location = new Point(232, 9);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(328, 45);
            lblEnunciado.TabIndex = 0;
            lblEnunciado.Text = "Adivinhe o Número";
            lblEnunciado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPergunta
            // 
            lblPergunta.BackColor = Color.Transparent;
            lblPergunta.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPergunta.ForeColor = Color.IndianRed;
            lblPergunta.Location = new Point(120, 67);
            lblPergunta.Name = "lblPergunta";
            lblPergunta.Size = new Size(552, 32);
            lblPergunta.TabIndex = 1;
            lblPergunta.Text = "Em que numero estou pensando?";
            lblPergunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(182, 305);
            label2.Name = "label2";
            label2.Size = new Size(153, 21);
            label2.TabIndex = 8;
            label2.Text = "nível de dificuldade";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(181, 241);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(155, 22);
            txtNome.TabIndex = 9;
            txtNome.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(182, 217);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 10;
            label1.Text = "Nome do Jogador";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(462, 214);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 11;
            label3.Text = "Digite o Número";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            BackgroundImage = Properties.Resources.Design_sem_nome;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(873, 584);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnHistorico);
            Controls.Add(btnJogar);
            Controls.Add(lblTentativas);
            Controls.Add(txtEntrada);
            Controls.Add(cbDificuldade);
            Controls.Add(label2);
            Controls.Add(lblEnunciado);
            Controls.Add(lblPergunta);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Index";
            Text = "Jogo de Adivinhação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTentativas;
        private Button btnJogar;
        public Button btnHistorico;
        private TextBox txtEntrada;
        private ComboBox cbDificuldade;
        private Label lblEnunciado;
        private Label lblPergunta;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private Label label3;
    }
}