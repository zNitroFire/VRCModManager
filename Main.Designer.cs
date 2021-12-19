
namespace NitroFire.VRCModManager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RefreshPictureBox = new System.Windows.Forms.PictureBox();
            this.UninstallModButton = new DarkUI.Controls.DarkButton();
            this.InstallModButton = new DarkUI.Controls.DarkButton();
            this.LaunchVRChatButton = new DarkUI.Controls.DarkButton();
            this.ModsPanel = new System.Windows.Forms.Panel();
            this.ModsTabControl = new Manina.Windows.Forms.TabControl();
            this.InstalledModsTab = new Manina.Windows.Forms.Tab();
            this.InstalledModsListBox = new System.Windows.Forms.ListBox();
            this.AvailableModsTab = new Manina.Windows.Forms.Tab();
            this.AvailableModsListBox = new System.Windows.Forms.ListBox();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.FConsole = new ConsoleControl.ConsoleControl();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DiscordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).BeginInit();
            this.ModsPanel.SuspendLayout();
            this.ModsTabControl.SuspendLayout();
            this.InstalledModsTab.SuspendLayout();
            this.AvailableModsTab.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MainPanel.Controls.Add(this.RefreshPictureBox);
            this.MainPanel.Controls.Add(this.UninstallModButton);
            this.MainPanel.Controls.Add(this.InstallModButton);
            this.MainPanel.Controls.Add(this.LaunchVRChatButton);
            this.MainPanel.Controls.Add(this.ModsPanel);
            this.MainPanel.Controls.Add(this.ConsolePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // RefreshPictureBox
            // 
            this.RefreshPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.RefreshPictureBox.BackgroundImage = global::NitroFire.VRCModManager.Properties.Resources.RefreshButton;
            this.RefreshPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshPictureBox.InitialImage = null;
            this.RefreshPictureBox.Location = new System.Drawing.Point(297, 393);
            this.RefreshPictureBox.Name = "RefreshPictureBox";
            this.RefreshPictureBox.Size = new System.Drawing.Size(53, 53);
            this.RefreshPictureBox.TabIndex = 8;
            this.RefreshPictureBox.TabStop = false;
            this.RefreshPictureBox.Click += new System.EventHandler(this.RefreshPictureBox_Click);
            // 
            // UninstallModButton
            // 
            this.UninstallModButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UninstallModButton.Location = new System.Drawing.Point(179, 348);
            this.UninstallModButton.Name = "UninstallModButton";
            this.UninstallModButton.Padding = new System.Windows.Forms.Padding(5);
            this.UninstallModButton.Size = new System.Drawing.Size(171, 38);
            this.UninstallModButton.TabIndex = 6;
            this.UninstallModButton.Text = "Uninstall Selected Mod";
            this.UninstallModButton.Click += new System.EventHandler(this.UninstallModButton_Click);
            // 
            // InstallModButton
            // 
            this.InstallModButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstallModButton.Location = new System.Drawing.Point(3, 348);
            this.InstallModButton.Name = "InstallModButton";
            this.InstallModButton.Padding = new System.Windows.Forms.Padding(5);
            this.InstallModButton.Size = new System.Drawing.Size(171, 38);
            this.InstallModButton.TabIndex = 5;
            this.InstallModButton.Text = "Install Selected Mod";
            this.InstallModButton.Click += new System.EventHandler(this.InstallModButton_Click);
            // 
            // LaunchVRChatButton
            // 
            this.LaunchVRChatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LaunchVRChatButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.LaunchVRChatButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LaunchVRChatButton.Location = new System.Drawing.Point(3, 393);
            this.LaunchVRChatButton.Name = "LaunchVRChatButton";
            this.LaunchVRChatButton.Padding = new System.Windows.Forms.Padding(5);
            this.LaunchVRChatButton.Size = new System.Drawing.Size(288, 53);
            this.LaunchVRChatButton.TabIndex = 4;
            this.LaunchVRChatButton.Text = "Launch VRChat";
            this.LaunchVRChatButton.Click += new System.EventHandler(this.LaunchVRChatButton_Click);
            // 
            // ModsPanel
            // 
            this.ModsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModsPanel.Controls.Add(this.ModsTabControl);
            this.ModsPanel.Location = new System.Drawing.Point(3, 27);
            this.ModsPanel.Name = "ModsPanel";
            this.ModsPanel.Size = new System.Drawing.Size(347, 315);
            this.ModsPanel.TabIndex = 3;
            // 
            // ModsTabControl
            // 
            this.ModsTabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ModsTabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModsTabControl.Controls.Add(this.InstalledModsTab);
            this.ModsTabControl.Controls.Add(this.AvailableModsTab);
            this.ModsTabControl.Location = new System.Drawing.Point(0, -1);
            this.ModsTabControl.Name = "ModsTabControl";
            this.ModsTabControl.SelectedIndex = 0;
            this.ModsTabControl.Size = new System.Drawing.Size(344, 361);
            this.ModsTabControl.TabIndex = 1;
            this.ModsTabControl.Tabs.Add(this.InstalledModsTab);
            this.ModsTabControl.Tabs.Add(this.AvailableModsTab);
            this.ModsTabControl.TabClick += new System.EventHandler<Manina.Windows.Forms.TabMouseEventArgs>(this.RefreshPictureBox_Click);
            // 
            // InstalledModsTab
            // 
            this.InstalledModsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.InstalledModsTab.Controls.Add(this.InstalledModsListBox);
            this.InstalledModsTab.ForeColor = System.Drawing.Color.Silver;
            this.InstalledModsTab.Location = new System.Drawing.Point(0, 23);
            this.InstalledModsTab.Name = "InstalledModsTab";
            this.InstalledModsTab.Size = new System.Drawing.Size(344, 339);
            this.InstalledModsTab.Text = "Installed Mods";
            // 
            // InstalledModsListBox
            // 
            this.InstalledModsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.InstalledModsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstalledModsListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstalledModsListBox.ForeColor = System.Drawing.Color.Silver;
            this.InstalledModsListBox.FormattingEnabled = true;
            this.InstalledModsListBox.ItemHeight = 20;
            this.InstalledModsListBox.Location = new System.Drawing.Point(0, 6);
            this.InstalledModsListBox.Name = "InstalledModsListBox";
            this.InstalledModsListBox.Size = new System.Drawing.Size(342, 280);
            this.InstalledModsListBox.Sorted = true;
            this.InstalledModsListBox.TabIndex = 0;
            this.InstalledModsListBox.SelectedIndexChanged += new System.EventHandler(this.InstalledModsListBox_SelectedIndexChanged);
            // 
            // AvailableModsTab
            // 
            this.AvailableModsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.AvailableModsTab.Controls.Add(this.AvailableModsListBox);
            this.AvailableModsTab.ForeColor = System.Drawing.Color.Silver;
            this.AvailableModsTab.Location = new System.Drawing.Point(0, 0);
            this.AvailableModsTab.Name = "AvailableModsTab";
            this.AvailableModsTab.Size = new System.Drawing.Size(0, 0);
            this.AvailableModsTab.Text = "Available Mods";
            // 
            // AvailableModsListBox
            // 
            this.AvailableModsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.AvailableModsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AvailableModsListBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AvailableModsListBox.ForeColor = System.Drawing.Color.Silver;
            this.AvailableModsListBox.FormattingEnabled = true;
            this.AvailableModsListBox.ItemHeight = 20;
            this.AvailableModsListBox.Location = new System.Drawing.Point(-1, 1);
            this.AvailableModsListBox.Name = "AvailableModsListBox";
            this.AvailableModsListBox.Size = new System.Drawing.Size(347, 260);
            this.AvailableModsListBox.Sorted = true;
            this.AvailableModsListBox.TabIndex = 0;
            this.AvailableModsListBox.SelectedIndexChanged += new System.EventHandler(this.AvailableModsListBox_SelectedIndexChanged);
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConsolePanel.Controls.Add(this.FConsole);
            this.ConsolePanel.Location = new System.Drawing.Point(356, 27);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(441, 419);
            this.ConsolePanel.TabIndex = 1;
            // 
            // FConsole
            // 
            this.FConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FConsole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FConsole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FConsole.ForeColor = System.Drawing.Color.White;
            this.FConsole.IsInputEnabled = false;
            this.FConsole.Location = new System.Drawing.Point(-2, -3);
            this.FConsole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FConsole.Name = "FConsole";
            this.FConsole.SendKeyboardCommandsToProcess = false;
            this.FConsole.ShowDiagnostics = false;
            this.FConsole.Size = new System.Drawing.Size(445, 422);
            this.FConsole.TabIndex = 0;
            this.FConsole.Load += new System.EventHandler(this.FConsole_Load);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 1;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.aboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorsToolStripMenuItem,
            this.DiscordToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // AuthorsToolStripMenuItem
            // 
            this.AuthorsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.AuthorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AuthorsToolStripMenuItem.Name = "AuthorsToolStripMenuItem";
            this.AuthorsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AuthorsToolStripMenuItem.Text = "Authors";
            // 
            // DiscordToolStripMenuItem
            // 
            this.DiscordToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.DiscordToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DiscordToolStripMenuItem.Name = "DiscordToolStripMenuItem";
            this.DiscordToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.DiscordToolStripMenuItem.Text = "Discord";
            this.DiscordToolStripMenuItem.Click += new System.EventHandler(this.DiscordToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "VRCModManger vX.X - by NitroFire and SilentIsHere";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefreshPictureBox)).EndInit();
            this.ModsPanel.ResumeLayout(false);
            this.ModsTabControl.ResumeLayout(false);
            this.InstalledModsTab.ResumeLayout(false);
            this.AvailableModsTab.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ConsoleControl.ConsoleControl FConsole;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.Panel ModsPanel;
        private Manina.Windows.Forms.TabControl ModsTabControl;
        private Manina.Windows.Forms.Tab InstalledModsTab;
        private Manina.Windows.Forms.Tab AvailableModsTab;
        private DarkUI.Controls.DarkButton LaunchVRChatButton;
        private System.Windows.Forms.ToolStripMenuItem AuthorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DiscordToolStripMenuItem;
        private System.Windows.Forms.ListBox InstalledModsListBox;
        private DarkUI.Controls.DarkButton UninstallModButton;
        private DarkUI.Controls.DarkButton InstallModButton;
        private System.Windows.Forms.PictureBox RefreshPictureBox;
        private System.Windows.Forms.ListBox AvailableModsListBox;
    }
}

