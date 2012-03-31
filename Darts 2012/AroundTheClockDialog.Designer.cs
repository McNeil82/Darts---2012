namespace Darts_2012
{
    partial class AroundTheClockDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AroundTheClockDialog));
            this.labelFrom = new System.Windows.Forms.Label();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.checkBoxSkip = new System.Windows.Forms.CheckBox();
            this.checkBoxJoker = new System.Windows.Forms.CheckBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxPlayerCount = new System.Windows.Forms.ComboBox();
            this.labelPlayerCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 9);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(25, 13);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "von";
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrom.DropDownWidth = 38;
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxFrom.Location = new System.Drawing.Point(43, 6);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(38, 21);
            this.comboBoxFrom.TabIndex = 2;
            this.comboBoxFrom.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFromSelectedIndexChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(88, 9);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 3;
            this.labelTo.Text = "bis";
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTo.DropDownWidth = 38;
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxTo.Location = new System.Drawing.Point(114, 6);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(38, 21);
            this.comboBoxTo.TabIndex = 4;
            // 
            // checkBoxSkip
            // 
            this.checkBoxSkip.AutoSize = true;
            this.checkBoxSkip.Location = new System.Drawing.Point(15, 33);
            this.checkBoxSkip.Name = "checkBoxSkip";
            this.checkBoxSkip.Size = new System.Drawing.Size(193, 17);
            this.checkBoxSkip.TabIndex = 5;
            this.checkBoxSkip.Text = "Überspringen bei Double und Triple";
            this.checkBoxSkip.UseVisualStyleBackColor = true;
            // 
            // checkBoxJoker
            // 
            this.checkBoxJoker.AutoSize = true;
            this.checkBoxJoker.Location = new System.Drawing.Point(15, 56);
            this.checkBoxJoker.Name = "checkBoxJoker";
            this.checkBoxJoker.Size = new System.Drawing.Size(164, 17);
            this.checkBoxJoker.TabIndex = 6;
            this.checkBoxJoker.Text = "Jocker bei Bull und Bull\'s Eye";
            this.checkBoxJoker.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(116, 230);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlayerCount
            // 
            this.comboBoxPlayerCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayerCount.DropDownWidth = 38;
            this.comboBoxPlayerCount.FormattingEnabled = true;
            this.comboBoxPlayerCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxPlayerCount.Location = new System.Drawing.Point(110, 79);
            this.comboBoxPlayerCount.Name = "comboBoxPlayerCount";
            this.comboBoxPlayerCount.Size = new System.Drawing.Size(38, 21);
            this.comboBoxPlayerCount.TabIndex = 9;
            // 
            // labelPlayerCount
            // 
            this.labelPlayerCount.AutoSize = true;
            this.labelPlayerCount.Location = new System.Drawing.Point(12, 82);
            this.labelPlayerCount.Name = "labelPlayerCount";
            this.labelPlayerCount.Size = new System.Drawing.Size(92, 13);
            this.labelPlayerCount.TabIndex = 10;
            this.labelPlayerCount.Text = "Anzahl der Spieler";
            // 
            // AroundTheClockDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.labelPlayerCount);
            this.Controls.Add(this.comboBoxPlayerCount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.checkBoxJoker);
            this.Controls.Add(this.checkBoxSkip);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.labelFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AroundTheClockDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AroundTheClockDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.CheckBox checkBoxSkip;
        private System.Windows.Forms.CheckBox checkBoxJoker;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxPlayerCount;
        private System.Windows.Forms.Label labelPlayerCount;
    }
}