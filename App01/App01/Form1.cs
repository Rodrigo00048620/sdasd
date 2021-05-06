using System;
using System.Drawing;
using System.Windows.Forms;

namespace App01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Blue;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Brown;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Chartreuse;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Indigo;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Crimson;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Coral;
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Lime;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Chocolate;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Navy;
        }

        private void btn_111_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Gray;
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.Tomato;
        }

        private void btn_222_Click(object sender, EventArgs e)
        {
            changeColor.BackColor = Color.DeepPink;
        }

        private void Btn_Gp_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void Btn_A_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a");
            MessageBox.Show("e");
            MessageBox.Show("i");
            MessageBox.Show("o");
            MessageBox.Show("u");
        }

        private void Btn_Ola_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
            MessageBox.Show("ola");
            MessageBox.Show("k");
            MessageBox.Show("ase");
        }
    }
}