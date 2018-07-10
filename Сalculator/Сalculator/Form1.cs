using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        char act;
        bool check = false;
        double memory;
        public Form1()
        {
            InitializeComponent();
            first = 0;
            second = 0;
            act = ' ';
            memory = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(check == true)
            {
                textBox1.Clear();
                check = false;
            }
            if(textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(','))
            {
                textBox1.Text += ",";
            }
        }

      
        private double Sum(double _first,double _second)
        {
            return _first + _second;
        }
        private double Diff(double _first, double _second)
        {
            return _first - _second;
        }
        private double Mult(double _first, double _second)
        {
            return _first * _second;
        }
        private double Division(double _first, double _second)
        {
           
               return _first/_second;
         
        }
        private void button_plus_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            act = '+';
            textBox1.Text = Convert.ToString(act);
            check = true;
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(textBox1.Text);
            switch(act)
            {
                case '+':
                    textBox1.Text = Convert.ToString(Sum(first,second));
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(Diff(first, second));
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(Mult(first, second));
                    break;
                case '/':
                    if (second == 0)
                    {
                        textBox1.Text = "Деление на ноль!";
                    }
                    else
                    {
                        textBox1.Text = Convert.ToString(Division(first, second));
                    }
                 
                    break;
            }
            act = ' ';



        }
         private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void button_diff_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            act = '-';
            textBox1.Text = Convert.ToString(act);
            check = true;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            act = '*';
            textBox1.Text = Convert.ToString(act);
            check = true;
        }

        private void button_division_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            act = '/';
            textBox1.Text = Convert.ToString(act);
            check = true;
        }

        private void button_clear_last_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button_memory_wright_Click(object sender, EventArgs e)
        {
            if (label_Memory.Text != "M")
            {
                memory = Convert.ToDouble(textBox1.Text);
                label_Memory.Text = "M";
            }
                   else
            {
                return;
            }
        }

        private void button_memory_clear_Click(object sender, EventArgs e)
        {
            memory = 0;
            label_Memory.Text = " ";
            
        }

        private void button_memory_use_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(memory);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }






}
