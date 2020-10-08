using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_6112_19195640
{
    public partial class Form1 : Form
    {
        GameEngine ge;

        public Form1()
        {
            InitializeComponent();
            ge = new GameEngine();
            DisplayMap();
            DisplayPlayerStats();
        }

        public void DisplayMap()
        {
            MAPBOX.Text = ge.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        public void DisplayPlayerStats()
        {
            STATBOX.Text = ge.M.PLAYER.ToString();
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Up);
            GameTick();
        }

        private void btnLEFT_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Left);
            GameTick();
        }

        private void btnRIGHT_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Right);
            GameTick();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            ge.MovePlayer(movement.Down);
            GameTick();
        }

        public void GameTick()
        {
            ge.UpdateEnemies();
            MAPBOX.Text = "";
            MAPBOX.Text = ge.ToString();
        }
    }
}
