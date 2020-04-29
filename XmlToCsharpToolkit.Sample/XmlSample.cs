using System;
using System.Collections.Generic;
using System.Text;

namespace XmlToCsharpToolkit.Sample
{
    public class XmlSample
    {
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
    }
}
