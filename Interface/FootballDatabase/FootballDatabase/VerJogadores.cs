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
    public partial class VerJogadores : Form
    {
        public VerJogadores()
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
