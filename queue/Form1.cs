using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue
{
    public partial class Form1 : Form
    {
        Queue<string> Queue;
        public Form1()
        {
            InitializeComponent();
            Queue = new Queue<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            Queue.Enqueue(txt);
            textBox1.Text = "";

            listBox1.Items.Clear();
            foreach (string item in Queue)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Queue.Count == 0) return;
            Queue.Dequeue();
            listBox1.Items.Clear();
            foreach (string item in Queue)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
