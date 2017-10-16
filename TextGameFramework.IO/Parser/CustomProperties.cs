using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class CustomProperties
    {
        [YamlMember(typeof(string), Alias = "Название")]
        public string Name {get; set;}

        [YamlMember(typeof(int), Alias = "Значение")]
        public string Value {get; set;}
    }
}