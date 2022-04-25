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
    public partial class Players : Form
    {
        public Players()
        {
            InitializeComponent();      
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Level difficulty = new Level();
            difficulty.Show();          
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
