using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LoadKeplerthData
{
    public class KeyValuePairConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Dictionary<KeyValuePair<int, long>, ulong>);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Dictionary<KeyValuePair<int, long>, ulong> result = new Dictionary<KeyValuePair<int, long>, ulong>();
            while(true)
            {
                string current = reader.ReadAsString();
                if (current == null)
                    break;
                string[] currentsplit = current.Split(':');
                result.Add(new KeyValuePair<int, long>(int.Parse(currentsplit[0]), long.Parse(currentsplit[1])), ulong.Parse(currentsplit[2]));
            }
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteStartArray();
            foreach (KeyValuePair<KeyValuePair<int, long>, ulong> entry in (Dictionary<KeyValuePair<int, long>, ulong>)value)
            {
                writer.WriteValue(String.Format("{0}:{1}:{2}", entry.Key.Key, entry.Key.Value, entry.Value));
            }
            writer.WriteEndArray();
        }
    }
}
