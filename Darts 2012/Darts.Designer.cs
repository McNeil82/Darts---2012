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
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aroundTheClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardPictureBox = new System.Windows.Forms.PictureBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.pictureBoxPlayer1Throws = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer2Throws = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.panelPlayer1.SuspendLayout();
            this.panelPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Throws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Throws)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.playerManagementToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1904, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aroundTheClockToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.gameToolStripMenuItem.Text = "Spiel";
            // 
            // aroundTheClockToolStripMenuItem
            // 
            this.aroundTheClockToolStripMenuItem.Name = "aroundTheClockToolStripMenuItem";
            this.aroundTheClockToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aroundTheClockToolStripMenuItem.Text = "Around The Clock";
            this.aroundTheClockToolStripMenuItem.Click += new System.EventHandler(this.AroundTheClockToolStripMenuItemClick);
            // 
            // playerManagementToolStripMenuItem
            // 
            this.playerManagementToolStripMenuItem.Name = "playerManagementToolStripMenuItem";
            this.playerManagementToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.playerManagementToolStripMenuItem.Text = "Spielerverwaltung";
            this.playerManagementToolStripMenuItem.Click += new System.EventHandler(this.SpielerToolStripMenuItemClick);
            // 
            // boardPictureBox
            // 
            this.boardPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boardPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPictureBox.Image = global::Darts_2012.Properties.Resources.board;
            this.boardPictureBox.Location = new System.Drawing.Point(0, 0);
            this.boardPictureBox.Name = "boardPictureBox";
            this.boardPictureBox.Size = new System.Drawing.Size(1904, 1045);
            this.boardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boardPictureBox.TabIndex = 2;
            this.boardPictureBox.TabStop = false;
            this.boardPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BoardMouseClick);
            // 
            // pointsTextBox
            // 
            this.pointsTextBox.Location = new System.Drawing.Point(893, 48);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.ReadOnly = true;
            this.pointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.pointsTextBox.TabIndex = 3;
            this.pointsTextBox.Text = "0";
            this.pointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.Controls.Add(this.pictureBoxPlayer1Throws);
            this.panelPlayer1.Controls.Add(this.labelPlayer1Name);
            this.panelPlayer1.Location = new System.Drawing.Point(12, 27);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(500, 500);
            this.panelPlayer1.TabIndex = 4;
            this.panelPlayer1.Visible = false;
            // 
            // labelPlayer1Name
            // 
            this.labelPlayer1Name.AutoSize = true;
            this.labelPlayer1Name.Location = new System.Drawing.Point(4, 4);
            this.labelPlayer1Name.Name = "labelPlayer1Name";
            this.labelPlayer1Name.Size = new System.Drawing.Size(48, 13);
            this.labelPlayer1Name.TabIndex = 0;
            this.labelPlayer1Name.Text = "Spieler 1";
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.Controls.Add(this.pictureBoxPlayer2Throws);
            this.panelPlayer2.Controls.Add(this.labelPlayer2Name);
            this.panelPlayer2.Location = new System.Drawing.Point(12, 533);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(500, 500);
            this.panelPlayer2.TabIndex = 5;
            this.panelPlayer2.Visible = false;
            // 
            // labelPlayer2Name
            // 
            this.labelPlayer2Name.AutoSize = true;
            this.labelPlayer2Name.Location = new System.Drawing.Point(4, 4);
            this.labelPlayer2Name.Name = "labelPlayer2Name";
            this.labelPlayer2Name.Size = new System.Drawing.Size(48, 13);
            this.labelPlayer2Name.TabIndex = 0;
            this.labelPlayer2Name.Text = "Spieler 2";
            // 
            // pictureBoxPlayer1Throws
            // 
            this.pictureBoxPlayer1Throws.Image = global::Darts_2012.Properties.Resources.threeThrowsLeft;
            this.pictureBoxPlayer1Throws.Location = new System.Drawing.Point(59, 4);
            this.pictureBoxPlayer1Throws.Name = "pictureBoxPlayer1Throws";
            this.pictureBoxPlayer1Throws.Size = new System.Drawing.Size(45, 15);
            this.pictureBoxPlayer1Throws.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlayer1Throws.TabIndex = 1;
            this.pictureBoxPlayer1Throws.TabStop = false;
            // 
            // pictureBoxPlayer2Throws
            // 
            this.pictureBoxPlayer2Throws.Image = global::Darts_2012.Properties.Resources.noThrowLeft;
            this.pictureBoxPlayer2Throws.Location = new System.Drawing.Point(59, 4);
            this.pictureBoxPlayer2Throws.Name = "pictureBoxPlayer2Throws";
            this.pictureBoxPlayer2Throws.Size = new System.Drawing.Size(45, 15);
            this.pictureBoxPlayer2Throws.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPlayer2Throws.TabIndex = 2;
            this.pictureBoxPlayer2Throws.TabStop = false;
            // 
            // Darts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1045);
            this.Controls.Add(this.panelPlayer2);
            this.Controls.Add(this.panelPlayer1);
            this.Controls.Add(this.pointsTextBox);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.boardPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Darts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).EndInit();
            this.panelPlayer1.ResumeLayout(false);
            this.panelPlayer1.PerformLayout();
            this.panelPlayer2.ResumeLayout(false);
            this.panelPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer1Throws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer2Throws)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem playerManagementToolStripMenuItem;
        private System.Windows.Forms.PictureBox boardPictureBox;
        private System.Windows.Forms.TextBox pointsTextBox;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aroundTheClockToolStripMenuItem;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.PictureBox pictureBoxPlayer1Throws;
        private System.Windows.Forms.PictureBox pictureBoxPlayer2Throws;



    }
}

