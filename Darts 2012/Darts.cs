using System;
using System.Drawing;
using System.Windows.Forms;
using Darts_2012.Dialog;
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
                var centerX = (boardPictureBox.Width/2) + 5;
                var centerY = (boardPictureBox.Height/2) - 4;
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
            player1CurrentTargetLabel.Text = _gameManagement.GetScoreLabel();
            player1CurrentTarget.Text = _gameManagement.PlayerHasfinished(1)
                ? "-"
                : _gameManagement.GetCurrentScoreFromPlayer(1);
            player1AdditionalInfo.Text = _gameManagement.GetAdditionalInfoForPlayer(1);

            player2ThrowLights.Image = GetThrowImage(2);
            player2CurrentTargetLabel.Text = _gameManagement.GetScoreLabel();
            player2CurrentTarget.Text = _gameManagement.PlayerHasfinished(2)
                ? "-"
                : _gameManagement.GetCurrentScoreFromPlayer(2);
            player2AdditionalInfo.Text = _gameManagement.GetAdditionalInfoForPlayer(2);

            player3ThrowLights.Image = GetThrowImage(3);
            player3CurrentTargetLabel.Text = _gameManagement.GetScoreLabel();
            player3CurrentTarget.Text = _gameManagement.PlayerHasfinished(3)
                ? "-"
                : _gameManagement.GetCurrentScoreFromPlayer(3);
            player3AdditionalInfo.Text = _gameManagement.GetAdditionalInfoForPlayer(3);

            player4ThrowLights.Image = GetThrowImage(4);
            player4CurrentTargetLabel.Text = _gameManagement.GetScoreLabel();
            player4CurrentTarget.Text = _gameManagement.PlayerHasfinished(4)
                ? "-"
                : _gameManagement.GetCurrentScoreFromPlayer(4);
            player4AdditionalInfo.Text = _gameManagement.GetAdditionalInfoForPlayer(4);
        }

        private Bitmap GetThrowImage(int playerNumber)
        {
            var currentThrow = _gameManagement.GetCurrentThrowFromPlayer(playerNumber);
            if (currentThrow == 1)
            {
                return Resources.threeThrowsLeft;
            }
            if (currentThrow == 2)
            {
                return Resources.twoThrowsLeft;
            }
            if (currentThrow == 3)
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
            player3Panel.Visible = false;
            player4Panel.Visible = false;

            RefreshPanels();

            if (_gameManagement.GetPlayerCount() >= 1)
            {
                player1Panel.Visible = true;
            }

            if (_gameManagement.GetPlayerCount() >= 2)
            {
                player2Panel.Visible = true;
            }

            if (_gameManagement.GetPlayerCount() >= 3)
            {
                player3Panel.Visible = true;
            }

            if (_gameManagement.GetPlayerCount() >= 4)
            {
                player4Panel.Visible = true;
            }
        }

        private void X01ToolStripMenuItemClick(object sender, EventArgs e)
        {
            Enabled = false;
            var x01Dialog = new X01Dialog();
            if (x01Dialog.ShowDialog() == DialogResult.OK)
            {
                _gameManagement.PrepareGame(x01Dialog.CurrentGame);
                InitializePlayerPanels();
                Text = "Darts - " + _gameManagement.GetGameMode();
            }
            Enabled = true;
        }

        private void TextBoxPlayer1NameEnter(object sender, EventArgs e)
        {
            textBoxPlayer1Name.ReadOnly = false;
        }

        private void TextBoxPlayer1NameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                LeaveTextBoxPlayer1Name();
                player1Panel.Focus();
            }
        }

        private void TextBoxPlayer1NameLeave(object sender, EventArgs e)
        {
            LeaveTextBoxPlayer1Name();
        }

        private void LeaveTextBoxPlayer1Name()
        {
            textBoxPlayer1Name.ReadOnly = true;
        }

        private void TextBoxPlayer2NameEnter(object sender, EventArgs e)
        {
            textBoxPlayer2Name.ReadOnly = false;
        }

        private void TextBoxPlayer2NameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                LeaveTextBoxPlayer2Name();
                player2Panel.Focus();
            }
        }

        private void TextBoxPlayer2NameLeave(object sender, EventArgs e)
        {
            LeaveTextBoxPlayer2Name();
        }

        private void LeaveTextBoxPlayer2Name()
        {
            textBoxPlayer2Name.ReadOnly = true;
        }

        private void TextBoxPlayer3NameEnter(object sender, EventArgs e)
        {
            textBoxPlayer3Name.ReadOnly = false;
        }

        private void TextBoxPlayer3NameLeave(object sender, EventArgs e)
        {
            LeaveTextBoxPlayer3Name();
        }

        private void LeaveTextBoxPlayer3Name()
        {
            textBoxPlayer3Name.ReadOnly = true;
        }

        private void TextBoxPlayer3NameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                LeaveTextBoxPlayer3Name();
                player3Panel.Focus();
            }
        }

        private void TextBoxPlayer4NameEnter(object sender, EventArgs e)
        {
            textBoxPlayer4Name.ReadOnly = false;
        }

        private void TextBoxPlayer4NameLeave(object sender, EventArgs e)
        {
            LeaveTextBoxPlayer4Name();
        }

        private void LeaveTextBoxPlayer4Name()
        {
            textBoxPlayer4Name.ReadOnly = true;
        }

        private void TextBoxPlayer4NameKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                LeaveTextBoxPlayer4Name();
                player4Panel.Focus();
            }
        }
    }
}