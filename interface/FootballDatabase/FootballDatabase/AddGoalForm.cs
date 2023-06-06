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
    public partial class AddGoalForm : Form
    {
        private GameEvent ge;
        private SqlConnection cn;
        private int hid, aid;
        private bool home = false;

        public GameEvent Ge { get => ge; set => ge = value; }

        public AddGoalForm(int hid, int aid)
        {
            InitializeComponent();
            this.hid = hid;
            this.aid = aid;
            ge = new GameEvent();
            cn = getSGBDConnection();
        }

        private void AddGoalForm_Load(object sender, EventArgs e)
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
                comboBox2.Items.Add(p);
            }
            reader.Close();
        }


        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            home = !home;

            if (home)
            {
                if (!verifySGBDConnection()) return;

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
                    comboBox2.Items.Add(p);
                }
                reader.Close();
            }
            else
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
                    comboBox2.Items.Add(p);
                }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ge = new GameEvent();
                ge.Type = GameEvent.Types.GOAL;
                ge.Team_id = home ? hid : aid;
                ge.Scorer_obj = (Player)comboBox1.SelectedItem;
                ge.Assistant_obj = (Player)comboBox2.SelectedItem;
                ge.Gametime = int.Parse(textBox1.Text);
                ge.Home_team = checkBox1.Checked;
            }
            catch (Exception)
            {
                string message = "Invalid values!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
                ge.Gametime = -1;
            }
        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p1g7; uid = p1g7; password = VXze=^/VBx24XQsM;TrustServerCertificate=True");
        }
    }
}
