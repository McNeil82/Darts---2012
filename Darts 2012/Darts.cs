using System;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        private static readonly Board Board = new Board();

        public Darts()
        {
            InitializeComponent();
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
            var centerX = (boardPictureBox.Width / 2) + 5;
            var centerY = (boardPictureBox.Height / 2) - 4;
            pointsTextBox.Text = Board.GetPoints(mouseEventArgs.X, mouseEventArgs.Y, centerX, centerY).ToString();
        }
    }
}
