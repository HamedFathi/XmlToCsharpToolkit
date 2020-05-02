using System.Collections.Generic;

namespace XmlToCsharpToolkit
{
    public class XmlMember
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsList { get; set; }
        public string Content { get; set; }
        public string Prefix { get; set; }
        public List<XmlAttribute> Attributes { get; set; }

        public string CsharpName
        {
            get
            {
                return Name.RemoveSpecialCharacters();
            }
        }

        public XmlMember()
        {
            Attributes = new List<XmlAttribute>();
        }
    }
}
