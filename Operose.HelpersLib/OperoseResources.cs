using Operose.HelpersLib.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Operose.HelpersLib
{
    public static class OperoseResources
    {
        private static bool useCustomTheme;

        public static bool UseCustomTheme
        {
            get
            {
                return useCustomTheme && Theme != null;
            }
            set
            {
                useCustomTheme = value;
            }
        }

        public static bool IsDarkTheme => UseCustomTheme && Theme.IsDarkTheme;

        public static Icon Icon => Resources.Operose_Icon_White;

        public static OperoseTheme Theme { get; set; } = OperoseTheme.DarkTheme;

        public static void ApplyTheme(Form form, bool setIcon = true)
        {
            if (setIcon)
            {
                form.Icon = Icon;
            }

            if (UseCustomTheme)
            {
                DebugHelper.WriteLine("Use Custom Theme");
                ApplyCustomThemeToControl(form);

                IContainer components = form.GetType().GetField("components", BindingFlags.NonPublic | BindingFlags.Instance)?.GetValue(form) as IContainer;
                ApplyCustomThemeToComponents(components);

                if (form.IsHandleCreated)
                {
                    NativeMethods.UseImmersiveDarkMode(form.Handle, Theme.IsDarkTheme);
                }
                else
                {
                    form.HandleCreated += (s, e) => NativeMethods.UseImmersiveDarkMode(form.Handle, Theme.IsDarkTheme);
                }
            }
        }

        public static void ApplyCustomThemeToControl(Control control)
        {
            if (control.ContextMenuStrip != null)
            {
                ApplyCustomThemeToContextMenuStrip(control.ContextMenuStrip);
            }

            //if (control is MenuButton mb && mb.Menu != null)
            //{
            //    ApplyCustomThemeToContextMenuStrip(mb.Menu);
            //}

            switch (control)
            {
                case Button btn:
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Theme.BorderColor;
                    btn.ForeColor = Theme.TextColor;
                    btn.BackColor = Theme.LightBackgroundColor;
                    return;

                case CheckBox cb when cb.Appearance == Appearance.Button:
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.FlatAppearance.BorderColor = Theme.BorderColor;
                    cb.ForeColor = Theme.TextColor;
                    cb.BackColor = Theme.LightBackgroundColor;
                    return;

                case TextBox tb:
                    tb.ForeColor = Theme.TextColor;
                    tb.BackColor = Theme.LightBackgroundColor;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    return;

                case ComboBox cb:
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.ForeColor = Theme.TextColor;
                    cb.BackColor = Theme.LightBackgroundColor;
                    return;

                case ListBox lb:
                    lb.ForeColor = Theme.TextColor;
                    lb.BackColor = Theme.LightBackgroundColor;
                    return;

                case ListView lv:
                    lv.ForeColor = Theme.TextColor;
                    lv.BackColor = Theme.LightBackgroundColor;
                    lv.SupportCustomTheme();
                    return;

                case SplitContainer sc:
                    sc.Panel1.BackColor = Theme.BackgroundColor;
                    sc.Panel2.BackColor = Theme.BackgroundColor;
                    break;

                case PropertyGrid pg:
                    pg.CategoryForeColor = Theme.TextColor;
                    pg.CategorySplitterColor = Theme.BackgroundColor;
                    pg.LineColor = Theme.BackgroundColor;
                    pg.SelectedItemWithFocusForeColor = Theme.BackgroundColor;
                    pg.SelectedItemWithFocusBackColor = Theme.TextColor;
                    pg.ViewForeColor = Theme.TextColor;
                    pg.ViewBackColor = Theme.LightBackgroundColor;
                    pg.ViewBorderColor = Theme.BorderColor;
                    pg.HelpForeColor = Theme.TextColor;
                    pg.HelpBackColor = Theme.BackgroundColor;
                    pg.HelpBorderColor = Theme.BorderColor;
                    return;

                case DataGridView dgv:
                    dgv.BackgroundColor = Theme.LightBackgroundColor;
                    dgv.GridColor = Theme.BorderColor;
                    dgv.DefaultCellStyle.BackColor = Theme.LightBackgroundColor;
                    dgv.DefaultCellStyle.SelectionBackColor = Theme.LightBackgroundColor;
                    dgv.DefaultCellStyle.ForeColor = Theme.TextColor;
                    dgv.DefaultCellStyle.SelectionForeColor = Theme.TextColor;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Theme.BackgroundColor;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Theme.BackgroundColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Theme.TextColor;
                    dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Theme.TextColor;
                    dgv.RowHeadersDefaultCellStyle.BackColor = Theme.BackgroundColor;
                    dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Theme.BackgroundColor;
                    dgv.RowHeadersDefaultCellStyle.SelectionForeColor = Theme.TextColor;
                    dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dgv.EnableHeadersVisualStyles = false;
                    break;
                //case ContextMenuStrip cms:
                //    ApplyCustomThemeToContextMenuStrip(cms);
                //    return;
                case ToolStrip ts:
                    ts.Renderer = new ToolStripDarkRenderer();
                    ApplyCustomThemeToToolStripItemCollection(ts.Items);
                    return;
                    //case LinkLabel ll:
                    //    ll.LinkColor = Theme.LinkColor;
                    //    break;
            }

            control.ForeColor = Theme.TextColor;
            control.BackColor = Theme.BackgroundColor;

            foreach (Control child in control.Controls)
            {
                ApplyCustomThemeToControl(child);
            }
        }

        private static void ApplyCustomThemeToComponents(IContainer container)
        {
            if (container != null)
            {
                foreach (IComponent component in container.Components)
                {
                    switch (component)
                    {
                        case ContextMenuStrip cms:
                            ApplyCustomThemeToContextMenuStrip(cms);
                            break;

                        case ToolTip tt:
                            tt.ForeColor = Theme.TextColor;
                            tt.BackColor = Theme.BackgroundColor;
                            tt.OwnerDraw = true;
                            tt.Draw -= ToolTip_Draw;
                            tt.Draw += ToolTip_Draw;
                            break;
                    }
                }
            }
        }

        private static void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText(TextFormatFlags.VerticalCenter | TextFormatFlags.LeftAndRightPadding);
        }

        public static void ApplyCustomThemeToContextMenuStrip(ContextMenuStrip cms)
        {
            if (cms != null)
            {
                cms.Renderer = new ToolStripDarkRenderer();
                cms.Font = Theme.ContextMenuFont;
                cms.Opacity = Theme.ContextMenuOpacityDouble;
                ApplyCustomThemeToToolStripItemCollection(cms.Items);
            }
        }

        private static void ApplyCustomThemeToToolStripItemCollection(ToolStripItemCollection collection)
        {
            foreach (ToolStripItem tsi in collection)
            {
                switch (tsi)
                {
                    case ToolStripControlHost tsch:
                        ApplyCustomThemeToControl(tsch.Control);
                        break;

                    case ToolStripDropDownItem tsddi:
                        if (tsddi.DropDown != null)
                        {
                            tsddi.DropDown.Opacity = Theme.ContextMenuOpacityDouble;
                            ApplyCustomThemeToToolStripItemCollection(tsddi.DropDownItems);
                        }
                        break;
                }
            }
        }
    }
}