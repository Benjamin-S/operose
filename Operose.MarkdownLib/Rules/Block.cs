using System.Text.RegularExpressions;

namespace Operose.MarkdownLib.Rules
{
    public static class Block
    {
        public static Regex newline = new Regex(@"^\n+");
        public static Regex code = new Regex(@"^( {4}[^\n]+\n*)+");
        public static Regex fences = new Regex(@"^ {0,3}(`{3,}(?=[^`\n]*\n)|~{3,})([^\n]*)\n(?:|([\s\S]*?)\n)(?: {0,3}\1[~`]* *(?:\n+|$)|$)");
        public static Regex hr = new Regex(@"^ {0,3}((?:- *){3,}|(?:_ *){3,}|(?:\* *){3,})(?:\n+|$)");
        public static Regex heading = new Regex(@"^ {0,3}(#{1,6})(?=\s|$)(.*)(?:\n+|$)");
        public static Regex blockquote = new Regex(@"^( {0,3}> ?(paragraph|[^\n]*)(?:\n|$))+");
        public static Regex list = new Regex(@"^( {0,3})(bull) [\s\S]+?(?:hr|def|\n{2,}(?! )(?! {0,3}bull )\n*|\s*$)");

        public static Regex html = new Regex(@"^ {0,3}(?:" // optional indentation
        + @"<(script|pre|style)[\\s>][\\s\\S]*?(?:</\\1>[^\\n]*\\n+|$)" // (1)
        + @"|comment[^\\n]*(\\n+|$)" // (2)
        + @"|<\\?[\\s\\S]*?(?:\\?>\\n*|$)" // (3)
        + @"|<![A-Z][\\s\\S]*?(?:>\\n*|$)" // (4)
        + @"|<!\\[CDATA\\[[\\s\\S]*?(?:\\]\\]>\\n*|$)" // (5)
        + @"|</?(tag)(?: +|\\n|/?>)[\\s\\S]*?(?:\\n{2,}|$)" // (6)
        + @"|<(?!script|pre|style)([a-z][\\w-]*)(?:attribute)*? */?>(?=[ \\t]*(?:\\n|$))[\\s\\S]*?(?:\\n{2,}|$)" // (7) open tag
        + @"|</(?!script|pre|style)[a-z][\\w-]*\\s*>(?=[ \\t]*(?:\\n|$))[\\s\\S]*?(?:\\n{2,}|$)" // (7) closing tag
        + @")");

        public static Regex def = new Regex(@"^ {0,3}\[(label)\]: *\n? *<?([^\s>]+)>?(?:(?: +\n? *| *\n *)(title))? *(?:\n+|$)");
        public static Regex nptable = new Regex(@"noopTest");
        public static Regex table = new Regex(@"noopTest");
        public static Regex lheading = new Regex(@"^([^\n]+)\n {0,3}(=+|-+) *(?:\n+|$)");

        // regex template, placeholders will be replaced according to different paragraph
        // interruption rules of commonmark and the original markdown spec:
        public static Regex _paragraph = new Regex(@"^([^\n]+(?:\n(?!hr|heading|lheading|blockquote|fences|list|html)[^\n]+)*)");

        public static Regex text = new Regex(@"^[^\n]+");

        public static Regex Paragraph = new Regex(@"^([^\n]+(?:\n(?!^ {0,3}((?:- *){3,}|(?:_ *){3,}|(?:\* *){3,})(?:\n+|$)|^ {0,3}(#{1,6})(?=\s|$)(.*)(?:\n+|$)|''| | {0,3}(?:`{3,}(?=[^`\\n]*\\n)|~{3,})[^\\n]*\\n| {0,3}(?:[*+-]|1[.)]) |</?(?:tag)(?: +|\\n|/?>)|<(?:script|pre|style|!--))[^\n]+)*)");
    }
}