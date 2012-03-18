namespace Darts_2012
{
    partial class Darts
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Darts));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.spielerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.board = new System.Windows.Forms.PictureBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spielerToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(984, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // spielerToolStripMenuItem
            // 
            this.spielerToolStripMenuItem.Name = "spielerToolStripMenuItem";
            this.spielerToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.spielerToolStripMenuItem.Text = "Spielerverwaltung";
            this.spielerToolStripMenuItem.Click += new System.EventHandler(this.SpielerToolStripMenuItemClick);
            // 
            // board
            // 
            this.board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Image = global::Darts_2012.Properties.Resources.board;
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(984, 965);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.board.TabIndex = 2;
            this.board.TabStop = false;
            this.board.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardPaint);
            this.board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoardMouseClick);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(13, 28);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.ReadOnly = true;
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 3;
            this.xTextBox.TabStop = false;
            this.xTextBox.Text = "0";
            this.xTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(119, 31);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 4;
            this.xLabel.Text = "X";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(13, 55);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.ReadOnly = true;
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 5;
            this.yTextBox.TabStop = false;
            this.yTextBox.Text = "0";
            this.yTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(119, 58);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 6;
            this.yLabel.Text = "Y";
            // 
            // Darts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(984, 965);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.board);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Darts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darts";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem spielerToolStripMenuItem;
        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label yLabel;



    }
}

