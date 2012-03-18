﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        private readonly BoardGrid _boardGrid;
        private readonly Point _center;

        public Darts()
        {
            InitializeComponent();
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
            _boardGrid.HighlightPolygon(mouseEventArgs.X, mouseEventArgs.Y);
        }
    }
}
