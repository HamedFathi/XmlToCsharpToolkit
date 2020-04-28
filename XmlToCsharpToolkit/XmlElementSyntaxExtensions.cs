using Microsoft.Language.Xml;
using System.Collections.Generic;
using System.Linq;

namespace XmlToCsharpToolkit
{
    internal static class XmlElementSyntaxExtensions
    {
        internal static bool HasParent(this IXmlElementSyntax xmlElementSyntax)
        {
            return xmlElementSyntax.Parent != null;
        }

        internal static string GetName(this IXmlElementSyntax xmlElementSyntax)
        {
            return xmlElementSyntax.NameNode.ToFullString();
        }

        internal static string GetContent(this IXmlElementSyntax xmlElementSyntax)
        {
            return xmlElementSyntax.Content.ToFullString();
        }

        internal static string GetParentName(this IXmlElementSyntax xmlElementSyntax)
        {
            if (xmlElementSyntax.Parent == null) return null;
            return xmlElementSyntax.Parent.NameNode.ToFullString();
        }

        internal static IEnumerable<string> GetElementsName(this IXmlElementSyntax xmlElementSyntax)
        {
            return xmlElementSyntax.Parent.Elements.Select(x => x.NameNode.FullName);
        }

        internal static bool IsLastElement(this IXmlElementSyntax xmlElementSyntax)
        {
            return xmlElementSyntax.Elements.Count() == 0;
        }

    }
}
