using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_8
{
    public partial class Form1 : Form
    {
        List<string> girl_names = new List<string>();
        List<string> boy_names = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Please enter name before touch the button");
            }
            int boy_index = boy_names.FindIndex(x => x == textBox2.Text);
            int girl_index = girl_names.FindIndex(x => x == textBox1.Text);
            string result_text = "";
            if (boy_index != -1)
            {
                result_text += $"The boy name {textBox2.Text} number is {boy_index}\n";
            } else
            {
                result_text += $"The boy name {textBox2.Text} was not found\n";
            }
            if (girl_index != -1)
                result_text += $"The girl name {textBox1.Text} number is {girl_index}\n";
            else
                result_text += $"The girl name {textBox1.Text} was not found\n";
            MessageBox.Show(result_text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] boys = File.ReadAllLines("boy.txt");
            string[] girls = File.ReadAllLines("girls.txt");
            foreach (string boy in boys)
            {
                boy_names.Add(boy);
            }
            foreach (string girl in girls)
            {
                girl_names.Add(girl);
            }
        }
    }
}
