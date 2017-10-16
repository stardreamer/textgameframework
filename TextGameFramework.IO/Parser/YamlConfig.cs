using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TextGameFramework.IO.Parser
{
    public class YamlConfig
    {
        [YamlMember(typeof(string), Alias = "Версия")]
        public string Version {get; set;}

        [YamlMember(typeof(string), Alias = "Название")]
        public string Name {get; set;}

        [YamlMember(typeof(List<Item>), Alias = "Кладовая")]
        public List<Item> Warehouse {get;set;}

        [YamlMember(typeof(List<Character>), Alias = "Персонажи")]
        public List<Character> Characters {get;set;}

        [YamlMember(typeof(List<GameEvent>), Alias = "Случайные события")]
        public List<GameEvent> RandomEvents {get;set;}

        [YamlMember(typeof(List<GameBranch>), Alias = "Сюжет")]
        public List<GameBranch> Plot {get;set;}

        [YamlMember(typeof(List<GameAction>), Alias = "Действия")]
        public List<GameAction> Actions {get;set;}
        
    }
}