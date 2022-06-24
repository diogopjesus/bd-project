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
    public partial class AdicionarJogo : Form
    {
        private SqlConnection cn;
        public AdicionarJogo()
        {
            InitializeComponent();
        }
        private void VerCountry_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();


            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Comp.Items.Clear();

            while (reader.Read())
            {
                Competicao c = new Competicao();
                c.Name = reader["name"].ToString();
                Comp.Items.Add(c);
            }
            cn.Close();
            cmd = new SqlCommand("SELECT * FROM FD.REFEREE", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            Ref.Items.Clear();

            while (reader.Read())
            {
                Referee c = new Referee();
                c.Fname= reader["fname"].ToString();
                c.Lname = reader["lname"].ToString();
                Ref.Items.Add(c);
            }
            cn.Close();
            cmd = new SqlCommand("SELECT * FROM FD.TEAM", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            HT.Items.Clear();

            while (reader.Read())
            {
                Team c = new Team();
                c.Name = reader["name"].ToString();
                HT.Items.Add(c);
            }
            cn.Close();
            cmd = new SqlCommand("SELECT * FROM FD.TEAM", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            AT.Items.Clear();

            while (reader.Read())
            {
                Team c = new Team();
                c.Name = reader["name"].ToString();
                AT.Items.Add(c);
            }

            cn.Close();
            //ShowCompetition();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AdicionarJogo_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarAdicionarJogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
