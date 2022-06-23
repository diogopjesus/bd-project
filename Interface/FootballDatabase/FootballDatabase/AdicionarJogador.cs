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
    public partial class AdicionarJogador : Form
    {

        private SqlConnection cn;

        public AdicionarJogador()
        {
            InitializeComponent();
        }
        private void VerCountry_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            cn = getSGBDConnection();

            Console.WriteLine("SAdasd");

            SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COUNTRY", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Country.Items.Clear();

            while (reader.Read())
            {
                Country c = new Country();
                c.Name = reader["name"].ToString();
                c.Continent = reader["continent"].ToString();
                Country.Items.Add(c);
            }
            cn.Close();

            cmd = new SqlCommand("SELECT * FROM FD.FOOT", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            PrefFoot.Items.Clear();

            while (reader.Read())
            {
                Foot f = new Foot();
                f.Foots = reader["foot"].ToString();
                PrefFoot.Items.Add(f);
            }

            cn.Close();

            cmd = new SqlCommand("SELECT * FROM FD.POSITION", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            Position.Items.Clear();

            while (reader.Read())
            {
                Positions p = new Positions();
                p.Position = reader["position"].ToString();
                p.Abbreviation = reader["abbreviation"].ToString();
                Position.Items.Add(p);
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


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarJogar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
