namespace XmlToCsharpToolkit
{
    public class XmlAttribute
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Value { get; set; }
        public string CsharpName
        {
            get
            {
                return Name.RemoveSpecialCharacters();
            }
        }
    }
}
