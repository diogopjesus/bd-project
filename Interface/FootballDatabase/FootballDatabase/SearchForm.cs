using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace FootballDatabase
{
    public partial class SearchForm : Form
    {
        private SqlConnection cn;

        public SearchForm()
        {
            InitializeComponent();
            competitionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            cn = getSGBDConnection();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            // Load matches
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_MATCH", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while(reader.Read())
            {
                Match m = new Match();
                m.Id = (int)reader["game_id"];
                m.Competition = (string)reader["competition"];
                m.Date = ((DateTime)reader["date"]).ToString("yyyy-MM-dd");
                m.Home_id = (int)reader["home_id"];
                m.Home_team = (string)reader["home_team"];
                m.Home_goals = (int)reader["home_goals"];
                m.Away_id = (int)reader["away_id"];
                m.Away_team = (string)reader["away_team"];
                m.Away_goals = (int)reader["away_goals"];
                m.Stadium = (string)reader["stadium"];
                m.Referee = (string)reader["referee"];

                Object[] row = { m.Id, m.Competition, m.Home_team, m.Home_goals, m.Away_goals, m.Away_team };
                dataGridView1.Rows.Add(row);
            }
            reader.Close();

            // load competitions (on tab and matchesComboBox)
            cmd = new SqlCommand("SELECT * FROM FD.COMPETITION", cn);
            reader = cmd.ExecuteReader();
            matchesCompetitionComboBox.Items.Clear();
            while(reader.Read())
            {
                Competition c = new Competition();
                c.Id = (int)reader["id"];
                c.Name = (string)reader["name"];
                c.Continent = (string)reader["continent"];
                c.Country = (string)reader["country"];

                // add to matches combo box
                matchesCompetitionComboBox.Items.Add(c);
                teamsCompetitionComboBox.Items.Add(c);
                playersCompetitionComboBox.Items.Add(c);

                // add to tab
                Object[] row = { c.Id, c.Country, c.Name };
                competitionsDataGridView.Rows.Add(row);
            }
            reader.Close();

            // add competition type to competitions tab
            cmd = new SqlCommand("SELECT * FROM FD.COMPETITION_TYPE", cn);
            reader = cmd.ExecuteReader();
            competitionsCompetitionTypeComboBox.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["name"];

                // add to matches combo box
                competitionsCompetitionTypeComboBox.Items.Add(name);
            }
            reader.Close();

            // add continent (on competitions tab)
            cmd = new SqlCommand("SELECT * FROM FD.CONTINENT", cn);
            reader = cmd.ExecuteReader();
            competitionsContinentComboBox.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["name"];

                // add to matches combo box
                competitionsContinentComboBox.Items.Add(name);
            }
            reader.Close();

            // add country (on competitions, players and teams tab)
            cmd = new SqlCommand("SELECT * FROM FD.COUNTRY", cn);
            reader = cmd.ExecuteReader();
            competitionsCountryComboBox.Items.Clear();
            teamsCountryComboBox.Items.Clear();
            playersCountryComboBox.Items.Clear();
            while (reader.Read())
            {
                string name = (string)reader["name"];

                // add to matches combo box
                competitionsCountryComboBox.Items.Add(name);
                teamsCountryComboBox.Items.Add(name);
                playersCountryComboBox.Items.Add(name);
            }
            reader.Close();

            // load teams
            cmd = new SqlCommand("SELECT * FROM FD.V_TEAM", cn);
            reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
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
                playersTeamComboBox.Items.Add(t);

                Object[] row = { t.Country, t.Abbreviation, t.Name };
                dataGridView2.Rows.Add(row);
            }
            reader.Close();

            cmd = new SqlCommand("SELECT * FROM FD.V_PLAYER", cn);
            reader = cmd.ExecuteReader();
            dataGridView3.Rows.Clear();
            while(reader.Read())
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

                object[] row = { p.Team, p.Position_abv, p.Name };
                dataGridView3.Rows.Add(row);
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void matchesAddButton_Click(object sender, EventArgs e)
        {
            MatchEditForm form = new MatchEditForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void competitionsAddButton_Click(object sender, EventArgs e)
        {
            CompetitionEditForm form = new CompetitionEditForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void teamsAddButton_Click(object sender, EventArgs e)
        {
            TeamForm form = new TeamForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void playersAddButton_Click(object sender, EventArgs e)
        {
            PlayerForm form = new PlayerForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void matchesSearchButton_Click(object sender, EventArgs e)
        {
            string search_text = ((TextBox)matchesSearchText).Text;
            ComboBox compbox = (ComboBox)matchesCompetitionComboBox;
            Competition competition = (Competition)compbox.SelectedItem;
            string date = ((DateTimePicker)matchesDateTimePicker).Value.ToString("yyyy-MM-dd"); ;

            if (!verifySGBDConnection())
                return;

            // Load matches
            string query = "1=1";
            if (!search_text.Equals(""))
            {
                query += " AND (home_team LIKE '%" + search_text + "%' OR away_team LIKE '%" + search_text + "%')";
            }
            if (competition != null)
            {
                query += " AND competition='" + competition.Name + "'";
            }
            if (!(date == DateTime.Now.ToString("yyyy-MM-dd")))
            {
                query += " AND date='" + date + "'";
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_MATCH WHERE " + query , cn);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                Match m = new Match();
                m.Id = (int)reader["game_id"];
                m.Competition = (string)reader["competition"];
                m.Date = (string)reader["date"];
                m.Home_id = (int)reader["home_id"];
                m.Home_team = (string)reader["home_team"];
                m.Home_goals = (int)reader["home_goals"];
                m.Away_id = (int)reader["away_id"];
                m.Away_team = (string)reader["away_team"];
                m.Away_goals = (int)reader["away_goals"];
                m.Stadium = (string)reader["stadium"];
                m.Referee = (string)reader["referee"];

                Object[] row = { m.Id, m.Competition, m.Home_team, m.Home_goals, m.Away_goals, m.Away_team };
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void matchesSearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void competitionsCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void competitionsContinentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            ComboBox compbox = (ComboBox)competitionsContinentComboBox;
            string continent = (string)compbox.SelectedItem;

            string query = " (1=1)";
            if (continent != null)
            {
                query += " AND continent='" + continent + "'";
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COUNTRY WHERE" + query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            competitionsCountryComboBox.Items.Clear();
            competitionsCountryComboBox.Text = "Country";
            while (reader.Read())
            {
                string name = (string)reader["name"];

                // add to matches combo box
                competitionsCountryComboBox.Items.Add(name);
            }
            reader.Close();
        }

        private void competitionsSearchButton_Click(object sender, EventArgs e)
        {
            string search_text = ((TextBox)competitionsSearchText).Text;
            string competition_type = (string)competitionsCompetitionTypeComboBox.SelectedItem;
            ComboBox compbox = (ComboBox)competitionsContinentComboBox;
            string continent = (string)compbox.SelectedItem;
            string country = (string)competitionsCountryComboBox.SelectedItem;

            if (!verifySGBDConnection())
                return;

            string query = " (1=1)";
            if (!search_text.Equals(""))
            {
                query += " AND name LIKE '%" + search_text + "%'";
            }
            if (competition_type != null)
            {
                query += " AND type='" + competition_type + "'";
            }
            if (country != null)
            {
                query += " AND country='" + country + "'";
            }
            if (continent != null)
            {
                query += " AND continent='" + continent + "'";
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION WHERE " + query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            competitionsDataGridView.Rows.Clear();
            while(reader.Read())
            {
                Competition c = new Competition();
                c.Id = (int)reader["id"];
                c.Name = (string)reader["name"];
                c.Continent = (string)reader["continent"];
                c.Country = (string)reader["country"];

                // add to tab
                Object[] row = { c.Id, c.Country, c.Name };
                competitionsDataGridView.Rows.Add(row);
            }
            reader.Close();
        }

        private void matchesCompetitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teamsSearchButton_Click(object sender, EventArgs e)
        {
            string search_text = ((TextBox)teamsSearchText).Text;
            Competition competition = (Competition)teamsCompetitionComboBox.SelectedItem;
            string country = (string)teamsCountryComboBox.SelectedItem;

            if (!verifySGBDConnection())
                return;

            string query = " (1=1)";
            if (!search_text.Equals(""))
            {
                query += " AND name LIKE '%" + search_text + "%'";
            }
            if(competition != null)
            {
                query += " AND id IN (SELECT team FROM FD.TEAM_PLAYS_COMPETITION WHERE competition='" + competition.Id + "')";
            }
            if(country != null)
            {
                query += " AND country='" + country + "'";
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_TEAM WHERE " + query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
            while(reader.Read())
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

                Object[] row = { t.Country, t.Abbreviation, t };
                dataGridView2.Rows.Add(row);
            }
            reader.Close();
        }

        private void teamsCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            ComboBox compbox = (ComboBox)teamsCountryComboBox;
            string country = (string)compbox.SelectedItem;

            string query = " (1=1)";
            if (country == null) return;
            query += " AND country='" + country + "'";

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION WHERE" + query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            teamsCompetitionComboBox.Items.Clear();
            teamsCompetitionComboBox.Text = "Competition";
            while (reader.Read())
            {
                Competition c = new Competition();
                c.Id = (int)reader["id"];
                c.Name = (string)reader["name"];
                c.Continent = (string)reader["continent"];
                c.Country = (string)reader["country"];

                // add to tab
                teamsCompetitionComboBox.Items.Add(c);
            }
            reader.Close();
        }

        private void playersCountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void playersCompetitionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            ComboBox compbox = (ComboBox)playersCompetitionComboBox;
            Competition competition = (Competition)compbox.SelectedItem;

            string query = " (1=1)";
            if (competition == null) return;
            query += "AND id IN(SELECT team FROM FD.TEAM_PLAYS_COMPETITION WHERE competition= '" + competition.Id + "')";

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_TEAM WHERE" + query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            playersTeamComboBox.Items.Clear();
            playersTeamComboBox.Text = "Team";
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

                // add to tab
                playersTeamComboBox.Items.Add(t);
            }
            reader.Close();
        }

        private void playersSearchButton_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            string search_text = ((TextBox)playersSearchText).Text;
            ComboBox compbox = (ComboBox)playersCountryComboBox;
            string country = (string)compbox.SelectedItem;
            Competition competition = (Competition)playersCompetitionComboBox.SelectedItem;
            Team team = (Team)playersTeamComboBox.SelectedItem;

            string query = " (1=1)";
            if (!search_text.Equals(""))
            {
                query += " AND name LIKE '%" + search_text + "%'";
            }
            if (country != null)
            {
                query += " AND country='" + country + "'";
            }
            if (competition != null)
            {
                query += " AND team_id IN(SELECT team FROM FD.TEAM_PLAYS_COMPETITION WHERE competition= '" + competition.Id + "')";
            }
            if (team != null)
            {
                query += " AND team_id='" + team.Id + "'";
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_PLAYER WHERE" + query, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView3.Rows.Clear();
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

                object[] row = { p.Team, p.Position_abv, p };
                dataGridView3.Rows.Add(row);
            }
            reader.Close();
        }
    }
}