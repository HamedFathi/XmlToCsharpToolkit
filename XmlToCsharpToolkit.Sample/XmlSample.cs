using System;
using System.Collections.Generic;
using System.Text;

namespace XmlToCsharpToolkit.Sample
{
    public class XmlSample
    {
        /* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
 {

     [XmlRoot(ElementName = "tr", Namespace = "http://www.w3.org/TR/html4/")]
     public class Tr
     {
         [XmlElement(ElementName = "td", Namespace = "http://www.w3.org/TR/html4/")]
         public List<string> Td { get; set; }
     }

     [XmlRoot(ElementName = "table", Namespace = "http://www.w3.org/TR/html4/")]
     public class Table
     {
         [XmlElement(ElementName = "tr", Namespace = "http://www.w3.org/TR/html4/")]
         public Tr Tr { get; set; }
         [XmlAttribute(AttributeName = "h", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string H { get; set; }
     }

     [XmlRoot(ElementName = "table", Namespace = "https://www.w3schools.com/furniture")]
     public class Table2
     {
         [XmlElement(ElementName = "name", Namespace = "https://www.w3schools.com/furniture")]
         public string Name { get; set; }
         [XmlElement(ElementName = "width", Namespace = "https://www.w3schools.com/furniture")]
         public string Width { get; set; }
         [XmlElement(ElementName = "length", Namespace = "https://www.w3schools.com/furniture")]
         public string Length { get; set; }
         [XmlAttribute(AttributeName = "f", Namespace = "http://www.w3.org/2000/xmlns/")]
         public string F { get; set; }
     }

     [XmlRoot(ElementName = "root")]
     public class Root
     {
         [XmlElement(ElementName = "table", Namespace = "http://www.w3.org/TR/html4/")]
         public Table Table { get; set; }
         [XmlElement(ElementName = "table", Namespace = "https://www.w3schools.com/furniture")]
         public Table2 Table2 { get; set; }
     }

 }
 */

        public const string SAMPLE_1 = @"<?xml version=""1.0"" encoding=""UTF-8""?>
            <root>
               <h:table xmlns:h=""http://www.w3.org/TR/html4/"">
                  <h:tr>
                     <h:td>Apples</h:td>
                     <h:td>Bananas</h:td>
                  </h:tr>
               </h:table>
               <f:table xmlns:f=""https://www.w3schools.com/furniture"">
                  <f:name>African Coffee Table</f:name>
                  <f:width>80</f:width>
                  <f:length>120</f:length>
               </f:table>
            </root>";

        public const string SAMPLE_2 = @"<?xml version=""1.0"" encoding=""UTF-8""?>
            <shiporder xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" orderid=""889923"" xsi:noNamespaceSchemaLocation=""shiporder.xsd"">
               <orderperson>John Smith</orderperson>
               <shipto>
                  <name>Ola Nordmann</name>
                  <address>Langgt 23</address>
                  <city>4000 Stavanger</city>
                  <country>Norway</country>
               </shipto>
               <item>
                  <title>Empire Burlesque</title>
                  <note>Special Edition</note>
                  <quantity>1</quantity>
                  <price>10.90</price>
               </item>
               <item>
                  <title>Hide your heart</title>
                  <quantity>1</quantity>
                  <price>9.90</price>
               </item>
            </shiporder>";

        public const string SAMPLE_3 = @"<?xml version=""1.0"" encoding=""UTF-8""?>
            <?xml-stylesheet href=""catalog.xsl"" type=""text/xsl""?>
            <!DOCTYPE catalog SYSTEM ""catalog.dtd"">
            <catalog>
               <product description=""Cardigan Sweater"" product_image=""cardigan.jpg"">
                  <catalog_item gender=""Men's"">
                     <item_number>QWZ5671</item_number>
                     <price>39.95</price>
                     <size description=""Medium"">
                        <color_swatch image=""red_cardigan.jpg"">Red</color_swatch>
                        <color_swatch image=""burgundy_cardigan.jpg"">Burgundy</color_swatch>
                     </size>
                     <size description=""Large"">
                        <color_swatch image=""red_cardigan.jpg"">Red</color_swatch>
                        <color_swatch image=""burgundy_cardigan.jpg"">Burgundy</color_swatch>
                     </size>
                  </catalog_item>
                  <catalog_item gender=""Women's"">
                     <item_number>RRX9856</item_number>
                     <price>42.50</price>
                     <size description=""Small"">
                        <color_swatch image=""red_cardigan.jpg"">Red</color_swatch>
                        <color_swatch image=""navy_cardigan.jpg"">Navy</color_swatch>
                        <color_swatch image=""burgundy_cardigan.jpg"">Burgundy</color_swatch>
                     </size>
                     <size description=""Medium"">
                        <color_swatch image=""red_cardigan.jpg"">Red</color_swatch>
                        <color_swatch image=""navy_cardigan.jpg"">Navy</color_swatch>
                        <color_swatch image=""burgundy_cardigan.jpg"">Burgundy</color_swatch>
                        <color_swatch image=""black_cardigan.jpg"">Black</color_swatch>
                     </size>
                     <size description=""Large"">
                        <color_swatch image=""navy_cardigan.jpg"">Navy</color_swatch>
                        <color_swatch image=""black_cardigan.jpg"">Black</color_swatch>
                     </size>
                     <size description=""Extra Large"">
                        <color_swatch image=""burgundy_cardigan.jpg"">Burgundy</color_swatch>
                        <color_swatch image=""black_cardigan.jpg"">Black</color_swatch>
                     </size>
                  </catalog_item>
               </product>
            </catalog>";
    }
}
