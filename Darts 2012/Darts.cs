using System;
using System.Windows.Forms;
using Darts_2012.Game;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        private static readonly Board Board = new Board();
        private readonly GameManagement _gameManagement = new GameManagement();

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
                _gameManagement.Game = aroundTheClockDialog.CurrentGame;
                _gameManagement.PlayerCount = aroundTheClockDialog.PlayerCount;
                PrepareNewGame();
            }
            Enabled = true;
        }

        private void PrepareNewGame()
        {
            panelPlayer1.Visible = false;
            panelPlayer2.Visible = false;
            if (_gameManagement.PlayerCount >= 1)
            {
                panelPlayer1.Visible = true;
            }
            if (_gameManagement.PlayerCount >= 2)
            {
                panelPlayer2.Visible = true;
            }
            _gameManagement.CurrentPlayer = 1;
        }
    }
}
