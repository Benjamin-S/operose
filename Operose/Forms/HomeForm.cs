using Operose.HelpersLib;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Operose
{
    public partial class HomeForm : UserControl
    {
        private List<TextObject> lines = new List<TextObject>();
        private TextRenderer tr;

        public HomeForm()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            lines.Add(new TextObject(Node.Title, "Welcome to Operose"));

            lines.Add(new TextObject(Node.Header, "Blocking Sesssion"));
            lines.Add(new TextObject(Node.ListItem, "Include Operose - This will show the current program in the list of users."));
            lines.Add(new TextObject(Node.ListItem, "Summarise - Shows a trimmed down version of the blocking results. Makes it easier to trace back to the culprit."));
            lines.Add(new TextObject(Node.Paragraph, "Useful to see the state of current processes in GP.This is to be used when a block/deadlock occurs in GP."));
            lines.Add(new TextObject(Node.Paragraph, @"When run, you can trace back the blocking session by looking at the blocking_session_id column and then following it back through each ID until you find the session that is blocking others but doesn't have any blocks itself. At this point you can contact the user and ask them to log out, contact service desk and ask them to end their remote session, or you can use the Clear Inactive Users function and see if that removes them."));

            lines.Add(new TextObject(Node.Header, "Clear Inactive Users"));
            lines.Add(new TextObject(Node.Paragraph, "Runs a stored procedure against the SQL database, ClearInactiveUsers. This removes idle users from the GP activity table and can help to clear out the GP User Activity window when needing to run procedures in GP. Check effectiveness with the Stuck Batches function."));

            lines.Add(new TextObject(Node.Header, "Stuck Batches"));
            lines.Add(new TextObject(Node.Paragraph, "Uses MSDN suggested checks to look at specific tables to see user activity. When all users are logged off from Microsoft Dynamics GP, these tables will not have any records in them. Use this window for checking batch activity before resetting the batch status."));

            lines.Add(new TextObject(Node.Header, "Reset Batches"));
            lines.Add(new TextObject(Node.Paragraph, "Used in conjunction with the Stuck Batches window. Users can search for batches, select multiple, and then proceed reset the batch status and marked to post status of selected batches."));

            lines.Add(new TextObject(Node.Header, "Fix ECOMMX Batches"));
            lines.Add(new TextObject(Node.Paragraph, "Not yet implemented"));

            lines.Add(new TextObject(Node.Header, "Pulse User Access"));
            lines.Add(new TextObject(Node.Paragraph, "Not yet implemented"));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            tr = new TextRenderer(e, lines);
            tr.ConstructTree();
        }
    }

    public class TextRenderer
    {
        private PaintEventArgs paintEventArgs;
        private Graphics canvas;
        private List<TextObject> linesOfText;
        private Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
        private Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
        private Font paragraphFont = new Font("Segoe UI", 9);

        private readonly float lineHeight = 2.5f;
        private readonly float startX = 10f;
        private readonly float startY = 10f;
        private readonly int listInset = 30;
        private readonly string bullet = "•";
        private readonly int lineLength = 80;

        public TextRenderer(PaintEventArgs canvas, List<TextObject> linesOfText)
        {
            paintEventArgs = canvas;
            this.canvas = canvas.Graphics;
            this.linesOfText = linesOfText;
        }

        public void ConstructTree()
        {
            float lineLoc = startY;
            foreach (TextObject textObj in linesOfText)
            {
                Font selectedFont;
                FormattedText parsedString = InsertNewlines(textObj.Text, lineLength);

                switch (textObj.Type)
                {
                    case Node.Title:
                        selectedFont = titleFont;
                        canvas.DrawString(parsedString.text, selectedFont, new SolidBrush(OperoseResources.Theme.TextColor), startX, lineLoc);
                        break;

                    case Node.Header:
                        selectedFont = headerFont;
                        canvas.DrawString(parsedString.text, selectedFont, new SolidBrush(OperoseResources.Theme.TextColor), startX, lineLoc);
                        break;

                    case Node.Paragraph:
                        selectedFont = paragraphFont;
                        canvas.DrawString(parsedString.text, selectedFont, new SolidBrush(OperoseResources.Theme.TextColor), startX, lineLoc);
                        break;

                    case Node.ListItem:
                        selectedFont = paragraphFont;
                        canvas.DrawString(bullet + " ", selectedFont, new SolidBrush(OperoseResources.Theme.TextColor), startX + listInset - 10, lineLoc);
                        canvas.DrawString(parsedString.text, selectedFont, new SolidBrush(OperoseResources.Theme.TextColor), startX + listInset, lineLoc);
                        break;

                    default:
                        selectedFont = paragraphFont;
                        canvas.DrawString(parsedString.text, selectedFont, new SolidBrush(OperoseResources.Theme.TextColor), startX, lineLoc);
                        break;
                }

                lineLoc += lineHeight * selectedFont.Size * parsedString.lines;
            }
        }

        public FormattedText InsertNewlines(string baseText, int maxLineLength)
        {
            var text = Helpers.SplitToLines(baseText, maxLineLength);
            var outText = string.Join("\n", text);
            return new FormattedText { text = outText, lines = text.Count() };
        }
    }

    public enum Node
    {
        Title,
        Header,
        Paragraph,
        ListItem
    }

    public struct FormattedText
    {
        public string text;
        public int lines;
    }

    public class TextObject
    {
        public Node Type;
        public string Text;

        public TextObject(Node type, string text)
        {
            Type = type;
            Text = text;
        }
    }
}