/*
 * Written by NitroFire and Silent is Here
 * Last Updated 11/23/2021 8:37PM EST
 * https://discord.gg/snstr
 * 
 * P.S. Fuck you Rin for going back on everything you stood for ;) [Edited]
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using System.Net;
using NitroFire.VRCModManager.VRCModManager.Utils;

namespace NitroFire.VRCModManager
{
    public partial class Main : Form
    {
        public static ConsoleControl.ConsoleControl FormConsole { get; set; }
        public static Thread Thread { get; } = Thread.CurrentThread;
        public static float Version { get; } = 0.1f;
        public static List<Mods> AvailableMods { get; set; }

        /// <summary>
        /// 
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public void FetchAvailableMods()
        {
            AvailableModsListBox.Items.Clear();
            AvailableMods = JsonSerializer.Deserialize<List<Mods>>(ModList.JSON,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            foreach ((object mod, int i) in AvailableMods.Select((value, i) => (value, i)))
                AvailableModsListBox.Items.Add(AvailableMods[@i].Name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FConsole_Load(object sender, EventArgs e)
        {
            FormConsole.WriteOutputLn(Text + "\n\t\thttps://discord.gg/snstr" + ConsoleUtils.ConsoleDivider, Color.Cyan);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstalledModsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FileVersionInfo selectedModVersion = FileVersionInfo.GetVersionInfo(Registry.VRChatPath +
                @"\Mods\" + InstalledModsListBox.SelectedItem.ToString());

                FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider + InstalledModsListBox.SelectedItem.ToString() + ":" + ConsoleUtils.ConsoleDivider +
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
                    "\nChangelog: " + "null" +
                    "\nInstall Status: " + "null");

                FormConsole.InternalRichTextBox.ScrollToCaret();
            }
            catch (NullReferenceException ex) { FormConsole.WriteOutputLn("\n[ERROR]: " + ex.Message, Color.Red); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AvailableModsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < AvailableMods.Count; i++)
                {
                    if (AvailableMods[i].Name == AvailableModsListBox.SelectedItem.ToString())
                    {
                        FormConsole.WriteOutputLn("\n" + ConsoleUtils.ConsoleDivider + "\n" + AvailableModsListBox.SelectedItem.ToString() + ":" + ConsoleUtils.ConsoleDivider +
                            "\nVersion: "             + AvailableMods[i].Versions[0]._Version       +
                            "\nVRChat Version: "      + AvailableMods[i].Versions[0].VRChatVersion  +
                            "\nMelonloader Version: " + AvailableMods[i].Versions[0].LoaderVersion  +
                            "\nType: "                + AvailableMods[i].Versions[0].ModType        +
                            "\nAuthor: "              + AvailableMods[i].Versions[0].Author         +
                            "\nMod Description: "     + AvailableMods[i].Versions[0].Description    +
                            "\nRepository: "          + AvailableMods[i].Versions[0].SourceLink     +
                            "\nLast Updated: "        + AvailableMods[i].Versions[0].UpdateDate     +
                            "\nBase64 Hash: "         + AvailableMods[i].Versions[0].Hash           +
                            "\nChangelog: "           + AvailableMods[i].Versions[0].Changelog      +
                            "\nInstall Status: "      + AvailableMods[i].IsInstalled);

                        FormConsole.InternalRichTextBox.ScrollToCaret();
                    }
                }
            }
            catch (NullReferenceException ex) { FormConsole.WriteOutputLn("\n[ERROR]: " + ex.Message, Color.Red); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InstallModButton_Click(object sender, EventArgs e)
        {
            if (AvailableModsListBox.SelectedItem != null)
            {
                Mods mod = AvailableMods[AvailableModsListBox.SelectedIndex];
                if (mod.IsInstalled)
                    return;

                using WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(mod.Versions[0].DownloadLink);
                string path = mod.Versions[0].ModType == "Mod" || mod.Versions[0].ModType == "Normal"
                    ? $@"{Registry.VRChatPath}\Mods" : $@"{Registry.VRChatPath}\Plugins";
                path += $@"\{mod.Versions[0].DownloadLink.Split("/").Last()}";

                if (!File.Exists(path) && Utils.ComputeSHA256(data, mod.Versions[0].Hash) == mod.Versions[0].Hash)
                {
                    using (FileStream fs = File.Create(path)) { foreach (byte b in data) fs.WriteByte(b); }
                    mod.IsInstalled = true;

                    FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.LightGreen);
                    FormConsole.WriteOutput($"{path} Installed Successfully!", Color.LightGreen);
                    FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.LightGreen);
                }
                else
                {
                    FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.Red);
                    FormConsole.WriteOutputLn($"[ERROR]: {mod.Name} Couldn't be Installed!", Color.Red);
                    FormConsole.WriteOutput($"{path} Not Found!", Color.Red);
                    FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.Red);
                }
            }
            else FormConsole.WriteOutputLn("[ERROR]: Please select a mod first!", Color.Red);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshPictureBox_Click(object sender, EventArgs e)
        {
            FormConsole.ClearOutput();
            FormConsole.WriteOutputLn(Text + ConsoleUtils.ConsoleDivider, Color.Cyan);

            InstalledModsListBox.Items.Clear();
            foreach (string mod in Mods.GetInstalledMods())
                InstalledModsListBox.Items.Add(mod);
            InstalledModsListBox.Refresh();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchVRChatButton_Click(object sender, EventArgs e)
        {
            Process vrc = new Process();
            vrc.StartInfo.FileName = Registry.VRChatPath + @"\vrchat.exe";
            vrc.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiscordToolStripMenuItem_Click(object sender, EventArgs e) =>
            Process.Start("cmd", $"/{Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).Substring(0, 1)} start https://discord.com/invite/snstr/");

        private void UninstallModButton_Click(object sender, EventArgs e)
        {
            switch(ModsTabControl.SelectedIndex)
            {
                // Installed Mods Tab
                case 0: 
                    if(InstalledModsListBox.SelectedItem != null)
                    {
                        Mods mod = AvailableMods[InstalledModsListBox.SelectedIndex];
                        string path = mod.Versions[0].ModType == "Mod" || mod.Versions[0].ModType == "Normal"
                            ? $@"{Registry.VRChatPath}\Mods" : $@"{Registry.VRChatPath}\Plugins";
                        path += $@"\{mod.Versions[0].DownloadLink.Split("/").Last()}";

                        File.Delete(path);

                        FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.LightYellow);
                        FormConsole.WriteOutput($"{path} Uninstalled Successfully!", Color.LightYellow);
                        FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.LightYellow);

                        InstalledModsListBox.Refresh();
                    }
                    else FormConsole.WriteOutputLn("[ERROR]: Please select a mod first!", Color.Red);
                    break;

                // Available Mods Tab
                case 1:
                    if (AvailableModsListBox.SelectedItem != null)
                    {
                        Mods mod = AvailableMods[AvailableModsListBox.SelectedIndex];
                        string path = mod.Versions[0].ModType == "Mod" || mod.Versions[0].ModType == "Normal"
                            ? $@"{Registry.VRChatPath}\Mods" : $@"{Registry.VRChatPath}\Plugins";
                        path += $@"\{mod.Versions[0].DownloadLink.Split("/").Last()}";

                        File.Delete(path);

                        FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.LightYellow);
                        FormConsole.WriteOutput($"{path} Uninstalled Successfully!", Color.LightYellow);
                        FormConsole.WriteOutputLn(ConsoleUtils.ConsoleDivider, Color.LightYellow);

                        AvailableModsListBox.Refresh();
                    }
                    else FormConsole.WriteOutputLn("[ERROR]: Please select a mod first!", Color.Red);
                    break;

                // Updates Available Tab
                case 2:

                    break;

                // TODO: Make this error message a bit more detailed
                default: FormConsole.WriteOutputLn("[ERROR]: An Error Occured!", Color.Red); break; 
            }
        }
    }
}