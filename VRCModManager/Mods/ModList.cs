using System.Collections.Generic;
using System.Net;

namespace NitroFire.VRCModManager
{
    /// <summary>
    /// 
    /// </summary>
    public static class ModList
    {
        // TODO: Use the 'using' keyword in the JSON get to prevent possible memory leaks
        public static string JSON { get => new WebClient().DownloadString("https://api.vrcmg.com/v0/mods.json"); }
        public static List<Mods> AvailableMods { get; set; }
    }
}
