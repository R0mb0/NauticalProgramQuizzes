using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DefinitiveNauticalProject.Password;

namespace DefinitiveNauticalProject
{
    public partial class FirstPanel : Form
    {
        private SimulationPanel simulation;
        private QuizzesPanel quizzes;
        private PasswordPanel password;

        public FirstPanel()
        {
            InitializeComponent();
            this.simulation = new SimulationPanel();
            this.quizzes = new QuizzesPanel();
            this.password = new PasswordPanel();
        }

        private void simulationButton_Click(object sender, EventArgs e)
        {
            this.simulation.ShowDialog();
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            this.quizzes.ShowDialog();
        }

        private void editorButton_Click(object sender, EventArgs e)
        {
            this.password.ShowDialog();
        }
    }
}
