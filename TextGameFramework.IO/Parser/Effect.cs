using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class Effect
    {
        [YamlMember(typeof(List<string>), Alias = "Описание")]
        public List<string> Description {get; set;}

        [YamlMember(typeof(List<string>), Alias = "Следствие")]
        public List<string> Consequences {get; set;}

        [YamlMember(typeof(float), Alias = "Шанс")]
        public float? Chance {get; set;}

        [YamlMember(typeof(GameEvent), Alias = "Событие")]
        public GameEvent Event {get; set;}
    }
}