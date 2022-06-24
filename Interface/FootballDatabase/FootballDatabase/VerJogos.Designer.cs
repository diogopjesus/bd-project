namespace FootballDatabase
{
    partial class VerJogos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProcurarEquipas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Competition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ver Jogos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Procurar Competição";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ProcurarCampeonato_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ver Jogadores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.VerJogadores_Click);
            // 
            // ProcurarEquipas
            // 
            this.ProcurarEquipas.Location = new System.Drawing.Point(651, 15);
            this.ProcurarEquipas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcurarEquipas.Name = "ProcurarEquipas";
            this.ProcurarEquipas.Size = new System.Drawing.Size(203, 66);
            this.ProcurarEquipas.TabIndex = 3;
            this.ProcurarEquipas.Text = "Equipas";
            this.ProcurarEquipas.UseVisualStyleBackColor = true;
            this.ProcurarEquipas.Click += new System.EventHandler(this.ProcurarEquipas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jogos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1224, 30);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 38);
            this.button4.TabIndex = 12;
            this.button4.Text = "Adicionar Jogos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AdicionarJogo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Competition,
            this.Data,
            this.HomeTeam,
            this.HomeGoals,
            this.AwayTeam,
            this.AwayGoals,
            this.Stadium,
            this.Referee});
            this.dataGridView1.Location = new System.Drawing.Point(16, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1459, 433);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Competition
            // 
            this.Competition.HeaderText = "Competition";
            this.Competition.MinimumWidth = 6;
            this.Competition.Name = "Competition";
            this.Competition.ReadOnly = true;
            this.Competition.Width = 125;
            // 
            // Data
            // 
            this.Data.HeaderText = "Date";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // HomeTeam
            // 
            this.HomeTeam.HeaderText = "Home Team";
            this.HomeTeam.MinimumWidth = 6;
            this.HomeTeam.Name = "HomeTeam";
            this.HomeTeam.ReadOnly = true;
            this.HomeTeam.Width = 125;
            // 
            // HomeGoals
            // 
            this.HomeGoals.HeaderText = "Home Goals";
            this.HomeGoals.MinimumWidth = 6;
            this.HomeGoals.Name = "HomeGoals";
            this.HomeGoals.ReadOnly = true;
            this.HomeGoals.Width = 125;
            // 
            // AwayTeam
            // 
            this.AwayTeam.HeaderText = "Away Team";
            this.AwayTeam.MinimumWidth = 6;
            this.AwayTeam.Name = "AwayTeam";
            this.AwayTeam.ReadOnly = true;
            this.AwayTeam.Width = 125;
            // 
            // AwayGoals
            // 
            this.AwayGoals.HeaderText = "Away Goals";
            this.AwayGoals.MinimumWidth = 6;
            this.AwayGoals.Name = "AwayGoals";
            this.AwayGoals.ReadOnly = true;
            this.AwayGoals.Width = 125;
            // 
            // Stadium
            // 
            this.Stadium.HeaderText = "Stadium";
            this.Stadium.MinimumWidth = 6;
            this.Stadium.Name = "Stadium";
            this.Stadium.ReadOnly = true;
            this.Stadium.Width = 125;
            // 
            // Referee
            // 
            this.Referee.HeaderText = "Referee";
            this.Referee.MinimumWidth = 6;
            this.Referee.Name = "Referee";
            this.Referee.ReadOnly = true;
            this.Referee.Width = 125;
            // 
            // VerJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1676, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProcurarEquipas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VerJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.VerJogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ProcurarEquipas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stadium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referee;
    }
}

