using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CustomerJsonConverter
{
    public class SSNMaskConverter : JsonConverter<string>
    {
        public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
        public override void Write(Utf8JsonWriter writer, string SSN, JsonSerializerOptions options)
        {
            try
            {
                writer.WriteStringValue(String.Format("XXX-XX-{0}", SSN.Substring(SSN.Length - 4)));
            }
            catch(Exception ex)
            {
                throw new Exception("Check SSN has the following format XXX-XX-XXXX \n" + ex);
            }
        }
    }
}
