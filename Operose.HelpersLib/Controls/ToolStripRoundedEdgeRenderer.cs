using System.Windows.Forms;

namespace Operose.HelpersLib
{
    public class ToolStripRoundedEdgeRenderer : ToolStripProfessionalRenderer
    {
        public ToolStripRoundedEdgeRenderer()
        {
            RoundedEdges = false;
        }

        public ToolStripRoundedEdgeRenderer(ProfessionalColorTable professionalColorTable) : base(professionalColorTable)
        {
            RoundedEdges = false;
        }
    }
}