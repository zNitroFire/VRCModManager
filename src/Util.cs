using System;
using System.Collections.Generic;
using System.Drawing;

namespace VRCModManager
{
    /// <summary>
    /// 
    /// </summary>
    public static class Util
    {
        public static string ConsoleDivider { get; } = Environment.NewLine + "--------------------------------------------------";
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="console"></param>
        /// <param name="output"></param>
        public static void WriteOutputLn(this ConsoleControl.ConsoleControl console, string output) =>
            console.WriteOutput(output + Environment.NewLine, Color.White);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="console"></param>
        /// <param name="output"></param>
        /// <param name="color"></param>
        public static void WriteOutputLn(this ConsoleControl.ConsoleControl console, string output, Color color) =>
            console.WriteOutput(output + Environment.NewLine, color);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="console"></param>
        /// <param name="output"></param>
        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, string[] output)
        {
            foreach(string str in output)
               console.WriteOutputLn(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="console"></param>
        /// <param name="output"></param>
        /// <param name="color"></param>
        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, string[] output, Color color)
        {
            foreach (string str in output)
                console.WriteOutputLn(str, color);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="console"></param>
        /// <param name="output"></param>
        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, List<string> output)
        {
            foreach(string str in output)
               console.WriteOutputLn(str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="console"></param>
        /// <param name="output"></param>
        /// <param name="color"></param>
        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, List<string> output, Color color)
        {
            foreach (string str in output)
                console.WriteOutputLn(str, color);
        }
    }
}
