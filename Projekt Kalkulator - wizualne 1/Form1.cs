using System.Windows.Forms;

namespace Projekt_Kalkulator___wizualne_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a;
        float b;
        float c;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)///
        {
            if (b != 0)
            {
                c = a / b;
                
            }
            else
            {
                MessageBox.Show("B³¹d: Dzielenie przez zero!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }
        }

        private void button14_Click(object sender, EventArgs e)//*
        {
            c = a * b;
        }

        private void button15_Click(object sender, EventArgs e)//-
        {
            c = a - b;
        }

        private void button2_Click(object sender, EventArgs e)//AC
        {
            Application.Restart();
        }

        private void button21_Click(object sender, EventArgs e)//=
        {
            richTextBox3.Text = (c).ToString();
        }

        private void button16_Click(object sender, EventArgs e)//+
        {
            c = a + b;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)//first
        {
            a = float.Parse(richTextBox1.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)//second
        {
            b = float.Parse(richTextBox2.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
