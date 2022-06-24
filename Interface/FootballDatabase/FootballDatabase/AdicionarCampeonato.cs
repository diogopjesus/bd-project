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
    public partial class AdicionarCampeonato : Form
    {

        private SqlConnection cn;
        private int currentCompetition;

        public AdicionarCampeonato()
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
            comboBox2.Items.Clear();

            while (reader.Read())
            {
                Country c = new Country();
                c.Name = reader["name"].ToString();
                c.Continent = reader["continent"].ToString();
                comboBox3.Items.Add(c);
            }
            cn.Close();

            cmd = new SqlCommand("SELECT * FROM FD.CONTINENT", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            comboBox2.Items.Clear();

            while (reader.Read())
            {
                Continente c = new Continente();
                c.Name = reader["name"].ToString();
                comboBox2.Items.Add(c);
            }

            cn.Close();
            cmd = new SqlCommand("SELECT * FROM FD.COMPETITION_TYPE", cn);
            cn.Open();
            reader = cmd.ExecuteReader();

            compType.Items.Clear();

            while (reader.Read())
            {
                CompType c = new CompType();
                c.Name = reader["name"].ToString();
                compType.Items.Add(c);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void confirmar_click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
