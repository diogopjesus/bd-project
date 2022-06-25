namespace FootballDatabase
{
    partial class MatchFrom
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
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.detailsDeleteMisconductButton = new System.Windows.Forms.Button();
            this.detailsDeleteGoalButton = new System.Windows.Forms.Button();
            this.detailsDeleteSubstitutionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsAddMisconductButton = new System.Windows.Forms.Button();
            this.detailsAddGoalButton = new System.Windows.Forms.Button();
            this.detailsAddSubstitutionButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabLineups = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lineupsAwayTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.lineupsHomeTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.lineupsHomeDataGridView = new System.Windows.Forms.DataGridView();
            this.homePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineupsAwayDataGridView = new System.Windows.Forms.DataGridView();
            this.positionAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.statsAwayTextBox = new System.Windows.Forms.TextBox();
            this.statsHomeTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayCornersTextBox = new System.Windows.Forms.TextBox();
            this.statsHomeCornersTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayFoulsTextBox = new System.Windows.Forms.TextBox();
            this.statsHomeFoulsTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayTacklesTextBox = new System.Windows.Forms.TextBox();
            this.statsHomeTacklesTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayPassesTextBox = new System.Windows.Forms.TextBox();
            this.statsHomePassesTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayOffsidesTextBox = new System.Windows.Forms.TextBox();
            this.statsHomeOffsidesTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayShotsTextBox = new System.Windows.Forms.TextBox();
            this.statsHomeShotsTextBox = new System.Windows.Forms.TextBox();
            this.statsAwayPossessionTextBox = new System.Windows.Forms.TextBox();
            this.statsHomePossessionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matchDeleteMatchButton = new System.Windows.Forms.Button();
            this.matchEditMatchButton = new System.Windows.Forms.Button();
            this.tabMenu.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tabLineups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineupsHomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineupsAwayDataGridView)).BeginInit();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabDetails);
            this.tabMenu.Controls.Add(this.tabLineups);
            this.tabMenu.Controls.Add(this.tabStats);
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(392, 478);
            this.tabMenu.TabIndex = 0;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.detailsDeleteMisconductButton);
            this.tabDetails.Controls.Add(this.detailsDeleteGoalButton);
            this.tabDetails.Controls.Add(this.detailsDeleteSubstitutionButton);
            this.tabDetails.Controls.Add(this.label1);
            this.tabDetails.Controls.Add(this.detailsAddMisconductButton);
            this.tabDetails.Controls.Add(this.detailsAddGoalButton);
            this.tabDetails.Controls.Add(this.detailsAddSubstitutionButton);
            this.tabDetails.Controls.Add(this.listBox1);
            this.tabDetails.Controls.Add(this.textBox4);
            this.tabDetails.Controls.Add(this.textBox3);
            this.tabDetails.Controls.Add(this.textBox2);
            this.tabDetails.Controls.Add(this.textBox1);
            this.tabDetails.Location = new System.Drawing.Point(4, 24);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(384, 450);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            this.tabDetails.Click += new System.EventHandler(this.tabDetails_Click);
            // 
            // detailsDeleteMisconductButton
            // 
            this.detailsDeleteMisconductButton.Location = new System.Drawing.Point(264, 420);
            this.detailsDeleteMisconductButton.Name = "detailsDeleteMisconductButton";
            this.detailsDeleteMisconductButton.Size = new System.Drawing.Size(113, 24);
            this.detailsDeleteMisconductButton.TabIndex = 12;
            this.detailsDeleteMisconductButton.Text = "Del Misconduct";
            this.detailsDeleteMisconductButton.UseVisualStyleBackColor = true;
            // 
            // detailsDeleteGoalButton
            // 
            this.detailsDeleteGoalButton.Location = new System.Drawing.Point(129, 420);
            this.detailsDeleteGoalButton.Name = "detailsDeleteGoalButton";
            this.detailsDeleteGoalButton.Size = new System.Drawing.Size(129, 24);
            this.detailsDeleteGoalButton.TabIndex = 11;
            this.detailsDeleteGoalButton.Text = "Delete Goal";
            this.detailsDeleteGoalButton.UseVisualStyleBackColor = true;
            // 
            // detailsDeleteSubstitutionButton
            // 
            this.detailsDeleteSubstitutionButton.Location = new System.Drawing.Point(10, 420);
            this.detailsDeleteSubstitutionButton.Name = "detailsDeleteSubstitutionButton";
            this.detailsDeleteSubstitutionButton.Size = new System.Drawing.Size(113, 24);
            this.detailsDeleteSubstitutionButton.TabIndex = 10;
            this.detailsDeleteSubstitutionButton.Text = "Delete Sub";
            this.detailsDeleteSubstitutionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "-";
            // 
            // detailsAddMisconductButton
            // 
            this.detailsAddMisconductButton.Location = new System.Drawing.Point(264, 390);
            this.detailsAddMisconductButton.Name = "detailsAddMisconductButton";
            this.detailsAddMisconductButton.Size = new System.Drawing.Size(113, 24);
            this.detailsAddMisconductButton.TabIndex = 8;
            this.detailsAddMisconductButton.Text = "Add Misconduct";
            this.detailsAddMisconductButton.UseVisualStyleBackColor = true;
            this.detailsAddMisconductButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // detailsAddGoalButton
            // 
            this.detailsAddGoalButton.Location = new System.Drawing.Point(129, 390);
            this.detailsAddGoalButton.Name = "detailsAddGoalButton";
            this.detailsAddGoalButton.Size = new System.Drawing.Size(129, 24);
            this.detailsAddGoalButton.TabIndex = 7;
            this.detailsAddGoalButton.Text = "Add Goal";
            this.detailsAddGoalButton.UseVisualStyleBackColor = true;
            this.detailsAddGoalButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // detailsAddSubstitutionButton
            // 
            this.detailsAddSubstitutionButton.Location = new System.Drawing.Point(10, 390);
            this.detailsAddSubstitutionButton.Name = "detailsAddSubstitutionButton";
            this.detailsAddSubstitutionButton.Size = new System.Drawing.Size(113, 24);
            this.detailsAddSubstitutionButton.TabIndex = 6;
            this.detailsAddSubstitutionButton.Text = "Add Sub";
            this.detailsAddSubstitutionButton.UseVisualStyleBackColor = true;
            this.detailsAddSubstitutionButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(8, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(367, 349);
            this.listBox1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(44, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(44, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(65, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(65, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabLineups
            // 
            this.tabLineups.Controls.Add(this.button1);
            this.tabLineups.Controls.Add(this.button2);
            this.tabLineups.Controls.Add(this.lineupsAwayTeamNameTextBox);
            this.tabLineups.Controls.Add(this.lineupsHomeTeamNameTextBox);
            this.tabLineups.Controls.Add(this.lineupsHomeDataGridView);
            this.tabLineups.Controls.Add(this.lineupsAwayDataGridView);
            this.tabLineups.Location = new System.Drawing.Point(4, 24);
            this.tabLineups.Name = "tabLineups";
            this.tabLineups.Padding = new System.Windows.Forms.Padding(3);
            this.tabLineups.Size = new System.Drawing.Size(384, 450);
            this.tabLineups.TabIndex = 1;
            this.tabLineups.Text = "Line-ups";
            this.tabLineups.UseVisualStyleBackColor = true;
            this.tabLineups.Click += new System.EventHandler(this.tabLineups_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete Player";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(367, 24);
            this.button2.TabIndex = 12;
            this.button2.Text = "Add Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lineupsAwayTeamNameTextBox
            // 
            this.lineupsAwayTeamNameTextBox.Location = new System.Drawing.Point(199, 6);
            this.lineupsAwayTeamNameTextBox.Name = "lineupsAwayTeamNameTextBox";
            this.lineupsAwayTeamNameTextBox.ReadOnly = true;
            this.lineupsAwayTeamNameTextBox.Size = new System.Drawing.Size(176, 23);
            this.lineupsAwayTeamNameTextBox.TabIndex = 5;
            this.lineupsAwayTeamNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lineupsHomeTeamNameTextBox
            // 
            this.lineupsHomeTeamNameTextBox.Location = new System.Drawing.Point(8, 6);
            this.lineupsHomeTeamNameTextBox.Name = "lineupsHomeTeamNameTextBox";
            this.lineupsHomeTeamNameTextBox.ReadOnly = true;
            this.lineupsHomeTeamNameTextBox.Size = new System.Drawing.Size(176, 23);
            this.lineupsHomeTeamNameTextBox.TabIndex = 4;
            this.lineupsHomeTeamNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lineupsHomeDataGridView
            // 
            this.lineupsHomeDataGridView.AllowUserToAddRows = false;
            this.lineupsHomeDataGridView.AllowUserToDeleteRows = false;
            this.lineupsHomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineupsHomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homePosition,
            this.nameHome});
            this.lineupsHomeDataGridView.Location = new System.Drawing.Point(8, 34);
            this.lineupsHomeDataGridView.Name = "lineupsHomeDataGridView";
            this.lineupsHomeDataGridView.ReadOnly = true;
            this.lineupsHomeDataGridView.RowHeadersVisible = false;
            this.lineupsHomeDataGridView.RowTemplate.Height = 25;
            this.lineupsHomeDataGridView.Size = new System.Drawing.Size(176, 351);
            this.lineupsHomeDataGridView.TabIndex = 3;
            // 
            // homePosition
            // 
            this.homePosition.HeaderText = "Pos";
            this.homePosition.MinimumWidth = 50;
            this.homePosition.Name = "homePosition";
            this.homePosition.ReadOnly = true;
            this.homePosition.Width = 50;
            // 
            // nameHome
            // 
            this.nameHome.HeaderText = "Name";
            this.nameHome.MinimumWidth = 122;
            this.nameHome.Name = "nameHome";
            this.nameHome.ReadOnly = true;
            this.nameHome.Width = 122;
            // 
            // lineupsAwayDataGridView
            // 
            this.lineupsAwayDataGridView.AllowUserToAddRows = false;
            this.lineupsAwayDataGridView.AllowUserToDeleteRows = false;
            this.lineupsAwayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineupsAwayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionAway,
            this.nameAway});
            this.lineupsAwayDataGridView.Location = new System.Drawing.Point(199, 34);
            this.lineupsAwayDataGridView.Name = "lineupsAwayDataGridView";
            this.lineupsAwayDataGridView.ReadOnly = true;
            this.lineupsAwayDataGridView.RowHeadersVisible = false;
            this.lineupsAwayDataGridView.RowTemplate.Height = 25;
            this.lineupsAwayDataGridView.Size = new System.Drawing.Size(176, 351);
            this.lineupsAwayDataGridView.TabIndex = 2;
            // 
            // positionAway
            // 
            this.positionAway.HeaderText = "Pos";
            this.positionAway.MinimumWidth = 50;
            this.positionAway.Name = "positionAway";
            this.positionAway.ReadOnly = true;
            this.positionAway.Width = 50;
            // 
            // nameAway
            // 
            this.nameAway.HeaderText = "Name";
            this.nameAway.MinimumWidth = 122;
            this.nameAway.Name = "nameAway";
            this.nameAway.ReadOnly = true;
            this.nameAway.Width = 122;
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.statsAwayTextBox);
            this.tabStats.Controls.Add(this.statsHomeTextBox);
            this.tabStats.Controls.Add(this.statsAwayCornersTextBox);
            this.tabStats.Controls.Add(this.statsHomeCornersTextBox);
            this.tabStats.Controls.Add(this.statsAwayFoulsTextBox);
            this.tabStats.Controls.Add(this.statsHomeFoulsTextBox);
            this.tabStats.Controls.Add(this.statsAwayTacklesTextBox);
            this.tabStats.Controls.Add(this.statsHomeTacklesTextBox);
            this.tabStats.Controls.Add(this.statsAwayPassesTextBox);
            this.tabStats.Controls.Add(this.statsHomePassesTextBox);
            this.tabStats.Controls.Add(this.statsAwayOffsidesTextBox);
            this.tabStats.Controls.Add(this.statsHomeOffsidesTextBox);
            this.tabStats.Controls.Add(this.statsAwayShotsTextBox);
            this.tabStats.Controls.Add(this.statsHomeShotsTextBox);
            this.tabStats.Controls.Add(this.statsAwayPossessionTextBox);
            this.tabStats.Controls.Add(this.statsHomePossessionTextBox);
            this.tabStats.Controls.Add(this.label8);
            this.tabStats.Controls.Add(this.label7);
            this.tabStats.Controls.Add(this.label6);
            this.tabStats.Controls.Add(this.label5);
            this.tabStats.Controls.Add(this.label4);
            this.tabStats.Controls.Add(this.label3);
            this.tabStats.Controls.Add(this.label2);
            this.tabStats.Location = new System.Drawing.Point(4, 24);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabStats.Size = new System.Drawing.Size(384, 450);
            this.tabStats.TabIndex = 2;
            this.tabStats.Text = "Stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // statsAwayTextBox
            // 
            this.statsAwayTextBox.Location = new System.Drawing.Point(203, 24);
            this.statsAwayTextBox.Name = "statsAwayTextBox";
            this.statsAwayTextBox.ReadOnly = true;
            this.statsAwayTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayTextBox.TabIndex = 22;
            // 
            // statsHomeTextBox
            // 
            this.statsHomeTextBox.Location = new System.Drawing.Point(79, 24);
            this.statsHomeTextBox.Name = "statsHomeTextBox";
            this.statsHomeTextBox.ReadOnly = true;
            this.statsHomeTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomeTextBox.TabIndex = 21;
            // 
            // statsAwayCornersTextBox
            // 
            this.statsAwayCornersTextBox.Location = new System.Drawing.Point(275, 329);
            this.statsAwayCornersTextBox.Name = "statsAwayCornersTextBox";
            this.statsAwayCornersTextBox.ReadOnly = true;
            this.statsAwayCornersTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayCornersTextBox.TabIndex = 20;
            // 
            // statsHomeCornersTextBox
            // 
            this.statsHomeCornersTextBox.Location = new System.Drawing.Point(8, 328);
            this.statsHomeCornersTextBox.Name = "statsHomeCornersTextBox";
            this.statsHomeCornersTextBox.ReadOnly = true;
            this.statsHomeCornersTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomeCornersTextBox.TabIndex = 19;
            // 
            // statsAwayFoulsTextBox
            // 
            this.statsAwayFoulsTextBox.Location = new System.Drawing.Point(275, 285);
            this.statsAwayFoulsTextBox.Name = "statsAwayFoulsTextBox";
            this.statsAwayFoulsTextBox.ReadOnly = true;
            this.statsAwayFoulsTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayFoulsTextBox.TabIndex = 18;
            // 
            // statsHomeFoulsTextBox
            // 
            this.statsHomeFoulsTextBox.Location = new System.Drawing.Point(8, 285);
            this.statsHomeFoulsTextBox.Name = "statsHomeFoulsTextBox";
            this.statsHomeFoulsTextBox.ReadOnly = true;
            this.statsHomeFoulsTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomeFoulsTextBox.TabIndex = 17;
            // 
            // statsAwayTacklesTextBox
            // 
            this.statsAwayTacklesTextBox.Location = new System.Drawing.Point(275, 240);
            this.statsAwayTacklesTextBox.Name = "statsAwayTacklesTextBox";
            this.statsAwayTacklesTextBox.ReadOnly = true;
            this.statsAwayTacklesTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayTacklesTextBox.TabIndex = 16;
            // 
            // statsHomeTacklesTextBox
            // 
            this.statsHomeTacklesTextBox.Location = new System.Drawing.Point(8, 239);
            this.statsHomeTacklesTextBox.Name = "statsHomeTacklesTextBox";
            this.statsHomeTacklesTextBox.ReadOnly = true;
            this.statsHomeTacklesTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomeTacklesTextBox.TabIndex = 15;
            // 
            // statsAwayPassesTextBox
            // 
            this.statsAwayPassesTextBox.Location = new System.Drawing.Point(275, 196);
            this.statsAwayPassesTextBox.Name = "statsAwayPassesTextBox";
            this.statsAwayPassesTextBox.ReadOnly = true;
            this.statsAwayPassesTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayPassesTextBox.TabIndex = 14;
            // 
            // statsHomePassesTextBox
            // 
            this.statsHomePassesTextBox.Location = new System.Drawing.Point(8, 195);
            this.statsHomePassesTextBox.Name = "statsHomePassesTextBox";
            this.statsHomePassesTextBox.ReadOnly = true;
            this.statsHomePassesTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomePassesTextBox.TabIndex = 13;
            // 
            // statsAwayOffsidesTextBox
            // 
            this.statsAwayOffsidesTextBox.Location = new System.Drawing.Point(275, 152);
            this.statsAwayOffsidesTextBox.Name = "statsAwayOffsidesTextBox";
            this.statsAwayOffsidesTextBox.ReadOnly = true;
            this.statsAwayOffsidesTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayOffsidesTextBox.TabIndex = 12;
            // 
            // statsHomeOffsidesTextBox
            // 
            this.statsHomeOffsidesTextBox.Location = new System.Drawing.Point(8, 151);
            this.statsHomeOffsidesTextBox.Name = "statsHomeOffsidesTextBox";
            this.statsHomeOffsidesTextBox.ReadOnly = true;
            this.statsHomeOffsidesTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomeOffsidesTextBox.TabIndex = 11;
            // 
            // statsAwayShotsTextBox
            // 
            this.statsAwayShotsTextBox.Location = new System.Drawing.Point(275, 110);
            this.statsAwayShotsTextBox.Name = "statsAwayShotsTextBox";
            this.statsAwayShotsTextBox.ReadOnly = true;
            this.statsAwayShotsTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayShotsTextBox.TabIndex = 10;
            // 
            // statsHomeShotsTextBox
            // 
            this.statsHomeShotsTextBox.Location = new System.Drawing.Point(8, 109);
            this.statsHomeShotsTextBox.Name = "statsHomeShotsTextBox";
            this.statsHomeShotsTextBox.ReadOnly = true;
            this.statsHomeShotsTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomeShotsTextBox.TabIndex = 9;
            // 
            // statsAwayPossessionTextBox
            // 
            this.statsAwayPossessionTextBox.Location = new System.Drawing.Point(275, 71);
            this.statsAwayPossessionTextBox.Name = "statsAwayPossessionTextBox";
            this.statsAwayPossessionTextBox.ReadOnly = true;
            this.statsAwayPossessionTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsAwayPossessionTextBox.TabIndex = 8;
            // 
            // statsHomePossessionTextBox
            // 
            this.statsHomePossessionTextBox.Location = new System.Drawing.Point(8, 70);
            this.statsHomePossessionTextBox.Name = "statsHomePossessionTextBox";
            this.statsHomePossessionTextBox.ReadOnly = true;
            this.statsHomePossessionTextBox.Size = new System.Drawing.Size(100, 23);
            this.statsHomePossessionTextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(153, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Corners";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(163, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fouls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(156, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tackles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(158, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Passes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(151, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Offsides";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(163, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Shots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(141, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Possession";
            // 
            // matchDeleteMatchButton
            // 
            this.matchDeleteMatchButton.Location = new System.Drawing.Point(12, 528);
            this.matchDeleteMatchButton.Name = "matchDeleteMatchButton";
            this.matchDeleteMatchButton.Size = new System.Drawing.Size(367, 40);
            this.matchDeleteMatchButton.TabIndex = 5;
            this.matchDeleteMatchButton.Text = "Delete Match";
            this.matchDeleteMatchButton.UseVisualStyleBackColor = true;
            this.matchDeleteMatchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // matchEditMatchButton
            // 
            this.matchEditMatchButton.Location = new System.Drawing.Point(12, 480);
            this.matchEditMatchButton.Name = "matchEditMatchButton";
            this.matchEditMatchButton.Size = new System.Drawing.Size(367, 40);
            this.matchEditMatchButton.TabIndex = 6;
            this.matchEditMatchButton.Text = "Edit Match";
            this.matchEditMatchButton.UseVisualStyleBackColor = true;
            // 
            // MatchFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 574);
            this.Controls.Add(this.matchEditMatchButton);
            this.Controls.Add(this.matchDeleteMatchButton);
            this.Controls.Add(this.tabMenu);
            this.Name = "MatchFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Match";
            this.Load += new System.EventHandler(this.FeedForm_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tabDetails.PerformLayout();
            this.tabLineups.ResumeLayout(false);
            this.tabLineups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineupsHomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineupsAwayDataGridView)).EndInit();
            this.tabStats.ResumeLayout(false);
            this.tabStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabMenu;
        private TabPage tabDetails;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabLineups;
        private TabPage tabStats;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button detailsAddSubstitutionButton;
        private ListBox listBox1;
        private Button matchDeleteMatchButton;
        private Button detailsAddMisconductButton;
        private Button detailsAddGoalButton;
        private Label label1;
        private TextBox lineupsAwayTeamNameTextBox;
        private TextBox lineupsHomeTeamNameTextBox;
        private DataGridView lineupsHomeDataGridView;
        private DataGridView lineupsAwayDataGridView;
        private DataGridViewTextBoxColumn homePosition;
        private DataGridViewTextBoxColumn nameHome;
        private DataGridViewTextBoxColumn positionAway;
        private DataGridViewTextBoxColumn nameAway;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private TextBox statsAwayTextBox;
        private TextBox statsHomeTextBox;
        private TextBox statsAwayCornersTextBox;
        private TextBox statsHomeCornersTextBox;
        private TextBox statsAwayFoulsTextBox;
        private TextBox statsHomeFoulsTextBox;
        private TextBox statsAwayTacklesTextBox;
        private TextBox statsHomeTacklesTextBox;
        private TextBox statsAwayPassesTextBox;
        private TextBox statsHomePassesTextBox;
        private TextBox statsAwayOffsidesTextBox;
        private TextBox statsHomeOffsidesTextBox;
        private TextBox statsAwayShotsTextBox;
        private TextBox statsHomeShotsTextBox;
        private TextBox statsAwayPossessionTextBox;
        private TextBox statsHomePossessionTextBox;
        private Button matchEditMatchButton;
        private Button detailsDeleteMisconductButton;
        private Button detailsDeleteGoalButton;
        private Button detailsDeleteSubstitutionButton;
        private Button button1;
        private Button button2;
    }
}