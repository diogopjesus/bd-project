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
    public partial class ProcurarCampeonato : Form
    {

        private SqlConnection cn;
        private int currentCompetition;

        public ProcurarCampeonato()
        {
            InitializeComponent();
        }
        private void VerJogadores_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();

            Console.WriteLine("SAdasd");

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                String Name = reader["name"].ToString();
                String Type = reader["type"].ToString();
                String Continent = reader["continent"].ToString();
                String Country = reader["country"].ToString();
                dataGridView1.Rows.Add(Name, Type, Continent, Country);
            }

            cn.Close();

            currentCompetition = 0;
            //ShowCompetition();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void AdicionarCampeonato_Click(object sender, EventArgs e)
        {
            AdicionarCampeonato f = new AdicionarCampeonato();
            f.ShowDialog();
        }
    }
}
