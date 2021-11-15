/*
 * Written by NitroFire and Silent is Here
 * Last Updated 11/14/2021 9:46PM EST
 * https://discord.gg/snstr
 * 
 * P.S. Fuck you Rin for selling your soul to Knah and the VRChat developers ;)
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.Json;

namespace VRCModManager
{
    public partial class Main : Form
    {
        public static ConsoleControl.ConsoleControl FormConsole { get; set; }
        public static Thread Thread { get; } = Thread.CurrentThread;
        public static float Version { get; } = 0.1f;

        public Main()
        {
            InitializeComponent();
            // TODO: Create Thread-Safety rather than
            // disabling these checks for illegal cross thread calls.
            // 100% memory leak :sunglasses:
            CheckForIllegalCrossThreadCalls = false;
            FormConsole = FConsole;
            Text = $"VRCModManager v{Version} - by NitroFire and SilentIsHere";

            FetchAvailableMods();
            foreach (string mod in Mods.GetInstalledMods())
                InstalledModsListBox.Items.Add(mod);
        }

        public void FetchAvailableMods()
        {
            List<Mods> availableMods = JsonSerializer.Deserialize<List<Mods>>(ModList.JSON, 
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            for(int i = 0; i < availableMods.Count; i++)
                AvailableModsListBox.Items.Add(availableMods[i].Name);
        }

        private void FConsole_Load(object sender, EventArgs e)
        {
            FormConsole.WriteOutputLn(Text + Util.ConsoleDivider, Color.Cyan);
        }

        private void InstalledModsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileVersionInfo selectedModVersion = FileVersionInfo.GetVersionInfo(Registry.VRChatPath +
                @"\Mods\" + InstalledModsListBox.SelectedItem.ToString());

                FormConsole.WriteOutputLn(Util.ConsoleDivider + InstalledModsListBox.SelectedItem.ToString() + ":" + Util.ConsoleDivider +
                    "\nVersion: " + selectedModVersion.FileVersion.ToString() +
                    "\nVRChat Version: " + "null" +
                    "\nMelonloader Version: " + "null" +
                    "\nType: " + "null" +
                    "\nAuthor: " + "null" +
                    "\nMod Description: " + "null" +
                    "\nFile Description: " + selectedModVersion.FileDescription.ToString() +
                    "\nRepository: " + "null" +
                    "\nLast Updated: " + "null" +
                    "\nBase64 Hash: " + "null" +
                    "\nChangelog: " + "null");

                FormConsole.InternalRichTextBox.ScrollToCaret();
            }
            catch (NullReferenceException ex) { FormConsole.WriteOutputLn("\n[ERROR]: " + ex.Message, Color.Red); }
        }

        private void RefreshPictureBox_Click(object sender, EventArgs e)
        {
            FormConsole.ClearOutput();
            FormConsole.WriteOutputLn(Text + Util.ConsoleDivider, Color.Cyan);

            InstalledModsListBox.Items.Clear();
            foreach (string mod in Mods.GetInstalledMods())
                InstalledModsListBox.Items.Add(mod);
            InstalledModsListBox.Refresh();
        }

        private void LaunchVRChatButton_Click(object sender, EventArgs e)
        {
            Process vrc = new Process();
            vrc.StartInfo.FileName = Registry.VRChatPath + @"\vrchat.exe";
            vrc.Start();
        }

        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e) =>
            Process.Start("cmd", $"/{Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).Substring(0, 1)} start https://discord.com/invite/snstr/");
    }
}