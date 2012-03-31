using System;
using System.Windows.Forms;
using Darts_2012.Game;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        private static readonly Board Board = new Board();
        private IDartsGame _actualGame;

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

        private void AroundTheClockToolStripMenuItemClick(object sender, EventArgs e)
        {
            Enabled = false;
            var aroundTheClockDialog = new AroundTheClockDialog();
            if (aroundTheClockDialog.ShowDialog() == DialogResult.OK)
            {
                _actualGame = aroundTheClockDialog.ActualGame;
                MessageBox.Show(_actualGame.ToString());
            }
            Enabled = true;
        }
    }
}
