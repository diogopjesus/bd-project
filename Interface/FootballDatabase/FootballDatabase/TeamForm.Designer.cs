namespace FootballDatabase
{
    partial class TeamForm
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
            this.teamEditButton = new System.Windows.Forms.Button();
            this.teamDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.abbreviationTextBox = new System.Windows.Forms.TextBox();
            this.stadiumComboBox = new System.Windows.Forms.ComboBox();
            this.coachComboBox = new System.Windows.Forms.ComboBox();
            this.lineupsHomeDataGridView = new System.Windows.Forms.DataGridView();
            this.homePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lineupsHomeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamEditButton
            // 
            this.teamEditButton.Location = new System.Drawing.Point(12, 505);
            this.teamEditButton.Name = "teamEditButton";
            this.teamEditButton.Size = new System.Drawing.Size(367, 28);
            this.teamEditButton.TabIndex = 5;
            this.teamEditButton.Text = "Edit Team";
            this.teamEditButton.UseVisualStyleBackColor = true;
            this.teamEditButton.Click += new System.EventHandler(this.teamEditButton_Click);
            // 
            // teamDeleteButton
            // 
            this.teamDeleteButton.Location = new System.Drawing.Point(12, 539);
            this.teamDeleteButton.Name = "teamDeleteButton";
            this.teamDeleteButton.Size = new System.Drawing.Size(367, 28);
            this.teamDeleteButton.TabIndex = 4;
            this.teamDeleteButton.Text = "Delete Team";
            this.teamDeleteButton.UseVisualStyleBackColor = true;
            this.teamDeleteButton.Click += new System.EventHandler(this.teamDeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Abbreviation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stadium";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Coach";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.Location = new System.Drawing.Point(75, 11);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.ReadOnly = true;
            this.teamNameTextBox.Size = new System.Drawing.Size(304, 23);
            this.teamNameTextBox.TabIndex = 13;
            this.teamNameTextBox.TextChanged += new System.EventHandler(this.teamNametextBox_TextChanged);
            // 
            // abbreviationTextBox
            // 
            this.abbreviationTextBox.Location = new System.Drawing.Point(133, 49);
            this.abbreviationTextBox.Name = "abbreviationTextBox";
            this.abbreviationTextBox.ReadOnly = true;
            this.abbreviationTextBox.Size = new System.Drawing.Size(56, 23);
            this.abbreviationTextBox.TabIndex = 14;
            // 
            // stadiumComboBox
            // 
            this.stadiumComboBox.Enabled = false;
            this.stadiumComboBox.FormattingEnabled = true;
            this.stadiumComboBox.Location = new System.Drawing.Point(87, 133);
            this.stadiumComboBox.Name = "stadiumComboBox";
            this.stadiumComboBox.Size = new System.Drawing.Size(292, 23);
            this.stadiumComboBox.TabIndex = 16;
            // 
            // coachComboBox
            // 
            this.coachComboBox.Enabled = false;
            this.coachComboBox.FormattingEnabled = true;
            this.coachComboBox.Location = new System.Drawing.Point(75, 175);
            this.coachComboBox.Name = "coachComboBox";
            this.coachComboBox.Size = new System.Drawing.Size(304, 23);
            this.coachComboBox.TabIndex = 17;
            // 
            // lineupsHomeDataGridView
            // 
            this.lineupsHomeDataGridView.AllowUserToAddRows = false;
            this.lineupsHomeDataGridView.AllowUserToDeleteRows = false;
            this.lineupsHomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lineupsHomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.homePosition,
            this.nameHome});
            this.lineupsHomeDataGridView.Location = new System.Drawing.Point(12, 211);
            this.lineupsHomeDataGridView.Name = "lineupsHomeDataGridView";
            this.lineupsHomeDataGridView.ReadOnly = true;
            this.lineupsHomeDataGridView.RowHeadersVisible = false;
            this.lineupsHomeDataGridView.RowTemplate.Height = 25;
            this.lineupsHomeDataGridView.Size = new System.Drawing.Size(367, 288);
            this.lineupsHomeDataGridView.TabIndex = 18;
            this.lineupsHomeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lineupsHomeDataGridView_CellContentClick);
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
            this.nameHome.MinimumWidth = 313;
            this.nameHome.Name = "nameHome";
            this.nameHome.ReadOnly = true;
            this.nameHome.Width = 313;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 574);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lineupsHomeDataGridView);
            this.Controls.Add(this.coachComboBox);
            this.Controls.Add(this.stadiumComboBox);
            this.Controls.Add(this.abbreviationTextBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamEditButton);
            this.Controls.Add(this.teamDeleteButton);
            this.Name = "TeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineupsHomeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button teamEditButton;
        private Button teamDeleteButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox teamNameTextBox;
        private TextBox abbreviationTextBox;
        private ComboBox stadiumComboBox;
        private ComboBox coachComboBox;
        private DataGridView lineupsHomeDataGridView;
        private DataGridViewTextBoxColumn homePosition;
        private DataGridViewTextBoxColumn nameHome;
        private ComboBox comboBox1;
    }
}