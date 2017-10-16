using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class GameAction
    {
        [YamlMember(typeof(string), Alias = "Вариант")]
        public string Variant {get; set;}

        [YamlMember(typeof(List<string>), Alias = "Условия")]
        public List<string> Conditions {get; set;}

        [YamlMember(typeof(List<Effect>), Alias = "Эффекты")]
        public List<Effect> Effects {get;set;}
    }
}