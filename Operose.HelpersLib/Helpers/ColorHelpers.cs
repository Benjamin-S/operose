using System;
using System.Drawing;

namespace Operose.HelpersLib
{
    public static class ColorHelpers
    {
        public static int PerceivedBrightness(Color color)
        {
            return (int)Math.Sqrt((color.R * color.R * .299) + (color.G * color.G * .587) + (color.B * color.B * .114));
        }

        public static bool IsLightColor(Color color)
        {
            return PerceivedBrightness(color) > 130;
        }

        public static bool IsDarkColor(Color color)
        {
            return !IsLightColor(color);
        }
    }
}