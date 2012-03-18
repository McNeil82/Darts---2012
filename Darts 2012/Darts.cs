using System;
using System.Drawing;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        private BoardGrid _boardGrid;
        private readonly Point _center;

        public Darts()
        {
            InitializeComponent();
            _center = new Point((board.Width / 2) + 5, (board.Height / 2) - 4);
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
            _boardGrid = new BoardGrid(e.Graphics, _center, board.Width, board.Height);
            _boardGrid.DrawGrid();
        }

        private void BoardMouseClick(object sender, MouseEventArgs e)
        {
            yTextBox.Text = (e.Y - _center.Y).ToString();
            xTextBox.Text = (e.X - _center.X).ToString();
            _boardGrid.HighlightPolygon(e.X, e.Y);
        }
    }
}
