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
    public partial class PlayerStatForm : Form
    {
        private int gid;
        private int pid;
        private SqlConnection cn;
        private PlayerStat ps;

        public PlayerStatForm(int gid, int pid)
        {
            InitializeComponent();
            this.gid = gid;
            this.pid = pid;
            this.cn = getSGBDConnection();
            this.ps = new PlayerStat();

            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM  UDF_getPlayerStatByGame(" + gid + ") WHERE player=" + pid, cn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PlayerStat ps = new PlayerStat();
                ps.Game = (int)reader["game"];
                ps.Player_id = (int)reader["player"];
                ps.Time_played = (int)reader["time_played"];
                ps.Goals = (int)reader["goals"];
                ps.Assists = (int)reader["assists"];
                ps.Touches = (int)reader["touches"];
                ps.Passes = (int)reader["passes"];
                ps.Shots = (int)reader["shots"];
                ps.Tackles = (int)reader["tackles"];
                ps.Home_team = (bool)reader["home_team"];
                ps.Starter = (bool)reader["starter"];

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

                ps.Player = p;
                this.ps = ps;
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

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p1g7; uid = p1g7; password = VXze=^/VBx24XQsM;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enableEdit();
        }

        private void enableEdit()
        {
            touchesTextBox.ReadOnly = false;
            passesTextBox.ReadOnly = false;
            shotsTextBox.ReadOnly = false;
            tacklesTextBox.ReadOnly = false;
            button1.Text = "Confirm";
            button2.Text = "Cancel";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayerStatForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = ps.Player.Name;
            timePlayedTextBox.Text = ps.Time_played.ToString();
            goalsTextBox.Text = ps.Goals.ToString();
            assistsTextBox.Text = ps.Assists.ToString();
            touchesTextBox.Text = ps.Touches.ToString();
            passesTextBox.Text = ps.Passes.ToString();
            shotsTextBox.Text = ps.Shots.ToString();
            tacklesTextBox.Text = ps.Tackles.ToString();
        }

        private void timePlayedTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void goalsTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
