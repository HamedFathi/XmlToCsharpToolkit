using Humanizer;
using Microsoft.Language.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XmlToCsharpToolkit
{
    public static class XmlToCsharpConverter
    {
        private static List<XmlItem> Parse(string xmlContent, AccessorType accessorType)
        {
            var list = new List<XmlItem>();
            var xml = Parser.ParseText(xmlContent);
            foreach (var item in xml.Descendants())
            {
                var name = item.GetName();
                var parentName = item.GetParentName();

                if (item.IsLastElement()) // Property
                {
                    var propName = name == parentName ? name + "1" : name;
                    var xmlItem = list.FirstOrDefault(x => x.Name == parentName);
                    var exists = xmlItem.Members.Count(x => x.Name == propName) > 0;
                    if (!exists)
                    {
                        xmlItem.Members.Add(new XmlMember()
                        {
                            Name = propName,
                            Type = "string",
                            IsList = false,
                            Content = item.GetContent()
                        });
                    }
                }
                else // Class
                {
                    var exists = list.Count(x => x.Name == name) > 0;
                    if (!exists)
                    {
                        list.Add(new XmlItem()
                        {
                            AccessorType = accessorType,
                            Name = name,
                            ParentName = parentName,
                            Content = item.GetContent()
                        });
                    }
                    if (item.HasParent())
                    {
                        var xmlItem = list.FirstOrDefault(x => x.Name == parentName);
                        var duplicateItems = item.GetElementsName().GetDuplicateItems();
                        var isList = duplicateItems.Contains(name);
                        var memExists = xmlItem.Members.Count(x => x.Name == name) > 0;
                        if (!memExists)
                        {
                            xmlItem.Members.Add(new XmlMember()
                            {
                                Name = name,
                                Type = name,
                                IsList = isList,
                                Content = item.GetContent()
                            });
                        }
                    }
                }


            }
            return list;
        }

        public static IEnumerable<string> ToSeparatedText(string xmlContent, string @namespace = null, AccessorType accessorType = AccessorType.Public)
        {
            var result = new List<string>();
            var hasNamespace = !string.IsNullOrEmpty(@namespace);
            var src = GenerateCsharpSource(xmlContent, @namespace, accessorType);
            foreach (var item in src)
            {
                var sb = new StringBuilder();
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("using System.Xml.Serialization;");
                sb.AppendLine();
                if (hasNamespace)
                {
                    sb.AppendLine($"namespace {@namespace}");
                    sb.AppendLine("{");
                }
                sb.AppendLine(item);
                if (hasNamespace)
                {
                    sb.AppendLine("}");
                }
                result.Add(sb.ToString());
            }
            return result;
        }

        public static string ToText(string xmlContent, string @namespace = null, AccessorType accessorType = AccessorType.Public)
        {
            var hasNamespace = !string.IsNullOrEmpty(@namespace);
            var src = GenerateCsharpSource(xmlContent, @namespace, accessorType).Aggregate((x, y) => x + Environment.NewLine + y);
            var sb = new StringBuilder();
            sb.AppendLine("using System.Collections.Generic;");
            sb.AppendLine("using System.Xml.Serialization;");
            sb.AppendLine();
            if (hasNamespace)
            {
                sb.AppendLine($"namespace {@namespace}");
                sb.AppendLine("{");
            }
            sb.AppendLine(src);
            if (hasNamespace)
            {
                sb.AppendLine("}");
            }
            return sb.ToString();
        }

        private static IEnumerable<string> GenerateCsharpSource(string xmlContent, string @namespace = null, AccessorType accessorType = AccessorType.Public)
        {
            var result = new List<string>();
            var hasNamespace = !string.IsNullOrEmpty(@namespace);
            var list = Parse(xmlContent, accessorType);
            list.Reverse(); // From child to parent
            foreach (var item in list)
            {
                var sb = new StringBuilder();
                sb.AppendLine($"{(!hasNamespace ? Tabs(0) : Tabs(1))}{GetAccessor(accessorType)} class {item.CsharpName}");
                sb.AppendLine($"{(!hasNamespace ? Tabs(0) : Tabs(1))}{{");
                foreach (var mem in item.Members)
                {
                    if (mem.IsList)
                    {
                        var plMemName = mem.CsharpName.Pluralize(false);
                        sb.AppendLine($"{(!hasNamespace ? Tabs(1) : Tabs(2))}{GetAccessor(accessorType)} List<{mem.Type}> {plMemName} {{ get; set; }}");
                    }
                    else
                    {
                        sb.AppendLine($"{(!hasNamespace ? Tabs(1) : Tabs(2))}{GetAccessor(accessorType)} {mem.Type} {mem.CsharpName} {{ get; set; }}");
                    }
                }
                sb.AppendLine($"{(!hasNamespace ? Tabs(0) : Tabs(1))}}}");
                result.Add(sb.ToString());
            }
            return result;
        }
        private static string Tabs(int count = 0)
        {
            if (count <= 0) return "";
            return new string('\t', count);
        }
        private static string GetAccessor(AccessorType accessorType)
        {
            var accessor = "";
            switch (accessorType)
            {
                case AccessorType.Public:
                    accessor = "public";
                    break;
                case AccessorType.Private:
                    accessor = "private";
                    break;
                case AccessorType.Internal:
                    accessor = "internal";
                    break;
                case AccessorType.Protected:
                    accessor = "protected";
                    break;
            }
            return accessor;
        }

        private static List<T> GetDuplicateItems<T>(this IEnumerable<T> items)
        {
            return items.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
        }
    }
}
