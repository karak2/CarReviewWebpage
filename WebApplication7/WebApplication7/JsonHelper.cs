using System.IO;
using System.Runtime.Serialization.Json;

namespace WebApplication7
{
    public static class JsonHelper
    {

        public static string ToJsonString<T>(T obj)
        {
            var serialzer = new DataContractJsonSerializer(typeof(T));
            using (var stream = new MemoryStream())
            {
                serialzer.WriteObject(stream, obj);
                stream.Position = 0;
                using (var streamReader = new StreamReader(stream))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
        }

        public static T FromJsonString<T>(string json)
        {
            var serialzer = new DataContractJsonSerializer(typeof(T));
            using (var stream = GenerateStreamFromString(json))
            {
                return (T)serialzer.ReadObject(stream);
            }
        }

        private static Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}