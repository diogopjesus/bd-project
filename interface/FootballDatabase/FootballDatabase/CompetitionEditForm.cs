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
    public partial class CompetitionEditForm : Form
    {
        private Competition comp;
        private int id;
        private SqlConnection cn;
        private bool add = false;

        public CompetitionEditForm(int id)
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

        public CompetitionEditForm()
        {
            InitializeComponent();
            this.id = -1;
            this.cn = getSGBDConnection();
            this.comp = new Competition();
            this.add = true;
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
            return new SqlConnection("data source= tcp:mednat.ieeta.pt\\SQLSERVER,8101;Initial Catalog=p1g7; uid = p1g7; password = VXze=^/VBx24XQsM;TrustServerCertificate=True");
        }

        private void CompetitionEditForm_Load(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            if (id == -1)
            {
                // add competition type
                SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION_TYPE", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    string name = (string)reader["name"];
                    comboBox1.Items.Add(name);
                }
                reader.Close();

                // add continent (on competitions tab)
                cmd = new SqlCommand("SELECT * FROM FD.CONTINENT", cn);
                reader = cmd.ExecuteReader();
                comboBox2.Items.Clear();
                while (reader.Read())
                {
                    string name = (string)reader["name"];

                    // add to matches combo box
                    comboBox2.Items.Add(name);
                }
                reader.Close();

                // add country (on competitions, players and teams tab)
                cmd = new SqlCommand("SELECT * FROM FD.COUNTRY", cn);
                reader = cmd.ExecuteReader();
                comboBox3.Items.Clear();
                while (reader.Read())
                {
                    string name = (string)reader["name"];
                    comboBox3.Items.Add(name);
                }
                reader.Close();

                // add teams to add
                cmd = new SqlCommand("EXEC SPS_getTeamsExceptCompetition " + comp.Id.ToString(), cn);
                reader = cmd.ExecuteReader();
                comboBox4.Items.Clear();
                while (reader.Read())
                {
                    Team t = new Team();
                    t.Id = (int)reader["id"];
                    t.Abbreviation = (string)reader["abbreviation"];
                    t.Name = (string)reader["name"];
                    t.Continent = (string)reader["continent"];
                    t.Country = (string)reader["country"];
                    t.Stadium = (string)reader["stadium"];
                    t.Attendance = (int)reader["attendance"];
                    t.Coach = (string)reader["coach"];
                    comboBox4.Items.Add(t);
                }
                reader.Close();
            }
            else
            {
                textBox1.Text = comp.Name;

                // add competition type
                SqlCommand cmd = new SqlCommand("SELECT * FROM FD.COMPETITION_TYPE", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                comboBox1.Items.Clear();
                while (reader.Read())
                {
                    string name = (string)reader["name"];
                    comboBox1.Items.Add(name);
                }
                reader.Close();
                comboBox1.Text = comp.Type;

                // add continent (on competitions tab)
                cmd = new SqlCommand("SELECT * FROM FD.CONTINENT", cn);
                reader = cmd.ExecuteReader();
                comboBox2.Items.Clear();
                while (reader.Read())
                {
                    string name = (string)reader["name"];

                    // add to matches combo box
                    comboBox2.Items.Add(name);
                }
                reader.Close();
                comboBox2.Text = comp.Continent;

                // add country (on competitions, players and teams tab)
                cmd = new SqlCommand("SELECT * FROM FD.COUNTRY", cn);
                reader = cmd.ExecuteReader();
                comboBox3.Items.Clear();
                while (reader.Read())
                {
                    string name = (string)reader["name"];
                    comboBox3.Items.Add(name);
                }
                reader.Close();
                comboBox3.Text = comp.Country;

                cmd = new SqlCommand("EXEC SPS_getCompetitionTeams " + comp.Id.ToString(), cn);
                reader = cmd.ExecuteReader();
                listBox1.Items.Clear();
                while (reader.Read())
                {
                    Team t = new Team();
                    t.Id = (int)reader["id"];
                    t.Abbreviation = (string)reader["abbreviation"];
                    t.Name = (string)reader["name"];
                    t.Continent = (string)reader["continent"];
                    t.Country = (string)reader["country"];
                    t.Stadium = (string)reader["stadium"];
                    t.Attendance = (int)reader["attendance"];
                    t.Coach = (string)reader["coach"];
                    listBox1.Items.Add(t);
                }
                reader.Close();

                // add teams to add
                cmd = new SqlCommand("EXEC SPS_getTeamsExceptCompetition " + comp.Id.ToString(), cn);
                reader = cmd.ExecuteReader();
                comboBox4.Items.Clear();
                while (reader.Read())
                {
                    Team t = new Team();
                    t.Id = (int)reader["id"];
                    t.Abbreviation = (string)reader["abbreviation"];
                    t.Name = (string)reader["name"];
                    t.Continent = (string)reader["continent"];
                    t.Country = (string)reader["country"];
                    t.Stadium = (string)reader["stadium"];
                    t.Attendance = (int)reader["attendance"];
                    t.Coach = (string)reader["coach"];
                    comboBox4.Items.Add(t);
                }
                reader.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (!verifySGBDConnection()) return;

                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_modifyCompetition", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = DBNull.Value;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comboBox1.Text;
                        cmd.Parameters.Add("@continent", SqlDbType.VarChar).Value = comboBox2.Text;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox3.Text;
                        
                        // Get ids of teams to associate with competition
                        var table = new DataTable();
                        table.Columns.Add("id", typeof(int));
                        foreach (Team t in listBox1.Items)
                        {
                            table.Rows.Add(t.Id);
                        }

                        cmd.Parameters.Add("@teams", SqlDbType.Structured).Value = table;

                        cmd.ExecuteNonQuery();

                        string message = "Competition Added Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to add competition in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("SPS_modifyCompetition", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = comp.Id;
                        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comboBox1.Text;
                        cmd.Parameters.Add("@continent", SqlDbType.VarChar).Value = comboBox2.Text;
                        cmd.Parameters.Add("@country", SqlDbType.VarChar).Value = comboBox3.Text;

                        // Get ids of teams to associate with competition
                        var table = new DataTable();
                        table.Columns.Add("id", typeof(int));
                        foreach (Team t in listBox1.Items)
                        {
                            table.Rows.Add(t.Id);
                        }
                        
                        cmd.Parameters.Add("@teams", SqlDbType.Structured).Value = table;

                        cmd.ExecuteNonQuery();

                        string message = "Competition updated Successfully!";
                        string caption = "Result";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        // Displays the MessageBox.
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    string message = "Failed to update competition in database. \n ERROR MESSAGE: \n" + ex.Message;
                    string caption = "Error";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    // Displays the MessageBox.
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Team t = (Team)comboBox4.SelectedItem;
            if (!listBox1.Items.Contains(t))
            {
                listBox1.Items.Add(t);
                comboBox4.Items.Remove(t);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;

            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    comboBox4.Items.Add(selectedItems[i]);
                    listBox1.Items.Remove(selectedItems[i]);
                }
            }
        }
    }
}
