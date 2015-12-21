using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;

namespace wrjFulfillmentStudio
{
    // Type created for JSON at <<root>>
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NonRegisteredShippingLabel
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string actualWeight;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shopifyOrderId;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipToAddress;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shippedDate;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shippingMethod;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shippingType;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomsItem[] customsItems;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customsTotalValue;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customsType;
    }

    // Type created for JSON at <<root>> --> customsItems
    [System.Runtime.Serialization.DataContractAttribute(Name = "customsItems")]
    public partial class CustomsItem
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string quantity;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string valueUSD;
    }




    class wreLabelDataWrangler
    {



        public MemoryStream getLabelData(string parcelId)
        {
            try
            {

                // http://www.mocky.io/v2/56726743250000450b995b1c
                // serialize an instance of type NonRegisteredShippingLabel to JSON
                NonRegisteredShippingLabel label = new NonRegisteredShippingLabel();
                //label.packageId = "SX98765";
                //label.actualWeight = "4444 GRAMS";
                //label.shippedDate = "15DEC8";
                //label.shipToAddress = "Jeremy Hall\n55 EAST 52ND STREET\n21ST FLOOR\nNEW YORK, NY 10022\nUSA";
                //label.shippingMethod = "AIRMAIL";
                //label.shippingType = "SMALL PACKET";

                //MemoryStream stream1 = new MemoryStream();
                //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(NonRegisteredShippingLabel));

                //ser.WriteObject(stream1, label);

                //stream1.Position = 0;
                //var sr = new StreamReader(stream1);
                //var myStr = sr.ReadToEnd();
                //Console.WriteLine(myStr);

                //return stream1;


                string url = Properties.Settings.Default.parcelIdApiEndpoint + parcelId;
                var response = new WebClient().DownloadString(url);

                // convert string to stream
                byte[] byteArray = Encoding.UTF8.GetBytes(response);
                MemoryStream result = new MemoryStream(byteArray);


                return result;
            }
            catch (Exception ex)
            {
                throw;
            }



        }

        public NonRegisteredShippingLabel deserializeJSONLabel(Stream labelStream)
        {
            NonRegisteredShippingLabel result;
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(NonRegisteredShippingLabel));
            labelStream.Position = 0;
            result = (NonRegisteredShippingLabel)ser.ReadObject(labelStream);

            Console.Write("Deserialized back, got packageid=");
            Console.Write(result);
            Console.Write(", shipToAddress=");
            Console.WriteLine(result.shipToAddress);

            // convert \n to CRLF and make uppercase
            result.shipToAddress = result.shipToAddress.Replace("\n", Environment.NewLine).ToUpper();

            return result;

            //string[] address = label2.shipToAddress.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Console.WriteLine(BuildShipToLabelEPL(label2));

        }




    }
}
