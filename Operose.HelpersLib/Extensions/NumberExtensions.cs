using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operose.HelpersLib
{
    public static class NumberExtensions
    {
        public static T Clamp<T>(this T num, T min, T max) where T : IComparable<T>
        {
            return MathHelpers.Clamp(num, min, max);
        }
    }
}
