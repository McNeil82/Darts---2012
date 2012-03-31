using System;
using System.Drawing;
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
            if (_gameManagement.GameInProgress)
            {
                var centerX = (boardPictureBox.Width / 2) + 5;
                var centerY = (boardPictureBox.Height / 2) - 4;
                var @throw = Board.DetectThrow(mouseEventArgs.X, mouseEventArgs.Y, centerX, centerY);
                ProcessThrow(@throw);
            }
        }

        private void ProcessThrow(Throw @throw)
        {
            _gameManagement.ProcessThrow(@throw);
            player1ThrowLights.Image = GetThrowImage(1);
            player2ThrowLights.Image = GetThrowImage(2);
        }

        private Bitmap GetThrowImage(int playerNumber)
        {
            if (_gameManagement.CurrentPlayer.Number == playerNumber)
            {
                if (_gameManagement.CurrentThrow == 1)
                {
                    return Resources.threeThrowsLeft;
                }
                if (_gameManagement.CurrentThrow == 2)
                {
                    return Resources.twoThrowsLeft;
                }
                if (_gameManagement.CurrentThrow == 3)
                {
                    return Resources.oneThrowLeft;
                }

            }

            return Resources.noThrowLeft;
        }

        private void AroundTheClockToolStripMenuItemClick(object sender, EventArgs e)
        {
            Enabled = false;
            var aroundTheClockDialog = new AroundTheClockDialog();
            if (aroundTheClockDialog.ShowDialog() == DialogResult.OK)
            {
                _gameManagement.PrepareGame(aroundTheClockDialog.CurrentGame);
                ShowPlayerPanels();
            }
            Enabled = true;
        }

        private void ShowPlayerPanels()
        {
            player1Panel.Visible = false;
            player2Panel.Visible = false;
            if (_gameManagement.GetPlayerCount() >= 1)
            {
                player1CurrentTarget.Text = _gameManagement.GetPlayerScore(1);
                player1Panel.Visible = true;
            }
            if (_gameManagement.GetPlayerCount() >= 2)
            {
                player2CurrentTarget.Text = _gameManagement.GetPlayerScore(2);
                player2Panel.Visible = true;
            }
        }
    }
}
