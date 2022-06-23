namespace FootballDatabase
{
    partial class ProcurarEquipas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.continent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.home_team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.away_team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ver Jogos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.VerJogos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Procurar Competição";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ProcurarCampeonato_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ver Jogadores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.VerJogadores_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(12, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Equipas";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Procurar Equipas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 474);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "Adicionar Equipa ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AdicionarEquipa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abbreviation,
            this.name,
            this.continent,
            this.country,
            this.stadium,
            this.attendance,
            this.coach});
            this.dataGridView1.Location = new System.Drawing.Point(171, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(914, 63);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.player_name,
            this.player_position,
            this.player_country});
            this.dataGridView2.Location = new System.Drawing.Point(171, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(350, 390);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competition,
            this.game_date,
            this.home_team,
            this.away_team,
            this.result});
            this.dataGridView3.Location = new System.Drawing.Point(527, 121);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(558, 390);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // abbreviation
            // 
            this.abbreviation.HeaderText = "abbreviation";
            this.abbreviation.Name = "abbreviation";
            this.abbreviation.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // continent
            // 
            this.continent.HeaderText = "continent";
            this.continent.Name = "continent";
            this.continent.ReadOnly = true;
            // 
            // country
            // 
            this.country.HeaderText = "country";
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // stadium
            // 
            this.stadium.HeaderText = "stadium";
            this.stadium.Name = "stadium";
            this.stadium.ReadOnly = true;
            // 
            // attendance
            // 
            this.attendance.HeaderText = "attendance";
            this.attendance.Name = "attendance";
            this.attendance.ReadOnly = true;
            // 
            // coach
            // 
            this.coach.HeaderText = "coach";
            this.coach.Name = "coach";
            this.coach.ReadOnly = true;
            // 
            // player_name
            // 
            this.player_name.HeaderText = "name";
            this.player_name.Name = "player_name";
            this.player_name.ReadOnly = true;
            // 
            // player_position
            // 
            this.player_position.HeaderText = "position";
            this.player_position.Name = "player_position";
            this.player_position.ReadOnly = true;
            // 
            // player_country
            // 
            this.player_country.HeaderText = "country";
            this.player_country.Name = "player_country";
            this.player_country.ReadOnly = true;
            // 
            // competition
            // 
            this.competition.HeaderText = "Competition";
            this.competition.Name = "competition";
            this.competition.ReadOnly = true;
            // 
            // game_date
            // 
            this.game_date.HeaderText = "Date";
            this.game_date.Name = "game_date";
            this.game_date.ReadOnly = true;
            // 
            // home_team
            // 
            this.home_team.HeaderText = "Home";
            this.home_team.Name = "home_team";
            this.home_team.ReadOnly = true;
            // 
            // away_team
            // 
            this.away_team.HeaderText = "Away";
            this.away_team.Name = "away_team";
            this.away_team.ReadOnly = true;
            // 
            // result
            // 
            this.result.HeaderText = "Result";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // ProcurarEquipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 523);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProcurarEquipas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProcurarEquipas";
            this.Load += new System.EventHandler(this.ProcurarEquipas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn continent;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadium;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn player_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn competition;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn home_team;
        private System.Windows.Forms.DataGridViewTextBoxColumn away_team;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
    }
}