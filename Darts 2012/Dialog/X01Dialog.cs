using System;
using System.Windows.Forms;
using Darts_2012.Game;

namespace Darts_2012.Dialog
{
    public partial class X01Dialog : Form
    {
        public X01Dialog()
        {
            InitializeComponent();
            comboBoxScoreToBeginWith.SelectedIndex = 0;
            comboBoxPlayerCount.SelectedIndex = 1;
        }

        public IDartsGame CurrentGame { get; private set; }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            var doubleIn = checkBoxDoubleIn.Checked;
            X01OutMode.OutMode outMode;
            if (radioButtonDoubleOut.Checked)
            {
                outMode = X01OutMode.OutMode.DoubleOut;
            }
            else if (radioButtonMasterOut.Checked)
            {
                outMode = X01OutMode.OutMode.MasterOut;
            }
            else
            {
                outMode = X01OutMode.OutMode.StraightOut;
            }

            CurrentGame = new X01(doubleIn, outMode)
            {
                PlayerCount = Int16.Parse(comboBoxPlayerCount.SelectedItem.ToString()),
                InitialScore = Int16.Parse(comboBoxScoreToBeginWith.SelectedItem.ToString())
            };
        }
    }
}
