using System.IO;

namespace TextGameFramework.IO.Parser
{
    public static class YamlParser
    {
        public static YamlConfig Parse(string filepath)
        {
                var deserializer = new YamlDotNet.Serialization.DeserializerBuilder().Build();
                using (Stream stream = File.OpenRead(filepath))
                {
                    using (TextReader reader = new StreamReader(stream))
                    {
                        var preparsedConfig = deserializer.Deserialize<YamlConfig>(reader);
                        return preparsedConfig;
                    }
                }
        }
    }
}