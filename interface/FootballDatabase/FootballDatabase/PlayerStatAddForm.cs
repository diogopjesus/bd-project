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
    public partial class PlayerStatAddForm : Form
    {
        private PlayerStat ge;
        private SqlConnection cn;
        private int hid, aid;
        private bool home = false;

        public PlayerStat Ge { get => ge; set => ge = value; }

        public PlayerStatAddForm(int hid, int aid)
        {
            InitializeComponent();
            this.hid = hid;
            this.aid = aid;
            ge = new PlayerStat();
            cn = getSGBDConnection();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            home = !home;
            if (home)
            {
                SqlCommand cmd = new SqlCommand("EXEC SPS_getPlayerByTeam " + hid, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
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

                    comboBox1.Items.Add(p);
                }
                reader.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("EXEC SPS_getPlayerByTeam " + aid, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
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

                    comboBox1.Items.Add(p);
                }
                reader.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void assistsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void shotsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tacklesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PlayerStatAddForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("EXEC SPS_getPlayerByTeam " + aid, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            comboBox1.Items.Clear();
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

                comboBox1.Items.Add(p);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ge = new PlayerStat();
                ge.Home_team = checkBox1.Checked;
                ge.Touches = int.Parse(textBox1.Text);
                ge.Passes = int.Parse(textBox2.Text);
                ge.Shots = int.Parse(textBox3.Text);
                ge.Tackles = int.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                string message = "Invalid values!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                ge.Touches = -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
