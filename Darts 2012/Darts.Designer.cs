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
            this.playerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardPictureBox = new System.Windows.Forms.PictureBox();
            this.pointsTextBox = new System.Windows.Forms.TextBox();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aroundTheClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
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
            this.pointsTextBox.Location = new System.Drawing.Point(13, 28);
            this.pointsTextBox.Name = "pointsTextBox";
            this.pointsTextBox.ReadOnly = true;
            this.pointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.pointsTextBox.TabIndex = 3;
            this.pointsTextBox.Text = "0";
            this.pointsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // Darts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1045);
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



    }
}

