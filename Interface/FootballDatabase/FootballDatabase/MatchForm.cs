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
    public partial class MatchForm : Form
    {
        private Match match;
        private int id;
        private SqlConnection cn;

        public MatchForm(int id)
        {
            InitializeComponent();
            this.id = id;
            this.cn = getSGBDConnection();
            this.match = new Match();

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

        private void MatchForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            textBox1.Text = match.Home_abv;
            textBox2.Text = match.Away_abv;
            textBox3.Text = match.Home_goals.ToString();
            textBox4.Text = match.Away_goals.ToString();
            lineupsHomeTeamNameTextBox.Text = match.Home_team;
            lineupsAwayTeamNameTextBox.Text = match.Away_team;

            // Add details
            DataSet ds = new DataSet();
            List<GameEvent> list = new List<GameEvent>();

            SqlCommand cmd = new SqlCommand("SPS_getGameDetails", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@game", match.Id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            // Cards
            DataTable dt = ds.Tables[0];
            foreach(DataRow row in dt.Rows)
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
            foreach(GameEvent ge in list)
            {
                listBox1.Items.Add(ge);
            }

            // Add lineups
            cmd = new SqlCommand("SELECT * FROM  UDF_getPlayerStatByGame(" + match.Id + ")", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            lineupsHomeDataGridView.Rows.Clear();
            lineupsAwayDataGridView.Rows.Clear();
            while(reader.Read())
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

                Object[] row = { p.Position_abv, ps };

                if(ps.Home_team)
                {
                    lineupsHomeDataGridView.Rows.Add(row);
                } else
                {
                    lineupsAwayDataGridView.Rows.Add(row);
                }
            }
            reader.Close();

            // Add team stat
            ds = new DataSet();
            cmd = new SqlCommand("SPS_getGameStats", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@game", match.Id);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            statsHomeTextBox.Text = match.Home_abv;
            statsAwayTextBox.Text = match.Away_abv;

            DataRow dr = ds.Tables[0].Rows[0];
            statsHomePossessionTextBox.Text = dr["ball_possesion"].ToString();
            statsHomeShotsTextBox.Text = dr["total_shots"].ToString();
            statsHomeOffsidesTextBox.Text = dr["offsides"].ToString();
            statsHomePassesTextBox.Text = dr["passes"].ToString();
            statsHomeTacklesTextBox.Text = dr["tackles"].ToString();
            statsHomeFoulsTextBox.Text = dr["fouls"].ToString();
            statsHomeCornersTextBox.Text = dr["corner_kicks"].ToString();

            dr = ds.Tables[1].Rows[0];
            statsAwayPossessionTextBox.Text = dr["ball_possesion"].ToString();
            statsAwayShotsTextBox.Text = dr["total_shots"].ToString();
            statsAwayOffsidesTextBox.Text = dr["offsides"].ToString();
            statsAwayPassesTextBox.Text = dr["passes"].ToString();
            statsAwayTacklesTextBox.Text = dr["tackles"].ToString();
            statsAwayFoulsTextBox.Text = dr["fouls"].ToString();
            statsAwayCornersTextBox.Text = dr["corner_kicks"].ToString();
        }

        private void tabDetails_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabLineups_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void matchEditMatchButton_Click(object sender, EventArgs e)
        {
            MatchEditForm form = new MatchEditForm(match.Id);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void lineupsHomeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //check if row index is not selected
            PlayerStat ps = (PlayerStat)this.lineupsHomeDataGridView[1, e.RowIndex].Value;

            PlayerStatForm form = new PlayerStatForm(match.Id, ps.Player_id);
            form.ShowDialog();
        }

        private void lineupsAwayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; //check if row index is not selected
            PlayerStat ps = (PlayerStat)this.lineupsAwayDataGridView[1, e.RowIndex].Value;

            PlayerStatForm form = new PlayerStatForm(match.Id, ps.Player_id);
            form.ShowDialog();
        }
    }
}
