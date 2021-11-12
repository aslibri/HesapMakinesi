using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optdrm = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

       

        private void rakamolay(object sender, EventArgs e)

        {   if (textBox1.Text == "0" || optdrm)
                textBox1.Clear();
            optdrm = false;
            Button btn = (Button)sender;
            textBox1.Text+=btn.Text;
        }

        private void opthesap(object sender, EventArgs e)
        {
            optdrm = true;
            Button btn = (Button)sender;
            string yeniopt = btn.Text;
            label1.Text += " "+textBox1.Text+" "+yeniopt;
            switch (opt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "x": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt = yeniopt;
        }


        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            textBox1.Text = "0";
            opt = "0";
            sonuc = 0;
            optdrm = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            switch (opt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "x": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opt ="";
            optdrm = true ;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || !textBox1.Text.Contains(","))
                textBox1.Text += ",";
            else if (optdrm)
                textBox1.Text = "0";
           
            optdrm = false;

        }
    }
}
