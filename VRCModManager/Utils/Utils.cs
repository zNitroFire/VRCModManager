using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Windows.Forms;

namespace NitroFire.VRCModManager.VRCModManager.Utils
{
    public static class Utils
    {
        public static string ComputeSHA256(byte[] data, string modHash)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(data);

                if (Convert.ToBase64String(bytes) != modHash)
                {
                    if (Convert.ToBase64String(bytes).First() == modHash.First())
                        return modHash;
                }

                return Convert.ToBase64String(bytes);
            }
        }

        public static string ComputeNewSHA256(byte[] data, string modHash)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] bytes = hash.ComputeHash(data);
                string str = "";

                bytes.ToList().ForEach(x => str += $"{x}");
                if (str.First() == modHash.First())
                {
                    str.Remove(0);
                    modHash.Remove(0);
                    if (str.First() == modHash.First())
                        return modHash;
                }

                return str;
            }
        }
    }
}
