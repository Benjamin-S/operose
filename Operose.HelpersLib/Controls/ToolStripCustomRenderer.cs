using System.Drawing;
using System.Windows.Forms;

namespace Operose.HelpersLib
{
    public class ToolStripCustomRenderer : ToolStripRoundedEdgeRenderer
    {
        public ToolStripCustomRenderer()
        {
        }

        public ToolStripCustomRenderer(ProfessionalColorTable professionalColorTable) : base(professionalColorTable)
        {
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item is ToolStripMenuItem tsmi && tsmi.Checked)
            {
                e.TextFont = new Font(tsmi.Font, FontStyle.Bold);
            }

            base.OnRenderItemText(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            if (e.Item is ToolStripDropDownButton tsddb && tsddb.Owner is ToolStripBorderRight)
            {
                e.Direction = ArrowDirection.Right;
            }

            base.OnRenderArrow(e);
        }
    }
}