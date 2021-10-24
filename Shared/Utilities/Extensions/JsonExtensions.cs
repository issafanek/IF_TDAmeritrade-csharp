using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TDAmeritrade.Shared.Utilities.Extensions
{
    public static class JsonExtensions
    {
        public static bool TryDeserializeObject<T>(this string json, out T result)
        {
            try
            {
                result = JsonConfig.DeserializeObject<T>(json);
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }


        //the Instrument and Quotes APIs return json with objects that have the same name of the security. Need to remove that.
        public static string parsedSearchResponse(string json)
        {
            /*
            {"AAC+":{"cusip":"G33032122","symbol":"AAC+","description":"Ares Acquisition Corporation Redeemable Warrants, each whole warrant exercisable","exchange":"NYSE","assetType":"EQUITY"},"AAAU":{"cusip":"38150K103","symbol":"AAAU","description":"Goldman Sachs Physical Gold ETF Shares","exchange":"Pacific","assetType":"ETF"},"AAAG":{"cusip":"00249L104","symbol":"AAAG","description":"AAA Centy Group USA Inc","exchange":"Pink Sheet","assetType":"EQUITY"},"AAAB":{"cusip":"860322106","symbol":"AAAB","description":"STEVIA NUTRA CORP COM","exchange":"Unknown","assetType":"UNKNOWN"},"AABB":{"cusip":"04518L100","symbol":"AABB","description":"Asia Broadband Inc Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AACU":{"symbol":"AACU","description":"Ares Acquisition Corp","exchange":"NYSE","assetType":"EQUITY"},"AACS":{"cusip":"025199100","symbol":"AACS","description":"American Commerce Solutions, Inc. Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AACG":{"cusip":"00211V106","symbol":"AACG","description":"ATA Creativity Global - American Depositary Shares, each representing two common","exchange":"NASDAQ","assetType":"EQUITY"},"AADR":{"cusip":"00768Y206","symbol":"AADR","description":"AdvisorShares Dorsey Wright ADR ETF","exchange":"NASDAQ","assetType":"ETF"},"AADI":{"cusip":"00032Q104","symbol":"AADI","description":"Aadi Bioscience, Inc. - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AAGC":{"cusip":"01643V102","symbol":"AAGC","description":"All American Gold Corp. Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AAGH":{"cusip":"02365T101","symbol":"AAGH","description":"America Great Health Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AAIC":{"cusip":"041356205","symbol":"AAIC","description":"Arlington Asset Investment Corp Class A (new)","exchange":"NYSE","assetType":"EQUITY"},"AAIN":{"cusip":"041356809","symbol":"AAIN","description":"Arlington Asset Investment Corp 6.000% Senior Notes Due 2026","exchange":"NYSE","assetType":"EQUITY"},"AAME":{"cusip":"048209100","symbol":"AAME","description":"Atlantic American Corporation - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AAMC":{"cusip":"02153X108","symbol":"AAMC","description":"Altisource Asset Management Corp Com","exchange":"AMEX","assetType":"EQUITY"},"AANC":{"cusip":"03432G106","symbol":"AANC","description":"Andover National Corporation","exchange":"Pink Sheet","assetType":"EQUITY"},"AAON":{"cusip":"000360206","symbol":"AAON","description":"AAON, Inc. - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AAOI":{"cusip":"03823U102","symbol":"AAOI","description":"Applied Optoelectronics, Inc. - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AAPL":{"cusip":"037833100","symbol":"AAPL","description":"Apple Inc. - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AAPJ":{"cusip":"00037T103","symbol":"AAPJ","description":"AAP, Inc. Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AANw":{"cusip":"00258W108","symbol":"AANw","description":"Aarons Holdings Company, Inc. Common Stock When Issued","exchange":"NYSE","assetType":"EQUITY"},"AAQC":{"cusip":"00439D102","symbol":"AAQC","description":"Accelerate Acquisition Corp. Class A Common Stock","exchange":"NYSE","assetType":"EQUITY"},"AAPT":{"cusip":"01644F106","symbol":"AAPT","description":"All American Pet Company, Inc. Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AASP":{"cusip":"379413107","symbol":"AASP","description":"Global Acquisitions Corporation Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AASL":{"cusip":"03063J205","symbol":"AASL","description":"America\u0027s Suppliers, Inc. Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AATP":{"cusip":"008389108","symbol":"AATP","description":"Agape ATP Corporation Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AATC":{"cusip":"053306106","symbol":"AATC","description":"Autoscope Technologies Corporation - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AATV":{"cusip":"00650A100","symbol":"AATV","description":"Adaptive Ad Systems, Inc. NEW Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AAVC":{"cusip":"04634V107","symbol":"AAVC","description":"ASTRA VENTURES INC COM","exchange":"Unknown","assetType":"UNKNOWN"},"AAWH":{"cusip":"04351N106","symbol":"AAWH","description":"ASCEND WELLNESS HOLDINGS INC CL A","exchange":"Pink Sheet","assetType":"EQUITY"},"AAXT":{"cusip":"00252R303","symbol":"AAXT","description":"Aamaxan Transport Group, Inc. Common Stock","exchange":"Pink Sheet","assetType":"EQUITY"},"AAXN":{"cusip":"05464C101","symbol":"AAXN","description":"Axon Enterprise, Inc. - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"},"AAXJ":{"cusip":"464288182","symbol":"AAXJ","description":"iShares MSCI All Country Asia ex Japan Index Fund","exchange":"NASDAQ","assetType":"ETF"},"AAWW":{"cusip":"049164205","symbol":"AAWW","description":"Atlas Air Worldwide Holdings - Common Stock","exchange":"NASDAQ","assetType":"EQUITY"}}

            */

            //convert to array
            //json = "[" + json.Substring(1,json.Length - 2) + "]";
            //Console.WriteLine(json);
            
            
            //need to remove the first property, and just keep the instrument JSON objects
            int i = 1;
            int jsonDepth = 0;
            while(i<json.Length - 1)
            {
                //Console.WriteLine(i + ":" +json[i] +":" + jsonDepth);
                if(json[i] == '{') jsonDepth = jsonDepth + 1;
                else if(json[i] == '}') jsonDepth = jsonDepth - 1;
                else if(json[i] == ':' && jsonDepth == 0)
                {
                    //bingo.. remove that property..
                    int endIndex = i;
                    int startIndex = i-1;
                    while(json[startIndex] != '{' && json[startIndex] != '[' && json[startIndex] != ',')
                    {
                        Console.WriteLine(endIndex + ":" + startIndex +":" +json[startIndex] + ":" + jsonDepth);
                        startIndex--;
                    }
                    startIndex+=1;
                    json = json.Remove(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(json);
                    i = 0;
                    //jsonDepth++;
                    //Console.WriteLine(((int)json[i]).ToString() + "," + json[i] + "," + ((int)'{').ToString() + "," + '{');
                }

                i++;
            }
            return json;
        }
    }
    public class EpochTimestampConverter : DateTimeConverterBase
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(EpochTimestampFromDateTime((DateTime)value).ToString());
        }
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return reader.Value == null ? _epoch : TimeFromEpochTimestamp((long)reader.Value);
        }
        private static DateTime TimeFromEpochTimestamp(long epochTimestamp)
        {
            return _epoch.AddMilliseconds(epochTimestamp);
        }
        public static long EpochTimestampFromDateTime(DateTime date)
        {
            long epochTimestamp = (date - _epoch).Milliseconds;
            return epochTimestamp;
        }
    }
}

