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
    }
}
