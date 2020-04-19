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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool is_multyp = false;

        private void button1_Click(object sender, EventArgs e)
        {
            TicTac.player1 = textBox1.Text;
            TicTac.player2 = textBox2.Text;

            TicTac.FirstPlayer();
            
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Input correct names!");
            }
            else if(TicTac.player1_id == 1)
            {
                //Message(TicTac.player1);
                is_multyp = true;
            }
            else if(TicTac.player2_id == 1)
            {
                //Message(TicTac.player2);
                is_multyp = true;
            }

            if(is_multyp)
            {
                TicTac.is_multyp = true;
                this.Close();
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Message(string name)
        {
            MessageBox.Show($"{name} will be the first.");
        }
    }
}
