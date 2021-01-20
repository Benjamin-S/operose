using Operose.HelpersLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operose
{
    public static class Extensions
    {
        public static Task ContinueInCurrentContext(this Task task, Action action)
        {
            TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
            return task.ContinueWith(t => action(), scheduler);
        }

        public static void ApplyDefaultPropertyValues(this object self)
        {
            foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
            {
                DefaultValueAttribute attr = prop.Attributes[typeof(DefaultValueAttribute)] as DefaultValueAttribute;
                if (attr != null) prop.SetValue(self, attr.Value);
            }
        }

        public static bool IsTransparent(this Color color)
        {
            return color.A < 255;
        }

        public static bool IsValidIndex<T>(this T[] array, int index)
        {
            return array != null && index >= 0 && index < array.Length;
        }

        public static bool IsValidIndex<T>(this List<T> list, int index)
        {
            return list != null && index >= 0 && index < list.Count;
        }

        public static void SupportCustomTheme(this ListView lv)
        {
            if (!lv.OwnerDraw)
            {
                lv.OwnerDraw = true;

                lv.DrawItem += (sender, e) =>
                {
                    e.DrawDefault = true;
                };

                lv.DrawSubItem += (sender, e) =>
                {
                    e.DrawDefault = true;
                };

                lv.DrawColumnHeader += (sender, e) =>
                {
                    if (OperoseResources.UseCustomTheme)
                    {
                        using (Brush brush = new SolidBrush(OperoseResources.Theme.BackgroundColor))
                        {
                            e.Graphics.FillRectangle(brush, e.Bounds);
                        }

                        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds.LocationOffset(2, 0).SizeOffset(-4, 0), OperoseResources.Theme.TextColor,
                            TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

                        if (e.Bounds.Right < lv.ClientRectangle.Right)
                        {
                            using (Pen pen = new Pen(OperoseResources.Theme.SeparatorDarkColor))
                            using (Pen pen2 = new Pen(OperoseResources.Theme.SeparatorLightColor))
                            {
                                e.Graphics.DrawLine(pen, e.Bounds.Right - 2, e.Bounds.Top, e.Bounds.Right - 2, e.Bounds.Bottom - 1);
                                e.Graphics.DrawLine(pen2, e.Bounds.Right - 1, e.Bounds.Top, e.Bounds.Right - 1, e.Bounds.Bottom - 1);
                            }
                        }
                    }
                    else
                    {
                        e.DrawDefault = true;
                    }
                };
            }
        }

        public static Rectangle LocationOffset(this Rectangle rect, int x, int y)
        {
            return new Rectangle(rect.X + x, rect.Y + y, rect.Width, rect.Height);
        }

        public static Rectangle LocationOffset(this Rectangle rect, Point offset)
        {
            return rect.LocationOffset(offset.X, offset.Y);
        }

        public static Rectangle LocationOffset(this Rectangle rect, int offset)
        {
            return rect.LocationOffset(offset, offset);
        }

        public static Rectangle SizeOffset(this Rectangle rect, int width, int height)
        {
            return new Rectangle(rect.X, rect.Y, rect.Width + width, rect.Height + height);
        }

        public static Rectangle SizeOffset(this Rectangle rect, int offset)
        {
            return rect.SizeOffset(offset, offset);
        }
    }
}