using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballDatabase
{
    public partial class TeamForm : Form
    {
        public TeamForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lineupsHomeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teamDeleteButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement DELETE
            this.Close();
        }
    }
}
