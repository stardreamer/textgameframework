using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class GameEvent
    {
        [YamlMember(typeof(string), Alias = "Название")]
        public string Name {get; set;}

        [YamlMember(typeof(string), Alias = "Описание")]
        public string Description {get; set;}

        [YamlMember(typeof(List<string>), Alias = "Условия")]
        public List<string> Conditions {get; set;}

        [YamlMember(typeof(List<GameAction>), Alias = "Действия")]
        public List<GameAction> GameActions {get; set;}
    }
}