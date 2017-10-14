using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class GameBranch
    {
        [YamlMember(typeof(string), Alias = "Ветка")]
        public string Name {get; set;}

        [YamlMember(typeof(string), Alias = "Описание")]
        public string Description {get; set;}

        [YamlMember(typeof(List<GameEvent>), Alias = "События")]
        public List<GameEvent> Events {get; set;}
    }
}