using System;
using System.Windows.Forms;
using Darts_2012.Game;
using Darts_2012.Poco;
using Darts_2012.Properties;

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
            var @throw = Board.DetectThrow(mouseEventArgs.X, mouseEventArgs.Y, centerX, centerY);
            ProcessThrow(@throw);
        }

        private void ProcessThrow(Throw @throw)
        {
            _gameManagement.ProcessThrow(@throw);
            if (_gameManagement.CurrentPlayer == 1)
            {
                if (_gameManagement.CurrentThrow == 1)
                {
                    player1ThrowLights.Image = Resources.threeThrowsLeft;
                }
                else if (_gameManagement.CurrentThrow == 2)
                {
                    player1ThrowLights.Image = Resources.twoThrowsLeft;
                }
                else if (_gameManagement.CurrentThrow == 3)
                {
                    player1ThrowLights.Image = Resources.oneThrowLeft;
                }

            }
            else
            {
                player1ThrowLights.Image = Resources.noThrowLeft;
            }
            if (_gameManagement.CurrentPlayer == 2)
            {
                if (_gameManagement.CurrentThrow == 1)
                {
                    player2ThrowLights.Image = Resources.threeThrowsLeft;
                }
                else if (_gameManagement.CurrentThrow == 2)
                {
                    player2ThrowLights.Image = Resources.twoThrowsLeft;
                }
                else if (_gameManagement.CurrentThrow == 3)
                {
                    player2ThrowLights.Image = Resources.oneThrowLeft;
                }
                else if (_gameManagement.CurrentThrow == 0)
                {
                    player2ThrowLights.Image = Resources.noThrowLeft;
                }
            }
            else
            {
                player2ThrowLights.Image = Resources.noThrowLeft;
            }
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
            player1Panel.Visible = false;
            player2Panel.Visible = false;
            if (_gameManagement.PlayerCount >= 1)
            {
                player1CurrentTarget.Text = ((AroundTheClock)_gameManagement.Game).From.ToString();
                player1Panel.Visible = true;
            }
            if (_gameManagement.PlayerCount >= 2)
            {
                player2Panel.Visible = true;
            }
            _gameManagement.CurrentPlayer = 1;
            _gameManagement.CurrentThrow = 1;
        }
    }
}
