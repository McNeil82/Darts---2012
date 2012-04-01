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
            this.player3Panel = new System.Windows.Forms.Panel();
            this.player3CurrentTarget = new System.Windows.Forms.Label();
            this.player3CurrentTargetLabel = new System.Windows.Forms.Label();
            this.player3ThrowLights = new System.Windows.Forms.PictureBox();
            this.labelPlayer3Name = new System.Windows.Forms.Label();
            this.player4Panel = new System.Windows.Forms.Panel();
            this.player4CurrentTarget = new System.Windows.Forms.Label();
            this.player4CurrentTargetLabel = new System.Windows.Forms.Label();
            this.player4ThrowLights = new System.Windows.Forms.PictureBox();
            this.labelPlayer4Name = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.player1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player1ThrowLights)).BeginInit();
            this.player2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player2ThrowLights)).BeginInit();
            this.player3Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player3ThrowLights)).BeginInit();
            this.player4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player4ThrowLights)).BeginInit();
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
            // player3Panel
            // 
            this.player3Panel.Controls.Add(this.player3CurrentTarget);
            this.player3Panel.Controls.Add(this.player3CurrentTargetLabel);
            this.player3Panel.Controls.Add(this.player3ThrowLights);
            this.player3Panel.Controls.Add(this.labelPlayer3Name);
            this.player3Panel.Location = new System.Drawing.Point(1399, 27);
            this.player3Panel.Name = "player3Panel";
            this.player3Panel.Size = new System.Drawing.Size(500, 500);
            this.player3Panel.TabIndex = 6;
            this.player3Panel.Visible = false;
            // 
            // player3CurrentTarget
            // 
            this.player3CurrentTarget.AutoSize = true;
            this.player3CurrentTarget.Location = new System.Drawing.Point(91, 68);
            this.player3CurrentTarget.Name = "player3CurrentTarget";
            this.player3CurrentTarget.Size = new System.Drawing.Size(0, 13);
            this.player3CurrentTarget.TabIndex = 4;
            // 
            // player3CurrentTargetLabel
            // 
            this.player3CurrentTargetLabel.AutoSize = true;
            this.player3CurrentTargetLabel.Location = new System.Drawing.Point(4, 68);
            this.player3CurrentTargetLabel.Name = "player3CurrentTargetLabel";
            this.player3CurrentTargetLabel.Size = new System.Drawing.Size(87, 13);
            this.player3CurrentTargetLabel.TabIndex = 3;
            this.player3CurrentTargetLabel.Text = "zu treffende Zahl";
            // 
            // player3ThrowLights
            // 
            this.player3ThrowLights.Image = global::Darts_2012.Properties.Resources.noThrowLeft;
            this.player3ThrowLights.Location = new System.Drawing.Point(59, 4);
            this.player3ThrowLights.Name = "player3ThrowLights";
            this.player3ThrowLights.Size = new System.Drawing.Size(45, 15);
            this.player3ThrowLights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player3ThrowLights.TabIndex = 2;
            this.player3ThrowLights.TabStop = false;
            // 
            // labelPlayer3Name
            // 
            this.labelPlayer3Name.AutoSize = true;
            this.labelPlayer3Name.Location = new System.Drawing.Point(4, 4);
            this.labelPlayer3Name.Name = "labelPlayer3Name";
            this.labelPlayer3Name.Size = new System.Drawing.Size(48, 13);
            this.labelPlayer3Name.TabIndex = 0;
            this.labelPlayer3Name.Text = "Spieler 3";
            // 
            // player4Panel
            // 
            this.player4Panel.Controls.Add(this.player4CurrentTarget);
            this.player4Panel.Controls.Add(this.player4CurrentTargetLabel);
            this.player4Panel.Controls.Add(this.player4ThrowLights);
            this.player4Panel.Controls.Add(this.labelPlayer4Name);
            this.player4Panel.Location = new System.Drawing.Point(1399, 533);
            this.player4Panel.Name = "player4Panel";
            this.player4Panel.Size = new System.Drawing.Size(500, 500);
            this.player4Panel.TabIndex = 7;
            this.player4Panel.Visible = false;
            // 
            // player4CurrentTarget
            // 
            this.player4CurrentTarget.AutoSize = true;
            this.player4CurrentTarget.Location = new System.Drawing.Point(91, 68);
            this.player4CurrentTarget.Name = "player4CurrentTarget";
            this.player4CurrentTarget.Size = new System.Drawing.Size(0, 13);
            this.player4CurrentTarget.TabIndex = 4;
            // 
            // player4CurrentTargetLabel
            // 
            this.player4CurrentTargetLabel.AutoSize = true;
            this.player4CurrentTargetLabel.Location = new System.Drawing.Point(4, 68);
            this.player4CurrentTargetLabel.Name = "player4CurrentTargetLabel";
            this.player4CurrentTargetLabel.Size = new System.Drawing.Size(87, 13);
            this.player4CurrentTargetLabel.TabIndex = 3;
            this.player4CurrentTargetLabel.Text = "zu treffende Zahl";
            // 
            // player4ThrowLights
            // 
            this.player4ThrowLights.Image = global::Darts_2012.Properties.Resources.noThrowLeft;
            this.player4ThrowLights.Location = new System.Drawing.Point(59, 4);
            this.player4ThrowLights.Name = "player4ThrowLights";
            this.player4ThrowLights.Size = new System.Drawing.Size(45, 15);
            this.player4ThrowLights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player4ThrowLights.TabIndex = 2;
            this.player4ThrowLights.TabStop = false;
            // 
            // labelPlayer4Name
            // 
            this.labelPlayer4Name.AutoSize = true;
            this.labelPlayer4Name.Location = new System.Drawing.Point(4, 4);
            this.labelPlayer4Name.Name = "labelPlayer4Name";
            this.labelPlayer4Name.Size = new System.Drawing.Size(48, 13);
            this.labelPlayer4Name.TabIndex = 0;
            this.labelPlayer4Name.Text = "Spieler 4";
            // 
            // Darts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1045);
            this.Controls.Add(this.player4Panel);
            this.Controls.Add(this.player3Panel);
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
            this.player3Panel.ResumeLayout(false);
            this.player3Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player3ThrowLights)).EndInit();
            this.player4Panel.ResumeLayout(false);
            this.player4Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player4ThrowLights)).EndInit();
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
        private System.Windows.Forms.Panel player3Panel;
        private System.Windows.Forms.Label player3CurrentTarget;
        private System.Windows.Forms.Label player3CurrentTargetLabel;
        private System.Windows.Forms.PictureBox player3ThrowLights;
        private System.Windows.Forms.Label labelPlayer3Name;
        private System.Windows.Forms.Panel player4Panel;
        private System.Windows.Forms.Label player4CurrentTarget;
        private System.Windows.Forms.Label player4CurrentTargetLabel;
        private System.Windows.Forms.PictureBox player4ThrowLights;
        private System.Windows.Forms.Label labelPlayer4Name;



    }
}

