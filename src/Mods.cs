using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace VRCModManager
{
    /// <summary>
    /// 
    /// </summary>
    public static class ModList
    {
        public static string JSON { get => new WebClient().DownloadString("https://api.vrcmg.com/v0/mods.json"); }
        public static List<Mods> AvailableMods { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Mods
    {
        public string name { get; set; }
        public versions[] versions { get; set; }
        private string _isinstalled = "n/a";
        public string isInstalled { get { return _isinstalled; } set { _isinstalled = value; } }

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

    /// <summary>
    /// 
    /// </summary>
    public class versions
    {
        public int _version { get; set; }
        public string vrchatversion { get; set; }
        public string downloadlink { get; set; }
        public string modversion { get; set; }
        public string loaderversion { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string sourcelink { get; set; }
        public string modtype { get; set; }
        public string name { get; set; }
        public string changelog { get; set; }
        public string hash { get; set; }
        public string updatedate { get; set; }
    }
}
