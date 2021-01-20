namespace Operose.MarkdownLib
{
    public class Token
    {
        public string Type;
        public string Raw;
        public int Depth;
        public string Text;

        public Token(string type, string raw)
        {
            Type = type;
            Raw = raw;
        }

        public Token(string raw)
        {
            Raw = raw;
        }

        public Token(string type = null, string raw = null, int depth = 0, string text = null)
        {
            Type = type;
            Raw = raw;
            Depth = depth;
            Text = text;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Raw: {Raw}, Depth: {Depth}, Text: {Text}\n";
        }
    }
}