using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace NitroFire.VRCModManager
{
    /// <summary>
    /// 
    /// </summary>
    public static class Registry
    {
        public static string SteamPath
        { 
            get => Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamPath", null).ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public static string VRChatPath { get => GetVRChatPath(); }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string GetVRChatPath()
        {
            string vdfPath = SteamPath + @"/steamapps/libraryfolders.vdf";
            if (File.Exists(vdfPath))
            {
                try
                {
                    string[] vdfLines = File.ReadAllLines(vdfPath);
                    List<string> allPaths = new List<string>();
                    foreach (string line in vdfLines)
                        if (line.Contains("path")) allPaths.Add(line);

                    foreach (string libraryPath in allPaths)
                    {
                        string subStr = (libraryPath + @"\\steamapps\\common\\VRChat")
                            .Substring(libraryPath.IndexOf(":\\") - 3)
                            .Replace("\"", "")
                            .Replace(@"\\", @"\")
                            .Trim();

                        if (Directory.Exists(subStr))
                            return subStr;
                    }  
                }
                catch(Exception ex) { Main.FormConsole.WriteOutputLn("[ERROR]: " + ex.Message, Color.Red); }
            }

            return null;
        }
    }
}