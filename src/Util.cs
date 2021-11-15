using System;
using System.Collections.Generic;
using System.Drawing;

namespace VRCModManager
{
    public static class Util
    {
        public static string ConsoleDivider { get; } = Environment.NewLine + "--------------------------------------------------";

        public static void WriteOutputLn(this ConsoleControl.ConsoleControl console, string output) =>
            console.WriteOutput(output + Environment.NewLine, Color.White);

        public static void WriteOutputLn(this ConsoleControl.ConsoleControl console, string output, Color color) =>
            console.WriteOutput(output + Environment.NewLine, color);

        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, string[] output)
        {
            foreach(string str in output)
               console.WriteOutputLn(str);
        }

        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, string[] output, Color color)
        {
            foreach (string str in output)
                console.WriteOutputLn(str, color);
        }

        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, List<string> output)
        {
            foreach(string str in output)
               console.WriteOutputLn(str);
        }

        public static void WriteMultiLineOutputLn(this ConsoleControl.ConsoleControl console, List<string> output, Color color)
        {
            foreach (string str in output)
                console.WriteOutputLn(str, color);
        }
    }
}
