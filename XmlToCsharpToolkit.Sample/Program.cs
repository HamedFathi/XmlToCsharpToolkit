using System;
using System.Linq;

namespace XmlToCsharpToolkit.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlContent = XmlSample.SAMPLE_1;
            var src = XmlToCsharpConverter.ToText(xmlContent, "MyNamespace", AccessorType.Public);
            var listOfSrc = XmlToCsharpConverter.ToSeparatedText(xmlContent, "MyNamespace", AccessorType.Public).ToList();
        }
    }
}
