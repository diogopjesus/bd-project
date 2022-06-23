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
    public partial class ProcurarCampeonato : Form
    {
        public ProcurarCampeonato()
        {
            InitializeComponent();
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
