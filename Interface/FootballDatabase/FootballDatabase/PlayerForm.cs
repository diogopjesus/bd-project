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
    public partial class PlayerForm : Form
    {
        private int id;
        private SqlConnection cn;
        private Player player;
        private bool edit = false, add = false;

        public PlayerForm(int id)
        {
            InitializeComponent();
            this.cn = getSGBDConnection();
            this.id = id;
            this.player = new Player();

            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_PLAYER WHERE player_id='" + id + "'", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Player p = new Player();
                if (reader["team_id"] is System.DBNull || reader["team_id"] == null)
                {
                    p.Team_id = -1;
                    p.Team = "(No club)";
                }
                else
                {
                    p.Team_id = (int)reader["team_id"];
                    p.Team = (string)reader["team"];
                }
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
                this.player = p;
            }
            reader.Close();
        }

        public PlayerForm()
        {
            InitializeComponent();
            this.cn = getSGBDConnection();
            this.id = -1;
            this.player = new Player();
            enableEdit();
            add = true;
        }

        private void enableEdit()
        {
            edit = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            playerEditButton.Text = "Confirm";
            playerDeleteButton.Text = "Cancel";
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

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            // add country
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COUNTRY", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["name"];
                comboBox1.Items.Add(name);
            }
            reader.Close();

            cmd = new SqlCommand("SELECT * FROM FD.V_TEAM", cn);
            reader = cmd.ExecuteReader();
            comboBox2.Items.Clear();
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

                // add to players combo box
                comboBox2.Items.Add(t);
            }
            reader.Close();

            // Add position
            cmd = new SqlCommand("SELECT * FROM FD.POSITION", cn);
            reader = cmd.ExecuteReader();
            comboBox3.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["position"];
                comboBox3.Items.Add(name);
            }
            reader.Close();

            // Add position
            cmd = new SqlCommand("SELECT * FROM FD.FOOT", cn);
            reader = cmd.ExecuteReader();
            comboBox4.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["foot"];
                comboBox4.Items.Add(name);
            }
            reader.Close();

            if (this.id == -1) return;

            string[] name_parts = player.Name.Split(" ");
            textBox1.Text = name_parts[0];
            if (name_parts.Length > 2)
            {
                textBox2.Text = name_parts[1];
                textBox3.Text = name_parts[2];
            }
            else
            {
                textBox3.Text = name_parts[1];
            }
            dateTimePicker1.Text = player.Birth_date;
            comboBox1.Text = player.Country;
            comboBox2.Text = player.Team;
            comboBox3.Text = player.Position;
            comboBox4.Text = player.Preferred_foot;
            textBox4.Text = player.Height.ToString();
            textBox5.Text = player.Weight.ToString();
            textBox6.Text = player.Shirt_number.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void playerDeleteButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement DELETE
            if(!edit)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this player?", "Warning",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("SPS_deletePlayer", cn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@id", SqlDbType.Int).Value = player.Player_id;
                            cmd.ExecuteNonQuery();

                            string message = "Player Deleted Successfully!";
                            string caption = "Result";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            // Displays the MessageBox.
                            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        string message = "Failed to delete player in database. \n ERROR MESSAGE: \n" + ex.Message;
                        string caption = "Error";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void playerEditButton_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                enableEdit();
            }
            else if (add)
            {
                if (!verifySGBDConnection()) return;
                // add new player
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_modifyPlayer", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = DBNull.Value;
                        cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@minit", SqlDbType.VarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = textBox3.Text;
                        cmd.Parameters.Add("@birth_date", SqlDbType.Date).Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox1.Text;
                        if (comboBox2.SelectedItem == null)
                            cmd.Parameters.Add("@team", SqlDbType.Int).Value = DBNull.Value;
                        else
                            cmd.Parameters.Add("@team", SqlDbType.Int).Value = ((Team)comboBox2.SelectedItem).Id;
                        cmd.Parameters.Add("@position", SqlDbType.VarChar).Value = comboBox3.Text;
                        cmd.Parameters.Add("@preferred_foot", SqlDbType.VarChar).Value = comboBox4.Text;
                        cmd.Parameters.Add("@height", SqlDbType.Int).Value = textBox4.Text;
                        cmd.Parameters.Add("@weight", SqlDbType.Decimal).Value = textBox5.Text;
                        cmd.Parameters.Add("@shirt_number", SqlDbType.Int).Value = textBox6.Text;
                        cmd.ExecuteNonQuery();

                        string message = "Player Added Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to add contact in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
            else if (edit)
            {
                if (!verifySGBDConnection()) return;
                // add new player
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_modifyPlayer", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = player.Player_id;
                        cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@minit", SqlDbType.VarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@lname", SqlDbType.VarChar).Value = textBox3.Text;
                        cmd.Parameters.Add("@birth_date", SqlDbType.Date).Value = dateTimePicker1.Value;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox1.Text;
                        if (comboBox2.SelectedItem == null)
                            cmd.Parameters.Add("@team", SqlDbType.Int).Value = DBNull.Value;
                        else
                            cmd.Parameters.Add("@team", SqlDbType.Int).Value = ((Team)comboBox2.SelectedItem).Id;
                        cmd.Parameters.Add("@position", SqlDbType.VarChar).Value = comboBox3.Text;
                        cmd.Parameters.Add("@preferred_foot", SqlDbType.VarChar).Value = comboBox4.Text;
                        cmd.Parameters.Add("@height", SqlDbType.Int).Value = textBox4.Text;
                        cmd.Parameters.Add("@weight", SqlDbType.Decimal).Value = textBox5.Text;
                        cmd.Parameters.Add("@shirt_number", SqlDbType.Int).Value = textBox6.Text;
                        cmd.ExecuteNonQuery();

                        string message = "Player Updated Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to update player in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }

        }
    }
}
