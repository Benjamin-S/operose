using System;
using System.Runtime.InteropServices;

namespace Operose.HelpersLib
{
    public static partial class NativeMethods
    {
        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
    }
}