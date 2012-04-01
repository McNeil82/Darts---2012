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
            RefreshPanels();
        }

        private void RefreshPanels()
        {
            player1ThrowLights.Image = GetThrowImage(1);
            if (_gameManagement.PlayerHasfinished(1))
            {
                player1CurrentTarget.Text = "-";
            }
            else
            {
                player1CurrentTarget.Text = _gameManagement.GetCurrentScoreFromPlayer(1);
            }

            player2ThrowLights.Image = GetThrowImage(2);
            if (_gameManagement.PlayerHasfinished(2))
            {
                player2CurrentTarget.Text = "-";
            }
            else
            {
                player2CurrentTarget.Text = _gameManagement.GetCurrentScoreFromPlayer(2);
            }
        }

        private Bitmap GetThrowImage(int playerNumber)
        {
            var currentThrowFromPlayer = _gameManagement.GetCurrentThrowFromPlayer(playerNumber);
            if (currentThrowFromPlayer == 1)
            {
                return Resources.threeThrowsLeft;
            }
            if (currentThrowFromPlayer == 2)
            {
                return Resources.twoThrowsLeft;
            }
            if (currentThrowFromPlayer == 3)
            {
                return Resources.oneThrowLeft;
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
                InitializePlayerPanels();
                Text = "Darts - " + _gameManagement.GetGameMode();
            }
            Enabled = true;
        }

        private void InitializePlayerPanels()
        {
            player1Panel.Visible = false;
            player2Panel.Visible = false;

            RefreshPanels();

            if (_gameManagement.GetPlayerCount() >= 1)
            {
                player1Panel.Visible = true;
            }

            if (_gameManagement.GetPlayerCount() >= 2)
            {
                player2Panel.Visible = true;
            }
        }
    }
}
