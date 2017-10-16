using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class Item
    {
        [YamlMember(typeof(string), Alias = "Предмет")]
        public string Name {get; set;}

        [YamlMember(typeof(string), Alias = "Тип")]
        public string Type {get; set;}

        [YamlMember(typeof(string), Alias = "Описание")]
        public string Desctiption {get; set;}

        [YamlMember(typeof(List<Effect>), Alias = "Эффекты")]
        public List<Effect> Effects {get; set;}
    }
}