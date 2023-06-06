namespace FootballDatabase
{
    partial class CompetitionForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMatches = new System.Windows.Forms.TabPage();
            this.matchesDataGridView = new System.Windows.Forms.DataGridView();
            this.matchesDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClassification = new System.Windows.Forms.TabPage();
            this.classificationDataGridView = new System.Windows.Forms.DataGridView();
            this.classificationPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationsDraws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationLosses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionNameTextBox = new System.Windows.Forms.TextBox();
            this.competitionDeleteButton = new System.Windows.Forms.Button();
            this.competitionEditButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabMatches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).BeginInit();
            this.tabClassification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classificationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMatches);
            this.tabControl.Controls.Add(this.tabClassification);
            this.tabControl.Location = new System.Drawing.Point(0, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(390, 459);
            this.tabControl.TabIndex = 0;
            // 
            // tabMatches
            // 
            this.tabMatches.Controls.Add(this.matchesDataGridView);
            this.tabMatches.Location = new System.Drawing.Point(4, 24);
            this.tabMatches.Name = "tabMatches";
            this.tabMatches.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatches.Size = new System.Drawing.Size(382, 431);
            this.tabMatches.TabIndex = 0;
            this.tabMatches.Text = "Matches";
            this.tabMatches.UseVisualStyleBackColor = true;
            // 
            // matchesDataGridView
            // 
            this.matchesDataGridView.AllowUserToAddRows = false;
            this.matchesDataGridView.AllowUserToDeleteRows = false;
            this.matchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchesDate,
            this.matchesMatch});
            this.matchesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.matchesDataGridView.Name = "matchesDataGridView";
            this.matchesDataGridView.ReadOnly = true;
            this.matchesDataGridView.RowHeadersVisible = false;
            this.matchesDataGridView.RowTemplate.Height = 25;
            this.matchesDataGridView.Size = new System.Drawing.Size(382, 431);
            this.matchesDataGridView.TabIndex = 0;
            // 
            // matchesDate
            // 
            this.matchesDate.HeaderText = "Date";
            this.matchesDate.MinimumWidth = 100;
            this.matchesDate.Name = "matchesDate";
            this.matchesDate.ReadOnly = true;
            // 
            // matchesMatch
            // 
            this.matchesMatch.HeaderText = "Match";
            this.matchesMatch.MinimumWidth = 278;
            this.matchesMatch.Name = "matchesMatch";
            this.matchesMatch.ReadOnly = true;
            this.matchesMatch.Width = 370;
            // 
            // tabClassification
            // 
            this.tabClassification.Controls.Add(this.classificationDataGridView);
            this.tabClassification.Location = new System.Drawing.Point(4, 24);
            this.tabClassification.Name = "tabClassification";
            this.tabClassification.Padding = new System.Windows.Forms.Padding(3);
            this.tabClassification.Size = new System.Drawing.Size(382, 431);
            this.tabClassification.TabIndex = 1;
            this.tabClassification.Text = "Classification";
            this.tabClassification.UseVisualStyleBackColor = true;
            // 
            // classificationDataGridView
            // 
            this.classificationDataGridView.AllowUserToAddRows = false;
            this.classificationDataGridView.AllowUserToDeleteRows = false;
            this.classificationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classificationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classificationPos,
            this.classificationName,
            this.classificationPoints,
            this.classificationWins,
            this.classificationsDraws,
            this.classificationLosses,
            this.classificationGS,
            this.classificationGC,
            this.classificationGD});
            this.classificationDataGridView.Location = new System.Drawing.Point(0, 0);
            this.classificationDataGridView.Name = "classificationDataGridView";
            this.classificationDataGridView.ReadOnly = true;
            this.classificationDataGridView.RowHeadersVisible = false;
            this.classificationDataGridView.RowTemplate.Height = 25;
            this.classificationDataGridView.Size = new System.Drawing.Size(382, 431);
            this.classificationDataGridView.TabIndex = 0;
            // 
            // classificationPos
            // 
            this.classificationPos.HeaderText = "Pos";
            this.classificationPos.MinimumWidth = 40;
            this.classificationPos.Name = "classificationPos";
            this.classificationPos.ReadOnly = true;
            this.classificationPos.Width = 40;
            // 
            // classificationName
            // 
            this.classificationName.HeaderText = "Name";
            this.classificationName.MinimumWidth = 198;
            this.classificationName.Name = "classificationName";
            this.classificationName.ReadOnly = true;
            this.classificationName.Width = 198;
            // 
            // classificationPoints
            // 
            this.classificationPoints.HeaderText = "Points";
            this.classificationPoints.MinimumWidth = 50;
            this.classificationPoints.Name = "classificationPoints";
            this.classificationPoints.ReadOnly = true;
            this.classificationPoints.Width = 50;
            // 
            // classificationWins
            // 
            this.classificationWins.HeaderText = "W";
            this.classificationWins.MinimumWidth = 30;
            this.classificationWins.Name = "classificationWins";
            this.classificationWins.ReadOnly = true;
            this.classificationWins.Width = 30;
            // 
            // classificationsDraws
            // 
            this.classificationsDraws.HeaderText = "D";
            this.classificationsDraws.MinimumWidth = 30;
            this.classificationsDraws.Name = "classificationsDraws";
            this.classificationsDraws.ReadOnly = true;
            this.classificationsDraws.Width = 30;
            // 
            // classificationLosses
            // 
            this.classificationLosses.HeaderText = "L";
            this.classificationLosses.MinimumWidth = 30;
            this.classificationLosses.Name = "classificationLosses";
            this.classificationLosses.ReadOnly = true;
            this.classificationLosses.Width = 30;
            // 
            // classificationGS
            // 
            this.classificationGS.HeaderText = "GS";
            this.classificationGS.MinimumWidth = 30;
            this.classificationGS.Name = "classificationGS";
            this.classificationGS.ReadOnly = true;
            this.classificationGS.Width = 30;
            // 
            // classificationGC
            // 
            this.classificationGC.HeaderText = "GC";
            this.classificationGC.MinimumWidth = 30;
            this.classificationGC.Name = "classificationGC";
            this.classificationGC.ReadOnly = true;
            this.classificationGC.Width = 30;
            // 
            // classificationGD
            // 
            this.classificationGD.HeaderText = "GD";
            this.classificationGD.MinimumWidth = 30;
            this.classificationGD.Name = "classificationGD";
            this.classificationGD.ReadOnly = true;
            this.classificationGD.Width = 30;
            // 
            // competitionNameTextBox
            // 
            this.competitionNameTextBox.Location = new System.Drawing.Point(4, 12);
            this.competitionNameTextBox.Name = "competitionNameTextBox";
            this.competitionNameTextBox.ReadOnly = true;
            this.competitionNameTextBox.Size = new System.Drawing.Size(382, 23);
            this.competitionNameTextBox.TabIndex = 1;
            // 
            // competitionDeleteButton
            // 
            this.competitionDeleteButton.Location = new System.Drawing.Point(4, 541);
            this.competitionDeleteButton.Name = "competitionDeleteButton";
            this.competitionDeleteButton.Size = new System.Drawing.Size(382, 28);
            this.competitionDeleteButton.TabIndex = 2;
            this.competitionDeleteButton.Text = "Delete Competition";
            this.competitionDeleteButton.UseVisualStyleBackColor = true;
            this.competitionDeleteButton.Click += new System.EventHandler(this.competitionDeleteButton_Click);
            // 
            // competitionEditButton
            // 
            this.competitionEditButton.Location = new System.Drawing.Point(4, 507);
            this.competitionEditButton.Name = "competitionEditButton";
            this.competitionEditButton.Size = new System.Drawing.Size(382, 28);
            this.competitionEditButton.TabIndex = 3;
            this.competitionEditButton.Text = "Edit Competition";
            this.competitionEditButton.UseVisualStyleBackColor = true;
            this.competitionEditButton.Click += new System.EventHandler(this.competitionEditButton_Click);
            // 
            // CompetitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 574);
            this.Controls.Add(this.competitionEditButton);
            this.Controls.Add(this.competitionDeleteButton);
            this.Controls.Add(this.competitionNameTextBox);
            this.Controls.Add(this.tabControl);
            this.Name = "CompetitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.CompetitionForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMatches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).EndInit();
            this.tabClassification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classificationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabMatches;
        private DataGridView matchesDataGridView;
        private TabPage tabClassification;
        private DataGridView classificationDataGridView;
        private DataGridViewTextBoxColumn classificationPos;
        private DataGridViewTextBoxColumn classificationName;
        private DataGridViewTextBoxColumn classificationPoints;
        private DataGridViewTextBoxColumn classificationGS;
        private DataGridViewTextBoxColumn classificationGC;
        private DataGridViewTextBoxColumn classificationGD;
        private TextBox competitionNameTextBox;
        private Button competitionDeleteButton;
        private Button competitionEditButton;
        private DataGridViewTextBoxColumn matchesDate;
        private DataGridViewTextBoxColumn matchesMatch;
        private DataGridViewTextBoxColumn classificationWins;
        private DataGridViewTextBoxColumn classificationsDraws;
        private DataGridViewTextBoxColumn classificationLosses;
    }
}