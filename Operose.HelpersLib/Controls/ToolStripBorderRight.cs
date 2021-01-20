using System.Drawing;
using System.Windows.Forms;

namespace Operose.HelpersLib
{
    public class ToolStripBorderRight : ToolStrip
    {
        public bool DrawCustomBorder { get; set; } = true;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (DrawCustomBorder)
            {
                using (Pen pen = new Pen(ProfessionalColors.SeparatorDark))
                {
                    e.Graphics.DrawLine(pen, new Point(ClientSize.Width - 1, 0), new Point(ClientSize.Width - 1, ClientSize.Height - 1));
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }
    }
}