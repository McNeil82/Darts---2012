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
            this.player1Panel = new System.Windows.Forms.Panel();
            this.player1CurrentTarget = new System.Windows.Forms.Label();
            this.player1CurrentTargetLabel = new System.Windows.Forms.Label();
            this.player1ThrowLights = new System.Windows.Forms.PictureBox();
            this.labelPlayer1Name = new System.Windows.Forms.Label();
            this.player2Panel = new System.Windows.Forms.Panel();
            this.player2CurrentTarget = new System.Windows.Forms.Label();
            this.player2CurrentTargetLabel = new System.Windows.Forms.Label();
            this.player2ThrowLights = new System.Windows.Forms.PictureBox();
            this.labelPlayer2Name = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.player1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1ThrowLights)).BeginInit();
            this.player2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2ThrowLights)).BeginInit();
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
            // player1Panel
            // 
            this.player1Panel.Controls.Add(this.player1CurrentTarget);
            this.player1Panel.Controls.Add(this.player1CurrentTargetLabel);
            this.player1Panel.Controls.Add(this.player1ThrowLights);
            this.player1Panel.Controls.Add(this.labelPlayer1Name);
            this.player1Panel.Location = new System.Drawing.Point(12, 27);
            this.player1Panel.Name = "player1Panel";
            this.player1Panel.Size = new System.Drawing.Size(500, 500);
            this.player1Panel.TabIndex = 4;
            this.player1Panel.Visible = false;
            // 
            // player1CurrentTarget
            // 
            this.player1CurrentTarget.AutoSize = true;
            this.player1CurrentTarget.Location = new System.Drawing.Point(91, 68);
            this.player1CurrentTarget.Name = "player1CurrentTarget";
            this.player1CurrentTarget.Size = new System.Drawing.Size(0, 13);
            this.player1CurrentTarget.TabIndex = 3;
            // 
            // player1CurrentTargetLabel
            // 
            this.player1CurrentTargetLabel.AutoSize = true;
            this.player1CurrentTargetLabel.Location = new System.Drawing.Point(4, 68);
            this.player1CurrentTargetLabel.Name = "player1CurrentTargetLabel";
            this.player1CurrentTargetLabel.Size = new System.Drawing.Size(87, 13);
            this.player1CurrentTargetLabel.TabIndex = 2;
            this.player1CurrentTargetLabel.Text = "zu treffende Zahl";
            // 
            // player1ThrowLights
            // 
            this.player1ThrowLights.Image = global::Darts_2012.Properties.Resources.threeThrowsLeft;
            this.player1ThrowLights.Location = new System.Drawing.Point(59, 4);
            this.player1ThrowLights.Name = "player1ThrowLights";
            this.player1ThrowLights.Size = new System.Drawing.Size(45, 15);
            this.player1ThrowLights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player1ThrowLights.TabIndex = 1;
            this.player1ThrowLights.TabStop = false;
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
            // player2Panel
            // 
            this.player2Panel.Controls.Add(this.player2CurrentTarget);
            this.player2Panel.Controls.Add(this.player2CurrentTargetLabel);
            this.player2Panel.Controls.Add(this.player2ThrowLights);
            this.player2Panel.Controls.Add(this.labelPlayer2Name);
            this.player2Panel.Location = new System.Drawing.Point(12, 533);
            this.player2Panel.Name = "player2Panel";
            this.player2Panel.Size = new System.Drawing.Size(500, 500);
            this.player2Panel.TabIndex = 5;
            this.player2Panel.Visible = false;
            // 
            // player2CurrentTarget
            // 
            this.player2CurrentTarget.AutoSize = true;
            this.player2CurrentTarget.Location = new System.Drawing.Point(91, 68);
            this.player2CurrentTarget.Name = "player2CurrentTarget";
            this.player2CurrentTarget.Size = new System.Drawing.Size(0, 13);
            this.player2CurrentTarget.TabIndex = 4;
            // 
            // player2CurrentTargetLabel
            // 
            this.player2CurrentTargetLabel.AutoSize = true;
            this.player2CurrentTargetLabel.Location = new System.Drawing.Point(4, 68);
            this.player2CurrentTargetLabel.Name = "player2CurrentTargetLabel";
            this.player2CurrentTargetLabel.Size = new System.Drawing.Size(87, 13);
            this.player2CurrentTargetLabel.TabIndex = 3;
            this.player2CurrentTargetLabel.Text = "zu treffende Zahl";
            // 
            // player2ThrowLights
            // 
            this.player2ThrowLights.Image = global::Darts_2012.Properties.Resources.noThrowLeft;
            this.player2ThrowLights.Location = new System.Drawing.Point(59, 4);
            this.player2ThrowLights.Name = "player2ThrowLights";
            this.player2ThrowLights.Size = new System.Drawing.Size(45, 15);
            this.player2ThrowLights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player2ThrowLights.TabIndex = 2;
            this.player2ThrowLights.TabStop = false;
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
            // Darts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1045);
            this.Controls.Add(this.player2Panel);
            this.Controls.Add(this.player1Panel);
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
            this.player1Panel.ResumeLayout(false);
            this.player1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1ThrowLights)).EndInit();
            this.player2Panel.ResumeLayout(false);
            this.player2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2ThrowLights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem playerManagementToolStripMenuItem;
        private System.Windows.Forms.PictureBox boardPictureBox;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aroundTheClockToolStripMenuItem;
        private System.Windows.Forms.Panel player1Panel;
        private System.Windows.Forms.Label labelPlayer1Name;
        private System.Windows.Forms.Panel player2Panel;
        private System.Windows.Forms.Label labelPlayer2Name;
        private System.Windows.Forms.PictureBox player1ThrowLights;
        private System.Windows.Forms.PictureBox player2ThrowLights;
        private System.Windows.Forms.Label player1CurrentTarget;
        private System.Windows.Forms.Label player1CurrentTargetLabel;
        private System.Windows.Forms.Label player2CurrentTarget;
        private System.Windows.Forms.Label player2CurrentTargetLabel;



    }
}

