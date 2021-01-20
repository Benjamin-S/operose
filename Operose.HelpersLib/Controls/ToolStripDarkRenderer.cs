using System.Windows.Forms;

namespace Operose.HelpersLib
{
    public class ToolStripDarkRenderer : ToolStripCustomRenderer
    {
        public ToolStripDarkRenderer() : base(new DarkColorTable())
        {
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = OperoseResources.Theme.TextColor;

            base.OnRenderItemText(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = OperoseResources.Theme.TextColor;

            base.OnRenderArrow(e);
        }
    }
}