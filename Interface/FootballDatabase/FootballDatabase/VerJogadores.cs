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
    public partial class VerJogadores : Form
    {
        private SqlConnection cn;
        private int currentPlayer;

        public VerJogadores()
        {
            InitializeComponent();
        }

        private void VerJogadores_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.V_PLAYER", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            listBox1.Items.Clear();

            while (reader.Read())
            {
                Player p = new Player();
                p.TeamID = reader["team_id"].ToString();
                p.Team = reader["team"].ToString();
                p.PlayerID = reader["player_id"].ToString();
                p.Name = reader["name"].ToString();
                p.Position = reader["position"].ToString();
                p.Position_abv = reader["position_abv"].ToString();
                p.Birth_date = reader["player_id"].ToString();
                p.Continent = reader["continent"].ToString();
                p.Country = reader["country"].ToString();
                p.Shirt_number = reader["shirt_number"].ToString();
                p.Preferred_foot = reader["preferred_foot"].ToString();
                p.Height = reader["height"].ToString();
                p.Weight = reader["weight"].ToString();
                listBox1.Items.Add(p);
            }

            cn.Close();

            currentPlayer = 0;
            ShowPlayer();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                currentPlayer = listBox1.SelectedIndex;
                ShowPlayer();
            }
        }

        public void ShowPlayer()
        {
            if (listBox1.Items.Count == 0 | currentPlayer < 0)
                return;
            Player player = new Player();
            player = (Player)listBox1.Items[currentPlayer];

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

        private void ProcurarEquipas_Click(object sender, EventArgs e)
        {
            ProcurarEquipas f = new ProcurarEquipas();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void AdicionarJogador_click(object sender, EventArgs e)
        {
            AdicionarJogador f = new AdicionarJogador();
            f.ShowDialog();
        }


    }
}
