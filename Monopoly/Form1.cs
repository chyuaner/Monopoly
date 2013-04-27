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
        Block[] blocks;
        Player player;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("map.png");
            player = new Player("Player1", "player1.png", new Size(50, 50), new Point(37, 37));
            Controls.Add(player.figure);
            player.figure.BringToFront();
            createBlocks();

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
        private void createBlocks()
        {
            blocks = new Block[24];
            blocks[0] = new StartingBlock();
            blocks[1] = new GainBlock();
            blocks[2] = new GainBlock();
            blocks[3] = new LoseBlock();
            blocks[4] = new StationBlock();
            blocks[5] = new LoseBlock();
            blocks[6] = new PrisonBlock();
            blocks[7] = new LoseBlock();
            blocks[8] = new GainBlock();
            blocks[9] = new GainBlock();
            blocks[10] = new LoseBlock();
            blocks[11] = new LoseBlock();
            blocks[12] = new LoseBlock();
            blocks[13] = new LoseBlock();
            blocks[14] = new StationBlock();
            blocks[15] = new LoseBlock();
            blocks[16] = new GainBlock();
            blocks[17] = new GainBlock();
            blocks[18] = new LoseBlock();
            blocks[19] = new GainBlock();
            blocks[20] = new GainBlock();
            blocks[21] = new LoseBlock();
            blocks[22] = new StationBlock();
            blocks[23] = new GainBlock();

            blocks[0].Position = new Point(0, 0);
            blocks[1].Position = new Point(100, 0);
            blocks[2].Position = new Point(200, 0);
            blocks[3].Position = new Point(300, 0);
            blocks[4].Position = new Point(400, 0);
            blocks[5].Position = new Point(400, 100);
            blocks[6].Position = new Point(400, 200);
            blocks[7].Position = new Point(300, 200);
            blocks[8].Position = new Point(200, 200);
            blocks[9].Position = new Point(200, 300);
            blocks[10].Position = new Point(200, 400);
            blocks[11].Position = new Point(300, 400);
            blocks[12].Position = new Point(400, 400);
            blocks[13].Position = new Point(400, 500);
            blocks[14].Position = new Point(400, 600);
            blocks[15].Position = new Point(300, 600);
            blocks[16].Position = new Point(200, 600);
            blocks[17].Position = new Point(100, 600);
            blocks[18].Position = new Point(0, 600);
            blocks[19].Position = new Point(0, 500);
            blocks[20].Position = new Point(0, 400);
            blocks[21].Position = new Point(0, 300);
            blocks[22].Position = new Point(0, 200);
            blocks[23].Position = new Point(0, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            --step;
            int from = player.Place;
            int to = (from + 1) % 24;
            player.move(blocks[from].Position, blocks[to].Position,25);
        }
    }
}
