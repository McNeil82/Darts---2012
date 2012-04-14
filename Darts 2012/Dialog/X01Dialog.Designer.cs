namespace Darts_2012.Dialog
{
    partial class X01Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(X01Dialog));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxScoreToBeginWith = new System.Windows.Forms.ComboBox();
            this.labelScoreToBeginWith = new System.Windows.Forms.Label();
            this.checkBoxDoubleIn = new System.Windows.Forms.CheckBox();
            this.radioButtonMasterOut = new System.Windows.Forms.RadioButton();
            this.radioButtonDoubleOut = new System.Windows.Forms.RadioButton();
            this.radioButtonStraightOut = new System.Windows.Forms.RadioButton();
            this.labelPlayerCount = new System.Windows.Forms.Label();
            this.comboBoxPlayerCount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(197, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(116, 230);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // comboBoxScoreToBeginWith
            // 
            this.comboBoxScoreToBeginWith.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScoreToBeginWith.DropDownWidth = 38;
            this.comboBoxScoreToBeginWith.FormattingEnabled = true;
            this.comboBoxScoreToBeginWith.Items.AddRange(new object[] {
            "301",
            "401",
            "501",
            "601",
            "701",
            "801",
            "901",
            "1001"});
            this.comboBoxScoreToBeginWith.Location = new System.Drawing.Point(97, 6);
            this.comboBoxScoreToBeginWith.Name = "comboBoxScoreToBeginWith";
            this.comboBoxScoreToBeginWith.Size = new System.Drawing.Size(48, 21);
            this.comboBoxScoreToBeginWith.TabIndex = 11;
            // 
            // labelScoreToBeginWith
            // 
            this.labelScoreToBeginWith.AutoSize = true;
            this.labelScoreToBeginWith.Location = new System.Drawing.Point(12, 9);
            this.labelScoreToBeginWith.Name = "labelScoreToBeginWith";
            this.labelScoreToBeginWith.Size = new System.Drawing.Size(79, 13);
            this.labelScoreToBeginWith.TabIndex = 12;
            this.labelScoreToBeginWith.Text = "Anfangspunkte";
            // 
            // checkBoxDoubleIn
            // 
            this.checkBoxDoubleIn.AutoSize = true;
            this.checkBoxDoubleIn.Location = new System.Drawing.Point(15, 33);
            this.checkBoxDoubleIn.Name = "checkBoxDoubleIn";
            this.checkBoxDoubleIn.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDoubleIn.TabIndex = 13;
            this.checkBoxDoubleIn.Text = "Double In";
            this.checkBoxDoubleIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasterOut
            // 
            this.radioButtonMasterOut.AutoSize = true;
            this.radioButtonMasterOut.Location = new System.Drawing.Point(15, 57);
            this.radioButtonMasterOut.Name = "radioButtonMasterOut";
            this.radioButtonMasterOut.Size = new System.Drawing.Size(77, 17);
            this.radioButtonMasterOut.TabIndex = 14;
            this.radioButtonMasterOut.Text = "Master Out";
            this.radioButtonMasterOut.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoubleOut
            // 
            this.radioButtonDoubleOut.AutoSize = true;
            this.radioButtonDoubleOut.Location = new System.Drawing.Point(15, 81);
            this.radioButtonDoubleOut.Name = "radioButtonDoubleOut";
            this.radioButtonDoubleOut.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDoubleOut.TabIndex = 15;
            this.radioButtonDoubleOut.Text = "Double Out";
            this.radioButtonDoubleOut.UseVisualStyleBackColor = true;
            // 
            // radioButtonStraightOut
            // 
            this.radioButtonStraightOut.AutoSize = true;
            this.radioButtonStraightOut.Checked = true;
            this.radioButtonStraightOut.Location = new System.Drawing.Point(15, 104);
            this.radioButtonStraightOut.Name = "radioButtonStraightOut";
            this.radioButtonStraightOut.Size = new System.Drawing.Size(81, 17);
            this.radioButtonStraightOut.TabIndex = 16;
            this.radioButtonStraightOut.TabStop = true;
            this.radioButtonStraightOut.Text = "Straight Out";
            this.radioButtonStraightOut.UseVisualStyleBackColor = true;
            // 
            // labelPlayerCount
            // 
            this.labelPlayerCount.AutoSize = true;
            this.labelPlayerCount.Location = new System.Drawing.Point(12, 124);
            this.labelPlayerCount.Name = "labelPlayerCount";
            this.labelPlayerCount.Size = new System.Drawing.Size(92, 13);
            this.labelPlayerCount.TabIndex = 18;
            this.labelPlayerCount.Text = "Anzahl der Spieler";
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
            this.comboBoxPlayerCount.Location = new System.Drawing.Point(110, 121);
            this.comboBoxPlayerCount.Name = "comboBoxPlayerCount";
            this.comboBoxPlayerCount.Size = new System.Drawing.Size(38, 21);
            this.comboBoxPlayerCount.TabIndex = 17;
            // 
            // X01Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.labelPlayerCount);
            this.Controls.Add(this.comboBoxPlayerCount);
            this.Controls.Add(this.radioButtonStraightOut);
            this.Controls.Add(this.radioButtonDoubleOut);
            this.Controls.Add(this.radioButtonMasterOut);
            this.Controls.Add(this.checkBoxDoubleIn);
            this.Controls.Add(this.labelScoreToBeginWith);
            this.Controls.Add(this.comboBoxScoreToBeginWith);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "X01Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "X01 Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboBoxScoreToBeginWith;
        private System.Windows.Forms.Label labelScoreToBeginWith;
        private System.Windows.Forms.CheckBox checkBoxDoubleIn;
        private System.Windows.Forms.RadioButton radioButtonMasterOut;
        private System.Windows.Forms.RadioButton radioButtonDoubleOut;
        private System.Windows.Forms.RadioButton radioButtonStraightOut;
        private System.Windows.Forms.Label labelPlayerCount;
        private System.Windows.Forms.ComboBox comboBoxPlayerCount;
    }
}