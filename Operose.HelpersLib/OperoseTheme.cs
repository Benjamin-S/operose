using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace Operose.HelpersLib
{
    public class OperoseTheme
    {
        public string Name { get; set; }

        private Color backgroundColor;

        public Color BackgroundColor
        {
            get
            {
                return backgroundColor;
            }
            set
            {
                if (!value.IsTransparent()) backgroundColor = value;
            }
        }

        private Color lightBackgroundColor;

        public Color LightBackgroundColor
        {
            get
            {
                return lightBackgroundColor;
            }
            set
            {
                if (!value.IsTransparent()) lightBackgroundColor = value;
            }
        }

        private Color darkBackgroundColor;

        public Color DarkBackgroundColor
        {
            get
            {
                return darkBackgroundColor;
            }
            set
            {
                if (!value.IsTransparent()) darkBackgroundColor = value;
            }
        }

        private Color textColor;

        public Color TextColor
        {
            get
            {
                return textColor;
            }
            set
            {
                if (!value.IsTransparent()) textColor = value;
            }
        }

        private Color borderColor;

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                if (!value.IsTransparent()) borderColor = value;
            }
        }

        public Color MenuHighlightColor { get; set; }

        public Color MenuHighlightBorderColor { get; set; }

        public Color MenuBorderColor { get; set; }
        public Color MenuCheckBackgroundColor { get; set; }

        public Font ContextMenuFont { get; set; } = new Font("Segoe UI", 10);

        public int ContextMenuOpacity { get; set; } = 100;
        public double ContextMenuOpacityDouble => Clamp(ContextMenuOpacity, 10, 100) / 100d;

        public Color SeparatorLightColor { get; set; }

        public Color SeparatorDarkColor { get; set; }

        [Browsable(false)]
        //public bool IsDarkTheme => ColorHelpers.IsDarkColor(BackgroundColor);

        public bool IsDarkTheme => ColorHelpers.IsDarkColor(BackgroundColor);

        public static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }

        private OperoseTheme()
        {
            Name = "Dark";
            BackgroundColor = Color.FromArgb(42, 47, 56);
            LightBackgroundColor = Color.FromArgb(52, 57, 65);
            DarkBackgroundColor = Color.FromArgb(28, 32, 38);
            TextColor = Color.FromArgb(235, 235, 235);
            BorderColor = Color.FromArgb(28, 32, 38);
            MenuHighlightColor = Color.FromArgb(30, 34, 40);
            MenuHighlightBorderColor = Color.FromArgb(116, 129, 152);
            MenuBorderColor = Color.FromArgb(22, 26, 31);
            MenuCheckBackgroundColor = Color.FromArgb(56, 64, 75);
            ContextMenuOpacity = 100;
            SeparatorLightColor = Color.FromArgb(56, 64, 75);
            SeparatorDarkColor = Color.FromArgb(22, 26, 31);
        }

        public static OperoseTheme DarkTheme => new OperoseTheme();

        public static OperoseTheme LightTheme => new OperoseTheme
        {
            Name = "Light",
            BackgroundColor = Color.FromArgb(242, 242, 242),
            LightBackgroundColor = Color.FromArgb(247, 247, 247),
            DarkBackgroundColor = Color.FromArgb(235, 235, 235),
            TextColor = Color.FromArgb(69, 69, 69),
            BorderColor = Color.FromArgb(201, 201, 201),
            MenuHighlightColor = Color.FromArgb(247, 247, 247),
            MenuHighlightBorderColor = Color.FromArgb(96, 143, 226),
            MenuBorderColor = Color.FromArgb(201, 201, 201),
            MenuCheckBackgroundColor = Color.FromArgb(225, 233, 244),
            ContextMenuOpacity = 100,
            SeparatorLightColor = Color.FromArgb(253, 253, 253),
            SeparatorDarkColor = Color.FromArgb(189, 189, 189)
        };

        public static List<OperoseTheme> GetDefaultThemes()
        {
            return new List<OperoseTheme>() { DarkTheme, LightTheme };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}