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
    public partial class InfoJogo : Form
    {
        private SqlConnection cn;

        public InfoJogo()
        {
            InitializeComponent();
        }

        private void InfoJogo_Load(object sender, EventArgs e)
        {
            cn = getSGBDConnection();

        }

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p2g6; uid = p1g7; password = VXze=^/VBx24XQsM");
        }

        private bool verifySGBDConnection()
        {
            if (cn == null)
                cn = getSGBDConnection();

            if (cn.State != ConnectionState.Open)
                cn.Open();

            return cn.State == ConnectionState.Open;
        }


        private void Voltar_click(object sender, EventArgs e)
        {
            VerJogos f = new VerJogos();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
