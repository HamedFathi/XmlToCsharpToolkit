namespace XmlToCsharpToolkit
{
    public class XmlMember
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsList { get; set; }
        public string Content { get; set; }
        public string CsharpName
        {
            get
            {
                return Name.RemoveSpecialCharacters();
            }
        }
    }
}
