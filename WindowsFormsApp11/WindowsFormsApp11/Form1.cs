using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 25; i++)
            {
                this.progressBar1.Value += 4;
                this.label2.Text = $"Loading {this.progressBar1.Value} %";
                this.Update();
                Thread.Sleep(100);
            }
            using (StreamWriter file = File.AppendText("text.txt"))
            {
                file.WriteLine(this.textBox1.Text);
            }
            this.textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 25; i++)
            {
                this.progressBar1.Value += 4;
                this.label2.Text = $"Loading {this.progressBar1.Value} %";
                this.Update();
                Thread.Sleep(100);
            }
            using (StreamWriter file = new StreamWriter("text.txt"))
            {
                file.WriteLine(this.textBox1.Text);
            }
            this.textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 25; i++)
            {
                this.progressBar1.Value += 4;
                this.label2.Text = $"Loading {this.progressBar1.Value} %";
                this.Update();
                Thread.Sleep(100);
            }
            using (StreamWriter file = new StreamWriter("text.txt"))
            {
                file.WriteLine(string.Empty);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            for (int i = 0; i < 25; i++)
            {
                this.progressBar1.Value += 4;
                this.label2.Text = $"Loading {this.progressBar1.Value} %";
                this.Update();
                Thread.Sleep(100);
            }
            string file = File.ReadAllText("text.txt");
            this.label1.Text = file;
        }
    }
}
