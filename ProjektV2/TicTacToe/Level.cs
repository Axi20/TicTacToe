using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 normalGame = new Form1(); 
            normalGame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MediumDiff mediumGame = new MediumDiff();
            mediumGame.Show();
        }
    }
}
