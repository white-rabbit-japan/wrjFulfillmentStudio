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

    [DataContract]
    internal class NonregisteredShippingLabel
    {
        [DataMember]
        internal string shippedDate;

        [DataMember]
        internal string packageId;

        [DataMember]
        internal string actualWeight;

        [DataMember]
        internal string shipToAddress;

        [DataMember]
        internal string shippingMethod;

        [DataMember]
        internal string shippingType;
    }


    class wreLabelDataWrangler
    {

 

        public MemoryStream getLabelData(string parcelId)
        {
            try
            {
        
                // http://www.mocky.io/v2/56726743250000450b995b1c
                // serialize an instance of type NonregisteredShippingLabel to JSON
                NonregisteredShippingLabel label = new NonregisteredShippingLabel();
                //label.packageId = "SX98765";
                //label.actualWeight = "4444 GRAMS";
                //label.shippedDate = "15DEC8";
                //label.shipToAddress = "Jeremy Hall\n55 EAST 52ND STREET\n21ST FLOOR\nNEW YORK, NY 10022\nUSA";
                //label.shippingMethod = "AIRMAIL";
                //label.shippingType = "SMALL PACKET";

                //MemoryStream stream1 = new MemoryStream();
                //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(NonregisteredShippingLabel));

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

        public NonregisteredShippingLabel deserializeJSONLabel(Stream labelStream)
        {
            NonregisteredShippingLabel result;
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(NonregisteredShippingLabel));
            labelStream.Position = 0;
            result = (NonregisteredShippingLabel)ser.ReadObject(labelStream);

            Console.Write("Deserialized back, got packageid=");
            Console.Write(result.packageId);
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
