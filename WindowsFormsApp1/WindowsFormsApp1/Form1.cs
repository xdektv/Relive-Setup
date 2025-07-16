using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set visual layering
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            panel1.Parent = pictureBox1;
            panel2.Parent = pictureBox1;
            panel3.Parent = pictureBox1;
            panel4.Parent = pictureBox1;
            panel5.Parent = pictureBox1;

            // Set transparency
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel4.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;

            // Recalculate positions relative to pictureBox1
            label1.Location = pictureBox1.PointToClient(this.PointToScreen(label1.Location));
            label2.Location = pictureBox1.PointToClient(this.PointToScreen(label2.Location));
            pictureBox2.Location = pictureBox1.PointToClient(this.PointToScreen(pictureBox2.Location));
            panel1.Location = pictureBox1.PointToClient(this.PointToScreen(panel1.Location));
            panel2.Location = pictureBox1.PointToClient(this.PointToScreen(panel2.Location));
            panel3.Location = pictureBox1.PointToClient(this.PointToScreen(panel3.Location));
            panel4.Location = pictureBox1.PointToClient(this.PointToScreen(panel4.Location));
            panel5.Location = pictureBox1.PointToClient(this.PointToScreen(panel5.Location));

            // Initial visibility
            label1.Visible = true;
            label2.Visible = true;
            panel1.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            panel2.Visible = false;
            button4.Visible = false;
            panel3.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // hide label1 and label2
            label1.Visible = false;
            label2.Visible = false;

            // hide button1 and show button2
            button1.Visible = false;
            button2.Visible = true;

            // show panel1 were all of the branding shit is
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // hide panel1, button2 and show button3 as well as panel2
            panel1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
            panel2.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // hide panel2 and other
            panel2.Visible = false;
            panel3.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // you know the deal
            panel3.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            panel4.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // not saying shit
            button5.Visible = false;
            button7.Visible = true;
            panel4.Visible = false;
            panel5.Visible = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

    }
}

