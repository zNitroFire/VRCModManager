using System.Collections.Generic;
using System.IO;
using System.Net;

namespace VRCModManager
{
    public static class ModList
    {
        public static string JSON { get => new WebClient().DownloadString("https://api.vrcmg.com/v0/mods.json"); }
    }

    public class Mods
    {
        protected static string DownloadLink { get; set; }

        public string IsInstalled { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string MelonLoaderVerson { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Repository { get; set; }
        public string LastUpdated { get; set; }
        public string Hash { get; set; }

        public static List<string> GetInstalledMods()
        {
            List<string> Mods = new List<string>();
            if(Directory.Exists(Registry.VRChatPath + @"\Mods"))
            {
                foreach (string mod in Directory.GetFiles(Registry.VRChatPath + @"\Mods"))
                   Mods.Add(mod.Substring(Registry.VRChatPath.Length + 6).Trim());
            }

            return Mods;
        }
    }
}
