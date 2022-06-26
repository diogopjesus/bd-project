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
    public partial class MatchEditForm : Form
    {
        private Match match;
        private int id;
        private SqlConnection cn;

        public MatchEditForm(int id)
        {
            InitializeComponent();
            this.id = id;
            this.match = new Match();
            this.cn = getSGBDConnection();

            if (!verifySGBDConnection()) return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_MATCH WHERE game_id='" + id + "'", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Match m = new Match();
                m.Id = (int)reader["game_id"];
                m.Competition = (string)reader["competition"];
                m.Date = ((DateTime)reader["date"]).ToString("yyyy-MM-dd");
                m.Home_id = (int)reader["home_id"];
                m.Home_team = (string)reader["home_team"];
                m.Home_abv = (string)reader["home_abv"];
                m.Home_goals = (int)reader["home_goals"];
                m.Away_id = (int)reader["away_id"];
                m.Away_team = (string)reader["away_team"];
                m.Away_abv = (string)reader["away_abv"];
                m.Away_goals = (int)reader["away_goals"];
                m.Stadium = (string)reader["stadium"];
                m.Referee = (string)reader["referee"];
                this.match = m;
            }
            reader.Close();
        }

        public MatchEditForm()
        {
            InitializeComponent();
            this.id = -1;
            this.match = new Match();
            this.cn = getSGBDConnection();
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

        private void MatchEditForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            if (this.id == -1)
            {
                // load stadiums
                SqlCommand cmd = new SqlCommand("SELECT * FROM FD.STADIUM", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboBox3.Items.Clear();
                while (reader.Read())
                {
                    Stadium s = new Stadium();
                    s.Id = (int)reader["id"];
                    s.Attendance = (int)reader["attendance"];
                    s.Name = (string)reader["name"];
                    s.Country = (string)reader["country"];

                    // add to players combo box
                    comboBox3.Items.Add(s);
                }
                reader.Close();

                // load competition
                cmd = new SqlCommand("SELECT * FROM FD.Competition", cn);
                reader = cmd.ExecuteReader();
                comboBox4.Items.Clear();
                while (reader.Read())
                {
                    Competition c = new Competition();
                    c.Id = (int)reader["id"];
                    c.Name = (string)reader["name"];
                    c.Type = (String)reader["type"];
                    c.Continent = (string)reader["continent"];
                    c.Country = (string)reader["country"];
                    comboBox4.Items.Add(c);
                }
                reader.Close();

                // load referee
                cmd = new SqlCommand("SELECT * FROM FD.REFEREE", cn);
                reader = cmd.ExecuteReader();
                comboBox5.Items.Clear();
                while (reader.Read())
                {
                    Referee r = new Referee();
                    r.Id = (int)reader["id"];

                    string s = "";
                    if (reader["minit"] is not System.DBNull)
                        s = (string)reader["minit"] + " ";
                    r.Name = (string)reader["fname"] + " " + s + (string)reader["lname"];

                    // add to players combo box
                    comboBox5.Items.Add(r);
                }
                reader.Close();
            }
            else
            {
                // load teams
                SqlCommand cmd = new SqlCommand("EXEC SPS_getCompetitionTeams " + match.Id, cn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                while (reader.Read())
                {
                    Team t = new Team();
                    t.Id = (int)reader["id"];
                    t.Abbreviation = (string)reader["abbreviation"];
                    t.Name = (string)reader["name"];
                    t.Continent = (string)reader["continent"];
                    t.Country = (string)reader["country"];
                    t.Stadium = (string)reader["stadium"];
                    t.Attendance = (int)reader["attendance"];
                    t.Coach = (string)reader["coach"];

                    // add to players combo box
                    comboBox1.Items.Add(t);
                    comboBox2.Items.Add(t);
                }
                reader.Close();

                comboBox1.Text = match.Home_team;
                comboBox2.Text= match.Away_team;
                
                textBox1.Text = match.Home_goals.ToString();
                textBox2.Text = match.Away_goals.ToString();

                dateTimePicker1.Text = match.Date;

                // load stadiums
                cmd = new SqlCommand("SELECT * FROM FD.STADIUM", cn);
                reader = cmd.ExecuteReader();
                comboBox3.Items.Clear();
                while (reader.Read())
                {
                    Stadium s = new Stadium();
                    s.Id = (int)reader["id"];
                    s.Attendance = (int)reader["attendance"];
                    s.Name = (string)reader["name"];
                    s.Country = (string)reader["country"];

                    // add to players combo box
                    comboBox3.Items.Add(s);
                }
                reader.Close();
                comboBox3.Text = match.Stadium;

                // load competition
                cmd = new SqlCommand("SELECT * FROM FD.Competition", cn);
                reader = cmd.ExecuteReader();
                comboBox4.Items.Clear();
                string country = "";
                while (reader.Read())
                {
                    Competition c = new Competition();
                    c.Id = (int)reader["id"];
                    c.Name = (string)reader["name"];
                    c.Type = (String)reader["type"];
                    c.Continent = (string)reader["continent"];
                    c.Country = (string)reader["country"];
                    if (c.Name.Equals(match.Competition))
                        country = c.Country;
                    comboBox4.Items.Add(c);
                }
                reader.Close();
                comboBox4.Text = country + " - " + match.Competition;

                // load referee
                cmd = new SqlCommand("SELECT * FROM FD.REFEREE", cn);
                reader = cmd.ExecuteReader();
                comboBox5.Items.Clear();
                while (reader.Read())
                {
                    Referee r = new Referee();
                    r.Id = (int)reader["id"];
                    
                    string s = "";
                    if (reader["minit"] is not System.DBNull)
                        s = (string)reader["minit"] + " ";
                    r.Name = (string)reader["fname"] + " " + s + (string)reader["lname"];

                    // add to players combo box
                    comboBox5.Items.Add(r);
                }
                reader.Close();
                comboBox5.Text = match.Referee;

                cmd = new SqlCommand("SELECT * FROM FD.TEAM_STAT WHERE game=" + match.Id + " ORDER BY home_team", cn);
                reader = cmd.ExecuteReader();

                reader.Read();
                textBox6.Text = reader["fouls"].ToString();
                textBox5.Text = reader["corner_kicks"].ToString();
                reader.Read();
                textBox3.Text = reader["fouls"].ToString();
                textBox4.Text = reader["corner_kicks"].ToString();
                

                reader.Close();

                // Add details
                DataSet ds = new DataSet();
                List<GameEvent> list = new List<GameEvent>();

                cmd = new SqlCommand("SPS_getGameDetails", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@game", match.Id);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                // Cards
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    GameEvent ge = new GameEvent();
                    ge.Type = GameEvent.Types.MISCONDUCT;
                    ge.Game = (int)row["game"];
                    ge.Gametime = (int)row["gametime"];
                    ge.Team = (string)row["team"];
                    ge.Player = (string)row["player"];
                    ge.Card = (string)row["card"];
                    list.Add(ge);
                }
                // Goals
                dt = ds.Tables[1];
                foreach (DataRow row in dt.Rows)
                {
                    GameEvent ge = new GameEvent();
                    ge.Type = GameEvent.Types.GOAL;
                    ge.Game = (int)row["game"];
                    ge.Gametime = (int)row["gametime"];
                    ge.Team = (string)row["team"];
                    ge.Scorer = (string)row["scorer"];
                    ge.Assistant = (string)row["assistant"];
                    list.Add(ge);
                }
                // Subs
                dt = ds.Tables[2];
                foreach (DataRow row in dt.Rows)
                {
                    GameEvent ge = new GameEvent();
                    ge.Type = GameEvent.Types.SUBSTITUTION;
                    ge.Game = (int)row["game"];
                    ge.Gametime = (int)row["gametime"];
                    ge.Team = (string)row["team"];
                    ge.Player_in = (string)row["player_in"];
                    ge.Player_out = (string)row["player_out"];
                    list.Add(ge);
                }
                // Add to feed
                list = list.OrderBy(ge => ge.Gametime).ToList();
                foreach (GameEvent ge in list)
                {
                    listBox1.Items.Add(ge);
                }

                // Add lineups
                cmd = new SqlCommand("SELECT * FROM  UDF_getPlayerStatByGame(" + match.Id + ")", cn);
                reader = cmd.ExecuteReader();
                listBox2.Items.Clear();
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

                    listBox2.Items.Add(ps);
                }
                reader.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int home_id = ((Team)comboBox1.SelectedItem).Id;
                int away_id = ((Team)comboBox2.SelectedItem).Id;
                PlayerStatAddForm form = new PlayerStatAddForm(home_id, away_id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    PlayerStat p = (PlayerStat)form.Ge;
                    if (p.Touches != -1)
                        listBox2.Items.Add(p);
                }
            }
            catch (Exception)
            {
                string message = "Teams should be selected first!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void detailsAddMisconductButton_Click(object sender, EventArgs e)
        {
            try
            {
                int home_id = ((Team)comboBox1.SelectedItem).Id;
                int away_id = ((Team)comboBox2.SelectedItem).Id;
                AddMisconductForm form = new AddMisconductForm(home_id, away_id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GameEvent ge = (GameEvent)form.Ge;
                    if (ge.Gametime != -1)
                        listBox1.Items.Add(ge);
                }
            }
            catch (Exception)
            {
                string message = "Teams should be selected first!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            
        }

        private void detailsAddSubstitutionButton_Click(object sender, EventArgs e)
        {
            try
            {
                int home_id = ((Team)comboBox1.SelectedItem).Id;
                int away_id = ((Team)comboBox2.SelectedItem).Id;
                AddSubstitutionForm form = new AddSubstitutionForm(home_id, away_id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GameEvent ge = (GameEvent)form.Ge;
                    if (ge.Gametime != -1)
                        listBox1.Items.Add(ge);
                }
            }
            catch (Exception)
            {
                string message = "Teams should be selected first!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void detailsAddGoalButton_Click(object sender, EventArgs e)
        {
            try
            {
                int home_id = ((Team)comboBox1.SelectedItem).Id;
                int away_id = ((Team)comboBox2.SelectedItem).Id;
                AddGoalForm form = new AddGoalForm(home_id, away_id);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    GameEvent ge = (GameEvent)form.Ge;
                    if (ge.Gametime != -1)
                        listBox1.Items.Add(ge);
                }
            }
            catch (Exception)
            {
                string message = "Teams should be selected first!";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            int compId = ((Competition)comboBox4.SelectedItem).Id;

            SqlCommand cmd = new SqlCommand("EXEC SPS_getCompetitionTeams " + compId , cn);
            SqlDataReader reader = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            while (reader.Read())
            {
                Team t = new Team();
                t.Id = (int)reader["id"];
                t.Abbreviation = (string)reader["abbreviation"];
                t.Name = (string)reader["name"];
                t.Continent = (string)reader["continent"];
                t.Country = (string)reader["country"];
                t.Stadium = (string)reader["stadium"];
                t.Attendance = (int)reader["attendance"];
                t.Coach = (string)reader["coach"];

                // add to players combo box
                comboBox1.Items.Add(t);
                comboBox2.Items.Add(t);
            }
            reader.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
