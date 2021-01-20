namespace Operose.HelpersLib
{
    public enum DatabaseEnv
    {
        Production,
        Development,
        Test
    }

    public enum ColorType
    {
        None, RGBA, HSB, CMYK, Hex, Decimal
    }

    public enum ColorFormat
    {
        RGB, RGBA, ARGB
    }

    public enum TokenType
    {
        Text,
        Link,
        Space,
        Strong,
        Heading,
        BlockQuote,
        List,
        ListItem,
        Paragraph,
    }
}