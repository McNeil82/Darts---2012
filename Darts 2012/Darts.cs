using System;
using System.Drawing;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        private BoardGrid _boardGrid;
        private Point _center;

        public Darts()
        {
            InitializeComponent();
            SetUpBoardGrid();
        }

        private void SetUpBoardGrid()
        {
            _center = new Point((board.Width / 2) + 5, (board.Height / 2) - 4);
            _boardGrid = new BoardGrid(_center, board.CreateGraphics());
        }

        private void SpielerToolStripMenuItemClick(object sender, EventArgs eventArgs)
        {
            Enabled = false;
            var playerManagement = new PlayerManagement();
            playerManagement.ShowDialog();
            Enabled = true;
        }

        private void BoardMouseClick(object sender, MouseEventArgs mouseEventArgs)
        {
            pointsTextBox.Text = _boardGrid.GetPoints(mouseEventArgs.X, mouseEventArgs.Y).ToString();
        }

        private void DartsSizeChanged(object sender, EventArgs e)
        {
            SetUpBoardGrid();
        }
    }
}
