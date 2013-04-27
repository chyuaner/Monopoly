using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        int step;
        Random dice = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("map.png");
            Player player = new Player("Player1", "player1.png", new Size(50, 50), new Point(37, 37));
            Controls.Add(player.figure);
            player.figure.BringToFront();

            this.timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            step = dice.Next(6) + 1;
            this.label8.Text = step.ToString();
            step *= 25;
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            step = 1;
            this.label8.Text = step.ToString();
            step *= 25;
            this.timer1.Start();
        }
    }
}
