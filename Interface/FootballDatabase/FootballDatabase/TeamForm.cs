using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FootballDatabase
{
    public partial class TeamForm : Form
    {
        private int id;
        private SqlConnection cn;
        private Team team;
        private bool edit = false, add = false;

        public TeamForm(int id)
        {
            InitializeComponent();
            this.cn = getSGBDConnection();
            this.id = id;
            this.team = new Team();

            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_TEAM WHERE id='" + id + "'", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Team t = new Team();
                t.Id = (int)reader["id"];
                t.Abbreviation = (string)reader["abbreviation"];
                t.Name = (string)reader["name"];
                t.Continent = (string)reader["continent"];
                t.Country = (string)reader["country"];
                if (reader["stadium"] == DBNull.Value)
                    t.Stadium = "";
                else
                    t.Stadium = (string)reader["stadium"];
                if (reader["attendance"] == DBNull.Value)
                    t.Attendance = -1;
                else
                    t.Attendance = (int)reader["attendance"];
                if (reader["coach"] == DBNull.Value)
                    t.Coach = "";
                else
                    t.Coach = (string)reader["coach"];
                team = t;
            }
            reader.Close();
        }

        public TeamForm()
        {
            InitializeComponent();
            this.cn = getSGBDConnection();
            this.id = -1;
            this.team = new Team();
            enableEdit();
            add = true;
        }

        private void enableEdit()
        {
            this.edit = true;
            teamNameTextBox.ReadOnly = false;
            abbreviationTextBox.ReadOnly = false;
            comboBox1.Enabled = true;
            coachComboBox.Enabled = true;
            stadiumComboBox.Enabled = true;
            teamEditButton.Text = "Confirm";
            teamDeleteButton.Text = "Cancel";
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p1g7; uid = p1g7; password = VXze=^/VBx24XQsM;TrustServerCertificate=True");
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            // load stadiums
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.STADIUM", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            stadiumComboBox.Items.Clear();
            while (reader.Read())
            {
                Stadium s = new Stadium();
                s.Id = (int)reader["id"];
                s.Attendance = (int)reader["attendance"];
                s.Name = (string)reader["name"];
                s.Country = (string)reader["country"];

                // add to players combo box
                stadiumComboBox.Items.Add(s);
            }
            reader.Close();

            // add country
            cmd = new SqlCommand("SELECT * FROM FD.COUNTRY", cn);
            reader = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["name"];
                comboBox1.Items.Add(name);
            }
            reader.Close();

            cmd = new SqlCommand("SELECT * FROM FD.COACH", cn);
            reader = cmd.ExecuteReader();
            coachComboBox.Items.Clear();
            while (reader.Read())
            {
                Coach c = new Coach();
                c.Id = (int)reader["id"];
                string s = "";
                if (reader["minit"] is not System.DBNull)
                    s = (string)reader["minit"] + " ";
                c.Name = (string)reader["fname"] + " " + s + (string)reader["lname"];
                c.Birth_date = ((DateTime)reader["birth_date"]).ToString("yyyy-MM-dd");
                c.Country = (string)reader["country"];

                // add to coach combo box
                coachComboBox.Items.Add(c);
            }
            reader.Close();

            if (this.id != -1)
            {
                teamNameTextBox.Text = team.Name;
                abbreviationTextBox.Text = team.Abbreviation;
                teamNameTextBox.Text = team.Name;
                stadiumComboBox.Text = team.Stadium;
                coachComboBox.Text = team.Coach;
                comboBox1.Text = team.Country;

                cmd = new SqlCommand("SELECT * FROM FD.V_PLAYER WHERE team_id=" + team.Id, cn);
                reader = cmd.ExecuteReader();
                lineupsHomeDataGridView.Rows.Clear();
                while (reader.Read())
                {
                    Player p = new Player();
                    p.Team_id = (int)reader["team_id"];
                    p.Team = (string)reader["team"];
                    p.Player_id = (int)reader["player_id"];
                    p.Name = (string)reader["name"];
                    p.Position = (string)reader["position"];
                    p.Position_abv = (string)reader["position_abv"];
                    p.Birth_date = ((DateTime)reader["birth_date"]).ToString("yyyy-MM-dd");
                    p.Continent = (string)reader["continent"];
                    p.Country = (string)reader["country"];
                    p.Shirt_number = (int)reader["shirt_number"];
                    p.Preferred_foot = (string)reader["preferred_foot"];
                    p.Height = (int)reader["height"];
                    p.Weight = (decimal)reader["weight"];

                    Object[] row = { p.Position_abv, p };
                    lineupsHomeDataGridView.Rows.Add(row);
                }
                reader.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lineupsHomeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //check if row index is not selected
            Player p = (Player)this.lineupsHomeDataGridView[1, e.RowIndex].Value;

            this.Hide();
            PlayerForm form = new PlayerForm(p.Player_id);
            form.ShowDialog();
            this.Show();
        }

        private void teamDeleteButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement DELETE
            if(!edit)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this team?", "Warning",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("SPS_deleteTeam", cn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = team.Id;
                            cmd.ExecuteNonQuery();

                            string message = "Team Deleted Successfully!";
                            string caption = "Result";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            // Displays the MessageBox.
                            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string message = "Failed to delete team in database. \n ERROR MESSAGE: \n" + ex.Message;
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    }
                }
            } else
            {
                this.Close();
            }
        }


        private void teamNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamEditButton_Click(object sender, EventArgs e)
        {
            if(!edit)
            {
                enableEdit();
            }
            else if(add)
            {
                if (!verifySGBDConnection()) return;
                // add new team
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_modifyTeam", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = DBNull.Value;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = teamNameTextBox.Text;
                        cmd.Parameters.Add("@abbreviation", SqlDbType.VarChar).Value = abbreviationTextBox.Text;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox1.Text;
                        if (stadiumComboBox.SelectedItem != null)
                            cmd.Parameters.Add("@stadium", SqlDbType.VarChar).Value = ((Stadium)stadiumComboBox.SelectedItem).Id;
                        else
                            cmd.Parameters.Add("@stadium", SqlDbType.VarChar).Value = DBNull.Value;
                        if (coachComboBox.SelectedItem != null)
                            cmd.Parameters.Add("@coach", SqlDbType.VarChar).Value = ((Coach)coachComboBox.SelectedItem).Id;
                        else
                            cmd.Parameters.Add("@coach", SqlDbType.VarChar).Value = DBNull.Value;

                        cmd.ExecuteNonQuery();

                        string message = "Team Added Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to add team in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
            else if (edit)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_modifyTeam", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = team.Id;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = teamNameTextBox.Text;
                        cmd.Parameters.Add("@abbreviation", SqlDbType.VarChar).Value = abbreviationTextBox.Text;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox1.Text;
                        if (stadiumComboBox.SelectedItem != null)
                            cmd.Parameters.Add("@stadium", SqlDbType.VarChar).Value = ((Stadium)stadiumComboBox.SelectedItem).Id;
                        else
                            cmd.Parameters.Add("@stadium", SqlDbType.VarChar).Value = DBNull.Value;
                        if (coachComboBox.SelectedItem != null)
                            cmd.Parameters.Add("@coach", SqlDbType.VarChar).Value = ((Coach)coachComboBox.SelectedItem).Id;
                        else
                            cmd.Parameters.Add("@coach", SqlDbType.VarChar).Value = DBNull.Value;
                        cmd.ExecuteNonQuery();

                        string message = "Team Updated Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to update team in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
        }
    }
}
