using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace NitroFire.VRCModManager
{
    /// <summary>
    /// 
    /// </summary>
    public class Mods
    {
        // TODO: Finish the install status in the console
        private bool _isInstalled = false;

        public string Name { get; set; }
        public Versions[] Versions { get; set; }
        public bool IsInstalled { get => GetIsInstalled(); set => _isInstalled = value; }

        public static List<string> GetInstalledMods()
        {
            List<string> Mods = new List<string>();
            if(Directory.Exists(Registry.VRChatPath + @"\Mods") && Directory.Exists(Registry.VRChatPath + @"\Plugins"))
            {
                

                //foreach (string mod in Directory.GetFiles(Registry.VRChatPath + @"\Mods"))
                //   Mods.Add(mod.Substring(Registry.VRChatPath.Length + 6).Trim());

                //foreach (string mod in Directory.GetFiles(Registry.VRChatPath + @"\Plugins"))
                //    Mods.Add(mod.Substring(Registry.VRChatPath.Length + 6).Trim());
            }

            return Mods;
        }

        private bool GetIsInstalled() =>
            File.Exists($@"{Registry.VRChatPath}\{(Versions[0].ModType == "Mod" ? @"\Mods" : @"\Plugins")}\{Name}");
    }
}
