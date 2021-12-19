using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public static List<Mods> GetInstalledMods()
        {
            List<Mods> mods = new List<Mods>();
            if (Directory.Exists($@"{Registry.VRChatPath}\Mods") && Directory.Exists($@"{Registry.VRChatPath}\Plugins"))
            {
                foreach((Mods mod, int i) in Main.AvailableMods.Select((value, i) => (value, i)))
                {
                    if(File.Exists($@"{Registry.VRChatPath}\Mods\{mod.Name}.dll"))
                    {
                        mods.Add(mod);
                        if (!mod.Name.Equals(Main.AvailableMods[@i].Versions[0].Name))
                        {
                            Main.FormConsole.WriteOutputLn($"{mod.Name} wasn't found on the VRCMG JSON MasterList!" +
                                $" No information can be provided about this file!");
                        }
                    }
                }

                // TODO: Rewrite this when plugins are fixed!
                //foreach (string mod in Directory.GetFiles($@"{Registry.VRChatPath}\Plugins", "*.dll"))
                //    Mods.Add(mod.Substring(Registry.VRChatPath.Length + 9).Trim());
            }

            return mods;
        }

        private bool GetIsInstalled() =>
            File.Exists($@"{Registry.VRChatPath}\{(Versions[0].ModType == "Mod" ? @"\Mods" : @"\Plugins")}\{Name}");
    }
}
