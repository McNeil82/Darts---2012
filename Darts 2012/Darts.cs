using System;
using System.Drawing;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        public Darts()
        {
            InitializeComponent();
        }

        private void SpielerToolStripMenuItemClick(object sender, EventArgs e)
        {
            Enabled = false;
            var playerManagement = new PlayerManagement();
            playerManagement.ShowDialog();
            Enabled = true;
        }

        private void BoardPaint(object sender, PaintEventArgs e)
        {
            var center = new Point((board.Width / 2) + 5, (board.Height / 2) - 4);
            var boardGrid = new BoardGrid(center, board.Width, board.Height);
            boardGrid.DrawGrid(e.Graphics);
        }
    }
}
