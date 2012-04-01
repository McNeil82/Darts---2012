using System;
using System.Windows.Forms;
using Darts_2012.Game;

namespace Darts_2012
{
    public partial class AroundTheClockDialog : Form
    {
        public AroundTheClockDialog()
        {
            InitializeComponent();
            comboBoxFrom.SelectedIndex = 0;
            comboBoxTo.SelectedIndex = 3;
            comboBoxPlayerCount.SelectedIndex = 1;
        }

        public IDartsGame CurrentGame { get; private set; }

        private void ComboBoxFromSelectedIndexChanged(object sender, EventArgs e)
        {
            var previouslySelectedIndex = comboBoxTo.SelectedIndex;
            var previousItemCount = comboBoxTo.Items.Count;
            comboBoxTo.Items.Clear();
            for (var itemIndex = comboBoxFrom.SelectedIndex + 1; itemIndex < 20; itemIndex++)
            {
                comboBoxTo.Items.Add(itemIndex + 1);
            }
            if (comboBoxTo.Items.Count == 0)
            {
                comboBoxTo.Items.Add(20);
            }

            var newItemIndex = previouslySelectedIndex - (previousItemCount - comboBoxTo.Items.Count);
            comboBoxTo.SelectedIndex = Math.Max(0, newItemIndex);
        }

        private void ButtonOkClick(object sender, EventArgs e)
        {
            var to = Int16.Parse(comboBoxTo.SelectedItem.ToString());
            var skip = checkBoxSkip.Checked;
            var joker = checkBoxJoker.Checked;
            CurrentGame = new AroundTheClock(to, skip, joker)
                              {
                                  PlayerCount = Int16.Parse(comboBoxPlayerCount.SelectedItem.ToString()),
                                  InitialScore = Int16.Parse(comboBoxFrom.SelectedItem.ToString())
                              };
        }
    }
}
