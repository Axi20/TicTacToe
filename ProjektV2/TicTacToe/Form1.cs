namespace TicTacToe
{
    
    public partial class Form1 : Form
    {
        int next = 0;
    public class Steps
        {
            private string X = "X";
            private string O = "O";
            
            public string ButtonX
            {
                get { return X; }
                set { X = value; }
            }
            
            public string ButtonO
            {
                get { return O; }
                set { O = value; }
                
            }
        }
       

        public Form1()
        {
            InitializeComponent();
            Steps playerSteps = new Steps();

            if (button1.Text == playerSteps.ButtonX && button2.Text == playerSteps.ButtonX && button3.Text == playerSteps.ButtonX)
            {
                MessageBox.Show("Player1 won the match");
            }

          
        }

       private void buttons()
        {
           if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("Player 1 won the match");
            }

            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                 || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                 || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                 || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                 || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("Player 2 won the match");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            next++;
            Steps playerSteps = new Steps();
            if (next %2 == 0)
            {
                button1.Text = playerSteps.ButtonX;
                button1.Enabled = false;
            }
            else
            {
                button1.Text = playerSteps.ButtonO;
                button1.Enabled = false;
            }

            buttons();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button2.Text = playerSteps.ButtonX;
                button2.Enabled = false;
            }
            else
            {
                button2.Text = playerSteps.ButtonO;
                button2.Enabled = false;
            }

            buttons();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button3.Text = playerSteps.ButtonX;
                button3.Enabled = false;
            }
            else
            {
                button3.Text = playerSteps.ButtonO;
                button3.Enabled = false;
            }

            buttons();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button4.Text = playerSteps.ButtonX;
                button4.Enabled = false;
            }
            else
            {
                button4.Text = playerSteps.ButtonO;
                button4.Enabled = false;
            }

            buttons();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button5.Text = playerSteps.ButtonX;
                button5.Enabled = false;
            }
            else
            {
                button5.Text = playerSteps.ButtonO;
                button5.Enabled = false;
            }

            buttons();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button6.Text = playerSteps.ButtonX;
                button6.Enabled = false;
            }
            else
            {
                button6.Text = playerSteps.ButtonO;
                button6.Enabled = false;
            }

            buttons();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button7.Text = playerSteps.ButtonX;
                button7.Enabled = false;
            }
            else
            {
                button7.Text = playerSteps.ButtonO;
                button7.Enabled = false;
            }

            buttons();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button8.Text = playerSteps.ButtonX;
                button8.Enabled = false;
            }
            else
            {
                button8.Text = playerSteps.ButtonO;
                button8.Enabled = false;
            }

            buttons();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            next++;
            Steps playerSteps = new Steps();
            if (next % 2 == 0)
            {
                button9.Text = playerSteps.ButtonX;
                button9.Enabled = false;
            }
            else
            {
                button9.Text = playerSteps.ButtonO;
                button9.Enabled = false;
            }

            buttons();
        }

        
    }
}