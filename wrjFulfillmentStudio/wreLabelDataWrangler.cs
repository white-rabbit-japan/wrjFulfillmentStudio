using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using System.Windows.Forms;

namespace wrjFulfillmentStudio
{

    // Type created for JSON at <<root>>
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NonRegisteredShippingLabel
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ShippingInfo shippingInfo;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomsInfo customsInfo;
    }

    // Type created for JSON at <<root>> --> shippingInfo
    [System.Runtime.Serialization.DataContractAttribute(Name = "shippingInfo")]
    public partial class ShippingInfo
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string actualWeight;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string packageId;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shipToAddress;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shippedDate;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shippingMethod;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string shippingType;

    }

    // Type created for JSON at <<root>> --> customsInfo
    [System.Runtime.Serialization.DataContractAttribute(Name = "customsInfo")]
    public partial class CustomsInfo
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public CustomsItem[] customsItems;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customsTotalValue;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isMerchandise;
    }

    // Type created for JSON at <<root>> --> customsInfo --> customsItems
    [System.Runtime.Serialization.DataContractAttribute(Name = "customsItems")]
    public partial class CustomsItem
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string value;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int quantity;
    }


    class wreLabelDataWrangler
    {

        public MemoryStream getLabelData(string parcelId)
        {
            try
            {

                // http://www.mocky.io/v2/567798ca0f00006b005007ad
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
                if (ex is WebException )
                {
                    MessageBox.Show("Server can't find this page." + Environment.NewLine + ex.Message);
                    return null;
                } 
                else
                { 

                throw;
            }}

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
            Console.WriteLine(result.shippingInfo.shipToAddress);

            // convert \n to CRLF and make uppercase
            result.shippingInfo.shipToAddress = result.shippingInfo.shipToAddress.Replace("\n", Environment.NewLine).ToUpper();

            return result;

            //string[] address = label2.shipToAddress.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Console.WriteLine(BuildShipToLabelEPL(label2));

        }




    }
}
