using System.Collections.Generic;

namespace XmlToCsharpToolkit
{
    public class XmlItem
    {
        public AccessorType AccessorType { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string Content { get; set; }
        public List<XmlMember> Members { get; set; }

        public string CsharpName
        {
            get
            {
                return Name.RemoveSpecialCharacters();
            }
        }
        public string CsharpParentName
        {
            get
            {
                return Name.RemoveSpecialCharacters();
            }
        }
        public XmlItem()
        {
            Members = new List<XmlMember>();
        }
    }
}
