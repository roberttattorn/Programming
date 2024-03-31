using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class program : Form
    {
        int operand1;
        int operand2; int turn = 0; int result; 
        float multiple1; float multiple2; float multiresult;
        public program()
        {
            InitializeComponent();
        }

        private void program_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { result = operand1 + operand2; textBox2.Text = result.ToString(); }
            else if(comboBox1.SelectedIndex == 1)
            { result = operand1 - operand2; textBox2.Text = result.ToString(); }
            else if (comboBox1.SelectedIndex == 2)
            { result = operand1 * operand2; textBox2.Text = result.ToString(); }
            else if (comboBox1.SelectedIndex == 3)
            { multiresult = multiple1 / multiple2; textBox2.Text = multiresult.ToString(); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="1"; if (turn == 0) { operand1 = 1; multiple1 = 1; } else { operand2 = 1;multiple2 = 1; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2"; if (turn == 0) { operand1 = 2;multiple1 = 2; }else{ operand2 = 2;multiple2 = 2; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            turn++; if (turn > 1) turn = 0;
            textBox1.Text = "";
        }
    }
}
