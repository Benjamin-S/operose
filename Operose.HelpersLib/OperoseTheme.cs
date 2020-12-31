using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operose.HelpersLib
{
    public class OperoseTheme
    {
        public string Name { get; set; }

        private Color BackgroundColor;

        private Color LightBackgroundColor;

        private Color DarkBackgroundColor;

        private Color TextColor;

        private Color BorderColor;

        public Color LinkColor { get; set; }

        public Color MenuHighlightColor { get; set; }

        public Color MenuHighlightBorderColor { get; set; }

        public Color MenuBorderColor { get; set; }

        public Color MenuCheckBackgroundColor { get; set; }

        public Font ContextMenuFont { get; set; } = new Font("Segoe UI", 10);

        public int ContextMenuOpacity { get; set; } = 100;

        public double ContextMenuOpacityDouble => Clamp(ContextMenuOpacity, 10, 100)/100d;

        public Color SeparatorLightColor { get; set; }

        public Color SeparatorDarkColor { get; set; }

        public OperoseTheme()
        {
            SetDarkTheme();
        }

        public static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }

        public void SetDarkTheme()
        {
            Name = "Dark";
            BackgroundColor = Color.FromArgb(42, 47, 56);
            LightBackgroundColor = Color.FromArgb(52, 57, 65);
            DarkBackgroundColor = Color.FromArgb(28, 32, 38);
            TextColor = Color.FromArgb(235, 235, 235);
            BorderColor = Color.FromArgb(28, 32, 38);
            LinkColor = Color.FromArgb(166, 212, 255);
            MenuHighlightColor = Color.FromArgb(30, 34, 40);
            MenuHighlightBorderColor = Color.FromArgb(116, 129, 152);
            MenuBorderColor = Color.FromArgb(22, 26, 31);
            MenuCheckBackgroundColor = Color.FromArgb(56, 64, 75);
            ContextMenuOpacity = 100;
            SeparatorLightColor = Color.FromArgb(56, 64, 75);
            SeparatorDarkColor = Color.FromArgb(22, 26, 31);
        }

        public void SetLightTheme()
        {
            Name = "Light";
            BackgroundColor = Color.FromArgb(242, 242, 242);
            LightBackgroundColor = Color.FromArgb(247, 247, 247);
            DarkBackgroundColor = Color.FromArgb(235, 235, 235);
            TextColor = Color.FromArgb(69, 69, 69);
            BorderColor = Color.FromArgb(201, 201, 201);
            LinkColor = Color.FromArgb(166, 212, 255);
            MenuHighlightColor = Color.FromArgb(247, 247, 247);
            MenuHighlightBorderColor = Color.FromArgb(96, 143, 226);
            MenuBorderColor = Color.FromArgb(201, 201, 201);
            MenuCheckBackgroundColor = Color.FromArgb(225, 233, 244);
            ContextMenuOpacity = 100;
            SeparatorLightColor = Color.FromArgb(253, 253, 253);
            SeparatorDarkColor = Color.FromArgb(189, 189, 189);
        }

        public static List<OperoseTheme> GetPresets()
        {
            OperoseTheme darkTheme = new OperoseTheme();
            OperoseTheme lightTheme = new OperoseTheme();
            lightTheme.SetLightTheme();
            return new List<OperoseTheme>() { darkTheme, lightTheme };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
