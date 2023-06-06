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
    public partial class CompetitionForm : Form
    {
        private Competition comp;
        private int id;
        private SqlConnection cn;

        public CompetitionForm(int id)
        {
            InitializeComponent();
            this.id = id;
            this.cn = getSGBDConnection();
            this.comp = new Competition();

            if (!verifySGBDConnection()) return;
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION WHERE id='" + id + "'", cn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Competition c = new Competition();
                c.Id = (int)reader["id"];
                c.Name = (string)reader["name"];
                c.Type = (string)reader["type"];
                c.Continent = (string)reader["continent"];
                c.Country = (string)reader["country"];
                this.comp = c;
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

        private void CompetitionForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            competitionNameTextBox.Text = comp.Name;

            // Load matches
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_MATCH WHERE competition_id=" +comp.Id, cn);
            SqlDataReader reader = cmd.ExecuteReader();
            matchesDataGridView.Rows.Clear();
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
                
                Object[] row = { m.Date, m };
                matchesDataGridView.Rows.Add(row);
            }
            reader.Close();

            if (!(comp.Type.Equals("Domestic League") || comp.Type.Equals("International League")))
            {
                tabControl.TabPages.Remove(tabClassification);
                return;
            }

            cmd = new SqlCommand("SELECT * FROM FD.V_TEAM_IN_COMPETITION WHERE competition_id=" + comp.Id, cn);
            reader = cmd.ExecuteReader();
            classificationDataGridView.Rows.Clear();
            List<TeamInClass> list = new List<TeamInClass>();
            while (reader.Read())
            {
                TeamInClass tic = new TeamInClass();

                Team t = new Team();
                t.Id = (int)reader["team_id"];
                t.Abbreviation = (string)reader["abbreviation"];
                t.Name = (string)reader["name"];
                t.Continent = (string)reader["continent"];
                t.Country = (string)reader["country"];
                t.Stadium = (string)reader["stadium"];
                t.Attendance = (int)reader["attendance"];
                t.Coach = (string)reader["coach"];

                tic.Team = t;
                tic.Wins = (int)reader["wins"];
                tic.Draws = (int)reader["draws"];
                tic.Losses = (int)reader["losses"];
                tic.Points = (tic.Wins * 3) + (tic.Draws * 1);
                tic.Gs = (int)reader["goals_scored"];
                tic.Gc = (int)reader["goals_conceded"];
                tic.Gd = tic.Gs - tic.Gc;
                
                list.Add(tic);
            }
            reader.Close();

            list = list.OrderByDescending(tic => tic.Points).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                TeamInClass tic = list[i];
                Object[] row = { i+1, tic.Team, tic.Points, tic.Wins, tic.Draws, tic.Losses, tic.Gs, tic.Gc, tic.Gd };
                classificationDataGridView.Rows.Add(row);
            }

        }

        private void competitionEditButton_Click(object sender, EventArgs e)
        {
            CompetitionEditForm form = new CompetitionEditForm(comp.Id);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void competitionDeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this competition?", "Warning",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_deleteCompetition", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = comp.Id;
                        cmd.ExecuteNonQuery();

                        string message = "Competition Deleted Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to competition team in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
        }
    }
}
