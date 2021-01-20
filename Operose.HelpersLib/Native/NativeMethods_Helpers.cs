using System;

namespace Operose.HelpersLib
{
    public static partial class NativeMethods
    {
        public static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
        {
            if (Helpers.IsWindows10OrGreater(17763))
            {
                DwmWindowAttribute attribute;

                if (Helpers.IsWindows10OrGreater(18985))
                {
                    attribute = DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE;
                }
                else
                {
                    attribute = DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }
            return false;
        }
    }
}