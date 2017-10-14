using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace TextGameFramework.IO.Parser
{
    public class Character
    {
        [YamlMember(typeof(string), Alias = "Имя")]
        public string Name {get; set;}

        [YamlMember(typeof(string), Alias = "Тип")]
        public string Type {get; set;}

        [YamlMember(typeof(string), Alias = "Пол")]
        public string Gender {get; set;}

        [YamlMember(typeof(string), Alias = "Описание")]
        public string Description {get; set;}

        [YamlMember(typeof(int), Alias = "Телосложение")]
        public int Stamina {get; set;}

        [YamlMember(typeof(int), Alias = "Сила")]
        public int Strength {get; set;}

        [YamlMember(typeof(int), Alias = "Интеллект")]
        public int Intelligence {get; set;}

        [YamlMember(typeof(int), Alias = "Ловкость")]
        public int Dexterity {get; set;}

        [YamlMember(typeof(int), Alias = "Золото")]
        public int Gold {get; set;}

        [YamlMember(typeof(int), Alias = "Опыт")]
        public int Experience {get; set;}

        [YamlMember(typeof(int), Alias = "Возраст")]
        public int Age {get; set;}

        [YamlMember(typeof(int), Alias = "Сюжет")]
        public int PlotPoints {get; set;}

        [YamlMember(typeof(List<CustomProperties>), Alias = "Побочные свойства")]
        public List<CustomProperties> CustomProperties {get;set;}

        [YamlMember(typeof(List<string>), Alias = "Инвентарь")]
        public List<string> Inventory {get;set;}



    }
}