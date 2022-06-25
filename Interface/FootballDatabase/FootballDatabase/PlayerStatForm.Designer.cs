namespace FootballDatabase
{
    partial class PlayerStatForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timePlayedTextBox = new System.Windows.Forms.TextBox();
            this.goalsTextBox = new System.Windows.Forms.TextBox();
            this.assistsTextBox = new System.Windows.Forms.TextBox();
            this.touchesTextBox = new System.Windows.Forms.TextBox();
            this.passesTextBox = new System.Windows.Forms.TextBox();
            this.shotsTextBox = new System.Windows.Forms.TextBox();
            this.tacklesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(220, 23);
            this.nameTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time Played";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Goals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assists";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Touches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Passes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Shots";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tackles";
            // 
            // timePlayedTextBox
            // 
            this.timePlayedTextBox.Location = new System.Drawing.Point(180, 43);
            this.timePlayedTextBox.Name = "timePlayedTextBox";
            this.timePlayedTextBox.ReadOnly = true;
            this.timePlayedTextBox.Size = new System.Drawing.Size(52, 23);
            this.timePlayedTextBox.TabIndex = 10;
            // 
            // goalsTextBox
            // 
            this.goalsTextBox.Location = new System.Drawing.Point(180, 68);
            this.goalsTextBox.Name = "goalsTextBox";
            this.goalsTextBox.ReadOnly = true;
            this.goalsTextBox.Size = new System.Drawing.Size(52, 23);
            this.goalsTextBox.TabIndex = 11;
            // 
            // assistsTextBox
            // 
            this.assistsTextBox.Location = new System.Drawing.Point(180, 93);
            this.assistsTextBox.Name = "assistsTextBox";
            this.assistsTextBox.ReadOnly = true;
            this.assistsTextBox.Size = new System.Drawing.Size(52, 23);
            this.assistsTextBox.TabIndex = 12;
            // 
            // touchesTextBox
            // 
            this.touchesTextBox.Location = new System.Drawing.Point(180, 118);
            this.touchesTextBox.Name = "touchesTextBox";
            this.touchesTextBox.ReadOnly = true;
            this.touchesTextBox.Size = new System.Drawing.Size(52, 23);
            this.touchesTextBox.TabIndex = 13;
            // 
            // passesTextBox
            // 
            this.passesTextBox.Location = new System.Drawing.Point(180, 143);
            this.passesTextBox.Name = "passesTextBox";
            this.passesTextBox.ReadOnly = true;
            this.passesTextBox.Size = new System.Drawing.Size(52, 23);
            this.passesTextBox.TabIndex = 14;
            // 
            // shotsTextBox
            // 
            this.shotsTextBox.Location = new System.Drawing.Point(180, 168);
            this.shotsTextBox.Name = "shotsTextBox";
            this.shotsTextBox.ReadOnly = true;
            this.shotsTextBox.Size = new System.Drawing.Size(52, 23);
            this.shotsTextBox.TabIndex = 15;
            // 
            // tacklesTextBox
            // 
            this.tacklesTextBox.Location = new System.Drawing.Point(180, 193);
            this.tacklesTextBox.Name = "tacklesTextBox";
            this.tacklesTextBox.ReadOnly = true;
            this.tacklesTextBox.Size = new System.Drawing.Size(52, 23);
            this.tacklesTextBox.TabIndex = 16;
            // 
            // PlayerStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 281);
            this.Controls.Add(this.tacklesTextBox);
            this.Controls.Add(this.shotsTextBox);
            this.Controls.Add(this.passesTextBox);
            this.Controls.Add(this.touchesTextBox);
            this.Controls.Add(this.assistsTextBox);
            this.Controls.Add(this.goalsTextBox);
            this.Controls.Add(this.timePlayedTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "PlayerStatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerStat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox timePlayedTextBox;
        private TextBox goalsTextBox;
        private TextBox assistsTextBox;
        private TextBox touchesTextBox;
        private TextBox passesTextBox;
        private TextBox shotsTextBox;
        private TextBox tacklesTextBox;
    }
}