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
        private int currentGame;

        public VerJogos()
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

        private void VerJogos_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();

            Console.WriteLine("SAdasd");

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_MATCH", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                Jogo p = new Jogo();

                String Competition = reader["competition"].ToString();
                String Date = reader["date"].ToString();
                String Home_team = reader["home_team"].ToString();
                String Home_goals = reader["home_goals"].ToString();
                String Away_team = reader["away_team"].ToString();
                String Away_goals = reader["away_goals"].ToString();
                String Stadium = reader["stadium"].ToString();
                String Referee = reader["referee"].ToString();
                dataGridView1.Rows.Add(Competition,Date,Home_team,Home_goals,Away_team,Away_goals,Stadium,Referee);
            }

            cn.Close();

            currentGame = 0;
            //ShowGame();
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
            showGame();
        }

        public void showGame() {
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
