using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        public Darts()
        {
            InitializeComponent();
        }

        private void spielerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            PlayerManagement playerManagement = new PlayerManagement();
            playerManagement.ShowDialog();
            this.Enabled = true;
        }

        private void board_Paint(object sender, PaintEventArgs e)
        {
            Point center = new Point((board.Width / 2) + 5, (board.Height / 2) - 4);
            BoardGrid boardGrid = new BoardGrid(center, board.Width, board.Height);
            boardGrid.drawGrid(e.Graphics);
        }
    }
}
