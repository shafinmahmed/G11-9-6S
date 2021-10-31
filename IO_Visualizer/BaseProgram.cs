using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IO_Visualizer
{
    static class BaseProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainInterface());
        }

        public static ColorInfo GetRGB(int ultrasonicValue)
        {
            double min = 0.0;
            double max = 30.0;

            double ratio = 2 * (ultrasonicValue - min) / (max - min);
            int red = Convert.ToInt32(Math.Round(Math.Max(0, 255 * (1 - ratio))));
            int blue = Convert.ToInt32(Math.Round(Math.Max(0, 255 * (ratio - 1))));
            int green = 255 - blue - red;

            ColorInfo retVal = new ColorInfo();
            retVal.r = red;
            retVal.b = blue;
            retVal.g = green;

            return retVal;
        }

        public static bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public struct ColorInfo
        {
            public int r;
            public int g;
            public int b;
        }
    }
}
