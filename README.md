# How to use

```cs
using XmlToCsharpToolkit;

var xmlContent = File.ReadAllText(@"...\sample.xml");
var src = XmlToCsharpConverter.ToText(xmlContent, "MyNamespace", AccessorType.Public);
var listOfSrc = XmlToCsharpConverter.ToSeparatedText(xmlContent, "MyNamespace", AccessorType.Public).ToList();
```