using Operose.HelpersLib;
using Operose.MarkdownLib.Rules;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Operose.MarkdownLib
{
    public class Tokenizer
    {
        public Token Space(string src)
        {
            MatchCollection cap = Block.newline.Matches(src);
            if (cap.Count > 0)
            {
                if (cap[0].Length > 1)
                {
                    return new Token(TokenType.Space.ToString(), cap[0].ToString());
                }
                return new Token(raw: "\n");
            }
            return null;
        }

        public Token Heading(string src)
        {
            MatchCollection cap = Block.heading.Matches(src);
            if (cap.Count > 0)
            {
                Match match = cap[0];
                string text = match.Groups[2].ToString().Trim();

                // Remove trailing pound/hash characters
                if (new Regex(@"/#$/").IsMatch(text))
                {
                    string trimmed = Helpers.rtrim(text, '#');
                    text = trimmed.Trim();
                }
                return new Token(type: "heading", raw: match.ToString(), depth: match.Groups[1].Length, text: text);
            }
            return null;
        }

        public Token Paragraph(string src)
        {
            MatchCollection cap = Block.Paragraph.Matches(src);
            if (cap.Count > 0)
            {
                Match match = cap[0];
                string text = match.Groups[1].ToString();
                text = text.EndsWith(Environment.NewLine) ? text.Substring(0, text.Length - 1) : text;
                return new Token(type: "paragraph", raw: match.ToString(), text: text);
            }
            return null;
        }

        public Token Text(string src, List<Token> tokens)
        {
            MatchCollection cap = Block.text.Matches(src);
            if (cap.Count > 0)
            {
                Token lastToken = tokens[tokens.Count - 1];
                if (lastToken != null && lastToken.Type == "text")
                {
                    return new Token(raw: cap[0].ToString(), text: cap[0].ToString());
                }

                return new Token(type: "text", raw: cap[0].ToString(), text: cap[0].ToString());
            }
            return null;
        }
    }
}