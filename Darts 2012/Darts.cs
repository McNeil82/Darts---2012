using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Darts_2012
{
    public partial class Darts : Form
    {
        public Darts()
        {
            InitializeComponent();
        }

        private void spielerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Spielerverwaltung spielerverwaltung = new Spielerverwaltung();
            spielerverwaltung.ShowDialog();
            this.Enabled = true;
        }

        private void board_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Cyan);
            Graphics g = e.Graphics;
            g.FillRectangle(brush, (board.Width / 2) + 5, 0, 1, board.Height);
            g.FillRectangle(brush, 0, (board.Height / 2) - 3, board.Width, 1);

            g.FillRectangle(new SolidBrush(Color.HotPink), (board.Width / 2) + 5, (board.Height / 2) - 3, 1, 1);
        }
    }
}
