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
