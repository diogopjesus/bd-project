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
    public partial class VerJogos : Form
    {

        private SqlConnection cn;
        SqlCommand cmd;
        public VerJogos()
        {
            InitializeComponent();
        }

        private void VerJogos_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();
        }


        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source=tcp:mednat.ieeta.ot\\SQLSERVER:8101; Initial Catalog = p1g7; uid = p1g7; password=VXze=^/VBx24XQsM");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
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

        private void ProcurarEquipas_Click(object sender, EventArgs e)
        {
            ProcurarEquipas f = new ProcurarEquipas();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdicionarJogo_Click(object sender, EventArgs e)
        {
            AdicionarJogo f = new AdicionarJogo();
            f.ShowDialog();
        }

        public void showGames() {
            cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT date,stadium,home_team,away_team FROM GAME";

            try {
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read()) {
                    GAME g = new GAME();
                    Data = reader["date"].ToString();
                    Stadium = reader["stadium"].ToString();
                    HomeTeam = reader["home_team"].ToString();
                    AwayTeam = reader["away_team"].ToString();

                }
            }

        }
    }
}
