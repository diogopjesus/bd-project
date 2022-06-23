using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FootballDatabase
{
    public partial class ProcurarEquipas : Form
    {
        private SqlConnection cn;
        private Team currentTeam;

        public ProcurarEquipas()
        {
            InitializeComponent();
        }
        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p1g7; uid = p1g7; password = VXze=^/VBx24XQsM;");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }

        private void VerJogos_Click(object sender, EventArgs e)
        {
            VerJogos f = new VerJogos();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void ProcurarCampeonato_Click(object sender, EventArgs e)
        {
            ProcurarCampeonato f = new ProcurarCampeonato();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void VerJogadores_Click(object sender, EventArgs e)
        {
            VerJogadores f = new VerJogadores();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void ProcurarEquipas_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_TEAM", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (reader.Read())
            {
                Team t = new Team();
                t.Id = reader["id"].ToString();
                t.Abbreviation = reader["abbreviation"].ToString();
                t.Name = reader["name"].ToString();
                t.Continent = reader["continent"].ToString();
                t.Country = reader["Country"].ToString();
                t.Stadium = reader["stadium"].ToString();
                t.Attendance = reader["attendance"].ToString();
                t.Coach = reader["coach"].ToString();
                comboBox1.Items.Add(t);
            }

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.BackgroundColor = Color.White;
            dataGridView3.RowHeadersVisible = false;
        }

        private void AdicionarEquipa_Click(object sender, EventArgs e)
        {
            AdicionarEquipa f = new AdicionarEquipa();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;

            currentTeam = (Team)cmb.SelectedItem;

            if (currentTeam != null)
            {
                populateTeamDataGridView(currentTeam);
            }

        }

        private void populateTeamDataGridView(Team team)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string[] row = { team.Abbreviation, team.Name, team.Continent, team.Country, team.Stadium, team.Attendance, team.Coach };
            dataGridView1.Rows.Add(row);

            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_PLAYER WHERE team_id="+team.Id, cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView2.Rows.Clear();
            while(reader.Read())
            {
                String[] r = {(String)reader["name"], (String)reader["position"], (String)reader["country"]};
                dataGridView2.Rows.Add(r);
            }
            cn.Close();
            cn.Open();
            cmd = new SqlCommand("exec GetTeamGames " + team.Id, cn);
            reader = cmd.ExecuteReader();
            dataGridView3.Rows.Clear();
            while (reader.Read())
            {
                String[] r = { (String)reader["competition"], ((DateTime)reader["date"]).ToString("yyyy-MM-dd"), (String)reader["home_team"], (String)reader["away_team"], reader["home_goals"] + "-" + reader["away_goals"] };
                dataGridView3.Rows.Add(r);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
