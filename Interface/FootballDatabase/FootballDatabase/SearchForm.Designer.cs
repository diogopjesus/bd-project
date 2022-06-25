namespace FootballDatabase
{
    partial class SearchForm
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabMatches = new System.Windows.Forms.TabPage();
            this.matchesAddButton = new System.Windows.Forms.Button();
            this.matchesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.matchesCompetitionComboBox = new System.Windows.Forms.ComboBox();
            this.matchesSearchButton = new System.Windows.Forms.Button();
            this.matchesSearchText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matchesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesCompetition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCompetitions = new System.Windows.Forms.TabPage();
            this.competitionsAddButton = new System.Windows.Forms.Button();
            this.competitionsDataGridView = new System.Windows.Forms.DataGridView();
            this.competitionsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionCounty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionsContinentComboBox = new System.Windows.Forms.ComboBox();
            this.competitionsCountryComboBox = new System.Windows.Forms.ComboBox();
            this.competitionsCompetitionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.competitionsSearchButton = new System.Windows.Forms.Button();
            this.competitionsSearchText = new System.Windows.Forms.TextBox();
            this.tabTeams = new System.Windows.Forms.TabPage();
            this.teamsAddButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.teamsCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsAbbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamsCompetitionComboBox = new System.Windows.Forms.ComboBox();
            this.teamsCountryComboBox = new System.Windows.Forms.ComboBox();
            this.teamsSearchButton = new System.Windows.Forms.Button();
            this.teamsSearchText = new System.Windows.Forms.TextBox();
            this.tabPlayers = new System.Windows.Forms.TabPage();
            this.playersAddButton = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersTeamComboBox = new System.Windows.Forms.ComboBox();
            this.playersCompetitionComboBox = new System.Windows.Forms.ComboBox();
            this.playersCountryComboBox = new System.Windows.Forms.ComboBox();
            this.playersSearchButton = new System.Windows.Forms.Button();
            this.playersSearchText = new System.Windows.Forms.TextBox();
            this.tabMenu.SuspendLayout();
            this.tabMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabCompetitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsDataGridView)).BeginInit();
            this.tabTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabMatches);
            this.tabMenu.Controls.Add(this.tabCompetitions);
            this.tabMenu.Controls.Add(this.tabTeams);
            this.tabMenu.Controls.Add(this.tabPlayers);
            this.tabMenu.Location = new System.Drawing.Point(-1, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(394, 572);
            this.tabMenu.TabIndex = 4;
            // 
            // tabMatches
            // 
            this.tabMatches.Controls.Add(this.matchesAddButton);
            this.tabMatches.Controls.Add(this.matchesDateTimePicker);
            this.tabMatches.Controls.Add(this.matchesCompetitionComboBox);
            this.tabMatches.Controls.Add(this.matchesSearchButton);
            this.tabMatches.Controls.Add(this.matchesSearchText);
            this.tabMatches.Controls.Add(this.dataGridView1);
            this.tabMatches.Location = new System.Drawing.Point(4, 24);
            this.tabMatches.Name = "tabMatches";
            this.tabMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatches.Size = new System.Drawing.Size(386, 544);
            this.tabMatches.TabIndex = 0;
            this.tabMatches.Text = "Matches";
            this.tabMatches.UseVisualStyleBackColor = true;
            this.tabMatches.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // matchesAddButton
            // 
            this.matchesAddButton.Location = new System.Drawing.Point(9, 507);
            this.matchesAddButton.Name = "matchesAddButton";
            this.matchesAddButton.Size = new System.Drawing.Size(367, 34);
            this.matchesAddButton.TabIndex = 9;
            this.matchesAddButton.Text = "Add new Match";
            this.matchesAddButton.UseVisualStyleBackColor = true;
            this.matchesAddButton.Click += new System.EventHandler(this.matchesAddButton_Click);
            // 
            // matchesDateTimePicker
            // 
            this.matchesDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.matchesDateTimePicker.Location = new System.Drawing.Point(9, 64);
            this.matchesDateTimePicker.Name = "matchesDateTimePicker";
            this.matchesDateTimePicker.Size = new System.Drawing.Size(367, 23);
            this.matchesDateTimePicker.TabIndex = 6;
            this.matchesDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // matchesCompetitionComboBox
            // 
            this.matchesCompetitionComboBox.FormattingEnabled = true;
            this.matchesCompetitionComboBox.Location = new System.Drawing.Point(9, 35);
            this.matchesCompetitionComboBox.Name = "matchesCompetitionComboBox";
            this.matchesCompetitionComboBox.Size = new System.Drawing.Size(367, 23);
            this.matchesCompetitionComboBox.TabIndex = 5;
            this.matchesCompetitionComboBox.Text = "Competition";
            this.matchesCompetitionComboBox.SelectedIndexChanged += new System.EventHandler(this.matchesCompetitionComboBox_SelectedIndexChanged);
            // 
            // matchesSearchButton
            // 
            this.matchesSearchButton.Location = new System.Drawing.Point(301, 6);
            this.matchesSearchButton.Name = "matchesSearchButton";
            this.matchesSearchButton.Size = new System.Drawing.Size(75, 23);
            this.matchesSearchButton.TabIndex = 3;
            this.matchesSearchButton.Text = "Search";
            this.matchesSearchButton.UseVisualStyleBackColor = true;
            this.matchesSearchButton.Click += new System.EventHandler(this.matchesSearchButton_Click);
            // 
            // matchesSearchText
            // 
            this.matchesSearchText.Location = new System.Drawing.Point(9, 6);
            this.matchesSearchText.Name = "matchesSearchText";
            this.matchesSearchText.Size = new System.Drawing.Size(286, 23);
            this.matchesSearchText.TabIndex = 2;
            this.matchesSearchText.TextChanged += new System.EventHandler(this.matchesSearchText_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchesId,
            this.matchesCompetition,
            this.matchesHome,
            this.matchesX1,
            this.matchesX2,
            this.matchesAway});
            this.dataGridView1.Location = new System.Drawing.Point(9, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(367, 408);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // matchesId
            // 
            this.matchesId.HeaderText = "ID";
            this.matchesId.MinimumWidth = 21;
            this.matchesId.Name = "matchesId";
            this.matchesId.ReadOnly = true;
            this.matchesId.Width = 21;
            // 
            // matchesCompetition
            // 
            this.matchesCompetition.HeaderText = "Competition";
            this.matchesCompetition.MinimumWidth = 100;
            this.matchesCompetition.Name = "matchesCompetition";
            this.matchesCompetition.ReadOnly = true;
            // 
            // matchesHome
            // 
            this.matchesHome.HeaderText = "Home";
            this.matchesHome.MinimumWidth = 10;
            this.matchesHome.Name = "matchesHome";
            this.matchesHome.ReadOnly = true;
            // 
            // matchesX1
            // 
            this.matchesX1.HeaderText = "";
            this.matchesX1.MinimumWidth = 21;
            this.matchesX1.Name = "matchesX1";
            this.matchesX1.ReadOnly = true;
            this.matchesX1.Width = 21;
            // 
            // matchesX2
            // 
            this.matchesX2.HeaderText = "";
            this.matchesX2.MinimumWidth = 21;
            this.matchesX2.Name = "matchesX2";
            this.matchesX2.ReadOnly = true;
            this.matchesX2.Width = 21;
            // 
            // matchesAway
            // 
            this.matchesAway.HeaderText = "Away";
            this.matchesAway.MinimumWidth = 100;
            this.matchesAway.Name = "matchesAway";
            this.matchesAway.ReadOnly = true;
            // 
            // tabCompetitions
            // 
            this.tabCompetitions.Controls.Add(this.competitionsAddButton);
            this.tabCompetitions.Controls.Add(this.competitionsDataGridView);
            this.tabCompetitions.Controls.Add(this.competitionsContinentComboBox);
            this.tabCompetitions.Controls.Add(this.competitionsCountryComboBox);
            this.tabCompetitions.Controls.Add(this.competitionsCompetitionTypeComboBox);
            this.tabCompetitions.Controls.Add(this.competitionsSearchButton);
            this.tabCompetitions.Controls.Add(this.competitionsSearchText);
            this.tabCompetitions.Location = new System.Drawing.Point(4, 24);
            this.tabCompetitions.Name = "tabCompetitions";
            this.tabCompetitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompetitions.Size = new System.Drawing.Size(386, 544);
            this.tabCompetitions.TabIndex = 1;
            this.tabCompetitions.Text = "Competitions";
            this.tabCompetitions.UseVisualStyleBackColor = true;
            // 
            // competitionsAddButton
            // 
            this.competitionsAddButton.Location = new System.Drawing.Point(9, 507);
            this.competitionsAddButton.Name = "competitionsAddButton";
            this.competitionsAddButton.Size = new System.Drawing.Size(367, 34);
            this.competitionsAddButton.TabIndex = 8;
            this.competitionsAddButton.Text = "Add new Competition";
            this.competitionsAddButton.UseVisualStyleBackColor = true;
            this.competitionsAddButton.Click += new System.EventHandler(this.competitionsAddButton_Click);
            // 
            // competitionsDataGridView
            // 
            this.competitionsDataGridView.AllowUserToAddRows = false;
            this.competitionsDataGridView.AllowUserToDeleteRows = false;
            this.competitionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.competitionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competitionsId,
            this.competitionCounty,
            this.competitionName});
            this.competitionsDataGridView.Location = new System.Drawing.Point(9, 122);
            this.competitionsDataGridView.Name = "competitionsDataGridView";
            this.competitionsDataGridView.ReadOnly = true;
            this.competitionsDataGridView.RowHeadersVisible = false;
            this.competitionsDataGridView.RowTemplate.Height = 25;
            this.competitionsDataGridView.Size = new System.Drawing.Size(367, 379);
            this.competitionsDataGridView.TabIndex = 7;
            this.competitionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // competitionsId
            // 
            this.competitionsId.Frozen = true;
            this.competitionsId.HeaderText = "ID";
            this.competitionsId.MinimumWidth = 23;
            this.competitionsId.Name = "competitionsId";
            this.competitionsId.ReadOnly = true;
            this.competitionsId.Width = 23;
            // 
            // competitionCounty
            // 
            this.competitionCounty.HeaderText = "Country";
            this.competitionCounty.MinimumWidth = 140;
            this.competitionCounty.Name = "competitionCounty";
            this.competitionCounty.ReadOnly = true;
            this.competitionCounty.Width = 140;
            // 
            // competitionName
            // 
            this.competitionName.HeaderText = "Name";
            this.competitionName.MinimumWidth = 200;
            this.competitionName.Name = "competitionName";
            this.competitionName.ReadOnly = true;
            this.competitionName.Width = 200;
            // 
            // competitionsContinentComboBox
            // 
            this.competitionsContinentComboBox.FormattingEnabled = true;
            this.competitionsContinentComboBox.Location = new System.Drawing.Point(9, 64);
            this.competitionsContinentComboBox.Name = "competitionsContinentComboBox";
            this.competitionsContinentComboBox.Size = new System.Drawing.Size(367, 23);
            this.competitionsContinentComboBox.TabIndex = 6;
            this.competitionsContinentComboBox.Text = "Continent";
            this.competitionsContinentComboBox.SelectedIndexChanged += new System.EventHandler(this.competitionsContinentComboBox_SelectedIndexChanged);
            // 
            // competitionsCountryComboBox
            // 
            this.competitionsCountryComboBox.FormattingEnabled = true;
            this.competitionsCountryComboBox.Location = new System.Drawing.Point(9, 93);
            this.competitionsCountryComboBox.Name = "competitionsCountryComboBox";
            this.competitionsCountryComboBox.Size = new System.Drawing.Size(367, 23);
            this.competitionsCountryComboBox.TabIndex = 5;
            this.competitionsCountryComboBox.Text = "Country";
            this.competitionsCountryComboBox.SelectedIndexChanged += new System.EventHandler(this.competitionsCountryComboBox_SelectedIndexChanged);
            // 
            // competitionsCompetitionTypeComboBox
            // 
            this.competitionsCompetitionTypeComboBox.FormattingEnabled = true;
            this.competitionsCompetitionTypeComboBox.Location = new System.Drawing.Point(9, 35);
            this.competitionsCompetitionTypeComboBox.Name = "competitionsCompetitionTypeComboBox";
            this.competitionsCompetitionTypeComboBox.Size = new System.Drawing.Size(367, 23);
            this.competitionsCompetitionTypeComboBox.TabIndex = 4;
            this.competitionsCompetitionTypeComboBox.Text = "Competition Type";
            this.competitionsCompetitionTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // competitionsSearchButton
            // 
            this.competitionsSearchButton.Location = new System.Drawing.Point(301, 6);
            this.competitionsSearchButton.Name = "competitionsSearchButton";
            this.competitionsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.competitionsSearchButton.TabIndex = 3;
            this.competitionsSearchButton.Text = "Search";
            this.competitionsSearchButton.UseVisualStyleBackColor = true;
            this.competitionsSearchButton.Click += new System.EventHandler(this.competitionsSearchButton_Click);
            // 
            // competitionsSearchText
            // 
            this.competitionsSearchText.Location = new System.Drawing.Point(9, 6);
            this.competitionsSearchText.Name = "competitionsSearchText";
            this.competitionsSearchText.Size = new System.Drawing.Size(286, 23);
            this.competitionsSearchText.TabIndex = 2;
            // 
            // tabTeams
            // 
            this.tabTeams.Controls.Add(this.teamsAddButton);
            this.tabTeams.Controls.Add(this.dataGridView2);
            this.tabTeams.Controls.Add(this.teamsCompetitionComboBox);
            this.tabTeams.Controls.Add(this.teamsCountryComboBox);
            this.tabTeams.Controls.Add(this.teamsSearchButton);
            this.tabTeams.Controls.Add(this.teamsSearchText);
            this.tabTeams.Location = new System.Drawing.Point(4, 24);
            this.tabTeams.Name = "tabTeams";
            this.tabTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeams.Size = new System.Drawing.Size(386, 544);
            this.tabTeams.TabIndex = 2;
            this.tabTeams.Text = "Teams";
            this.tabTeams.UseVisualStyleBackColor = true;
            // 
            // teamsAddButton
            // 
            this.teamsAddButton.Location = new System.Drawing.Point(9, 507);
            this.teamsAddButton.Name = "teamsAddButton";
            this.teamsAddButton.Size = new System.Drawing.Size(367, 34);
            this.teamsAddButton.TabIndex = 11;
            this.teamsAddButton.Text = "Add new Team";
            this.teamsAddButton.UseVisualStyleBackColor = true;
            this.teamsAddButton.Click += new System.EventHandler(this.teamsAddButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamsCountry,
            this.teamsAbbreviation,
            this.teamsName});
            this.dataGridView2.Location = new System.Drawing.Point(9, 93);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(367, 408);
            this.dataGridView2.TabIndex = 10;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // teamsCountry
            // 
            this.teamsCountry.HeaderText = "Country";
            this.teamsCountry.MinimumWidth = 90;
            this.teamsCountry.Name = "teamsCountry";
            this.teamsCountry.ReadOnly = true;
            this.teamsCountry.Width = 90;
            // 
            // teamsAbbreviation
            // 
            this.teamsAbbreviation.HeaderText = "Abbreviation";
            this.teamsAbbreviation.MinimumWidth = 100;
            this.teamsAbbreviation.Name = "teamsAbbreviation";
            this.teamsAbbreviation.ReadOnly = true;
            // 
            // teamsName
            // 
            this.teamsName.HeaderText = "Name";
            this.teamsName.MinimumWidth = 173;
            this.teamsName.Name = "teamsName";
            this.teamsName.ReadOnly = true;
            this.teamsName.Width = 173;
            // 
            // teamsCompetitionComboBox
            // 
            this.teamsCompetitionComboBox.FormattingEnabled = true;
            this.teamsCompetitionComboBox.Location = new System.Drawing.Point(9, 64);
            this.teamsCompetitionComboBox.Name = "teamsCompetitionComboBox";
            this.teamsCompetitionComboBox.Size = new System.Drawing.Size(367, 23);
            this.teamsCompetitionComboBox.TabIndex = 8;
            this.teamsCompetitionComboBox.Text = "Competition";
            // 
            // teamsCountryComboBox
            // 
            this.teamsCountryComboBox.FormattingEnabled = true;
            this.teamsCountryComboBox.Location = new System.Drawing.Point(9, 35);
            this.teamsCountryComboBox.Name = "teamsCountryComboBox";
            this.teamsCountryComboBox.Size = new System.Drawing.Size(367, 23);
            this.teamsCountryComboBox.TabIndex = 7;
            this.teamsCountryComboBox.Text = "Country";
            this.teamsCountryComboBox.SelectedIndexChanged += new System.EventHandler(this.teamsCountryComboBox_SelectedIndexChanged);
            // 
            // teamsSearchButton
            // 
            this.teamsSearchButton.Location = new System.Drawing.Point(301, 6);
            this.teamsSearchButton.Name = "teamsSearchButton";
            this.teamsSearchButton.Size = new System.Drawing.Size(75, 23);
            this.teamsSearchButton.TabIndex = 3;
            this.teamsSearchButton.Text = "Search";
            this.teamsSearchButton.UseVisualStyleBackColor = true;
            this.teamsSearchButton.Click += new System.EventHandler(this.teamsSearchButton_Click);
            // 
            // teamsSearchText
            // 
            this.teamsSearchText.Location = new System.Drawing.Point(9, 6);
            this.teamsSearchText.Name = "teamsSearchText";
            this.teamsSearchText.Size = new System.Drawing.Size(286, 23);
            this.teamsSearchText.TabIndex = 2;
            // 
            // tabPlayers
            // 
            this.tabPlayers.Controls.Add(this.playersAddButton);
            this.tabPlayers.Controls.Add(this.dataGridView3);
            this.tabPlayers.Controls.Add(this.playersTeamComboBox);
            this.tabPlayers.Controls.Add(this.playersCompetitionComboBox);
            this.tabPlayers.Controls.Add(this.playersCountryComboBox);
            this.tabPlayers.Controls.Add(this.playersSearchButton);
            this.tabPlayers.Controls.Add(this.playersSearchText);
            this.tabPlayers.Location = new System.Drawing.Point(4, 24);
            this.tabPlayers.Name = "tabPlayers";
            this.tabPlayers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayers.Size = new System.Drawing.Size(386, 544);
            this.tabPlayers.TabIndex = 3;
            this.tabPlayers.Text = "Players";
            this.tabPlayers.UseVisualStyleBackColor = true;
            this.tabPlayers.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // playersAddButton
            // 
            this.playersAddButton.Location = new System.Drawing.Point(9, 507);
            this.playersAddButton.Name = "playersAddButton";
            this.playersAddButton.Size = new System.Drawing.Size(367, 34);
            this.playersAddButton.TabIndex = 13;
            this.playersAddButton.Text = "Add new Player";
            this.playersAddButton.UseVisualStyleBackColor = true;
            this.playersAddButton.Click += new System.EventHandler(this.playersAddButton_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.playersPosition,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3.Location = new System.Drawing.Point(9, 122);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(367, 379);
            this.dataGridView3.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Team";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 75;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // playersPosition
            // 
            this.playersPosition.HeaderText = "Position";
            this.playersPosition.MinimumWidth = 75;
            this.playersPosition.Name = "playersPosition";
            this.playersPosition.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 188;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 188;
            // 
            // playersTeamComboBox
            // 
            this.playersTeamComboBox.FormattingEnabled = true;
            this.playersTeamComboBox.Location = new System.Drawing.Point(9, 93);
            this.playersTeamComboBox.Name = "playersTeamComboBox";
            this.playersTeamComboBox.Size = new System.Drawing.Size(367, 23);
            this.playersTeamComboBox.TabIndex = 11;
            this.playersTeamComboBox.Text = "Team";
            // 
            // playersCompetitionComboBox
            // 
            this.playersCompetitionComboBox.FormattingEnabled = true;
            this.playersCompetitionComboBox.Location = new System.Drawing.Point(9, 64);
            this.playersCompetitionComboBox.Name = "playersCompetitionComboBox";
            this.playersCompetitionComboBox.Size = new System.Drawing.Size(367, 23);
            this.playersCompetitionComboBox.TabIndex = 10;
            this.playersCompetitionComboBox.Text = "Competition";
            this.playersCompetitionComboBox.SelectedIndexChanged += new System.EventHandler(this.playersCompetitionComboBox_SelectedIndexChanged);
            // 
            // playersCountryComboBox
            // 
            this.playersCountryComboBox.FormattingEnabled = true;
            this.playersCountryComboBox.Location = new System.Drawing.Point(9, 35);
            this.playersCountryComboBox.Name = "playersCountryComboBox";
            this.playersCountryComboBox.Size = new System.Drawing.Size(367, 23);
            this.playersCountryComboBox.TabIndex = 9;
            this.playersCountryComboBox.Text = "Nacionality";
            this.playersCountryComboBox.SelectedIndexChanged += new System.EventHandler(this.playersCountryComboBox_SelectedIndexChanged);
            // 
            // playersSearchButton
            // 
            this.playersSearchButton.Location = new System.Drawing.Point(301, 6);
            this.playersSearchButton.Name = "playersSearchButton";
            this.playersSearchButton.Size = new System.Drawing.Size(75, 23);
            this.playersSearchButton.TabIndex = 1;
            this.playersSearchButton.Text = "Search";
            this.playersSearchButton.UseVisualStyleBackColor = true;
            this.playersSearchButton.Click += new System.EventHandler(this.playersSearchButton_Click);
            // 
            // playersSearchText
            // 
            this.playersSearchText.Location = new System.Drawing.Point(9, 6);
            this.playersSearchText.Name = "playersSearchText";
            this.playersSearchText.Size = new System.Drawing.Size(286, 23);
            this.playersSearchText.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 574);
            this.Controls.Add(this.tabMenu);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabMatches.ResumeLayout(false);
            this.tabMatches.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabCompetitions.ResumeLayout(false);
            this.tabCompetitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competitionsDataGridView)).EndInit();
            this.tabTeams.ResumeLayout(false);
            this.tabTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPlayers.ResumeLayout(false);
            this.tabPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMenu;
        private TabPage tabMatches;
        private TabPage tabCompetitions;
        private TabPage tabTeams;
        private TabPage tabPlayers;
        private Button playersSearchButton;
        private TextBox playersSearchText;
        private Button matchesSearchButton;
        private TextBox matchesSearchText;
        private Button competitionsSearchButton;
        private TextBox competitionsSearchText;
        private Button teamsSearchButton;
        private TextBox teamsSearchText;
        private ComboBox competitionsContinentComboBox;
        private ComboBox competitionsCountryComboBox;
        private ComboBox competitionsCompetitionTypeComboBox;
        private Button competitionsAddButton;
        private DataGridView competitionsDataGridView;
        private DateTimePicker matchesDateTimePicker;
        private ComboBox matchesCompetitionComboBox;
        private DataGridView dataGridView1;
        private Button matchesAddButton;
        private Button teamsAddButton;
        private DataGridView dataGridView2;
        private ComboBox teamsCompetitionComboBox;
        private ComboBox teamsCountryComboBox;
        private DataGridViewTextBoxColumn teamsCountry;
        private DataGridViewTextBoxColumn teamsAbbreviation;
        private DataGridViewTextBoxColumn teamsName;
        private ComboBox playersCompetitionComboBox;
        private ComboBox playersCountryComboBox;
        private Button playersAddButton;
        private DataGridView dataGridView3;
        private ComboBox playersTeamComboBox;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn playersPosition;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn matchesId;
        private DataGridViewTextBoxColumn matchesCompetition;
        private DataGridViewTextBoxColumn matchesHome;
        private DataGridViewTextBoxColumn matchesX1;
        private DataGridViewTextBoxColumn matchesX2;
        private DataGridViewTextBoxColumn matchesAway;
        private DataGridViewTextBoxColumn competitionsId;
        private DataGridViewTextBoxColumn competitionCounty;
        private DataGridViewTextBoxColumn competitionName;
    }
}