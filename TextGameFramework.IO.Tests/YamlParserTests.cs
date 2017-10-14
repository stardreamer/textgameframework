using System;
using Xunit;
using System.IO;
using TextGameFramework.IO.Parser;

namespace TextGameFramework.IO.Tests
{
    public class YamlParserTests
    {

        private const string _testDataFolder = "../../../Parser/v0.0.1/";
        [Fact]
        public void ShouldWork()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldWorkWhenCorrectFileIsGeiven()
        {
            var conf = YamlParser.Parse(Path.Combine(_testDataFolder, "simple-correct-example.yaml"));
            //sanity check
            Assert.True(true);
        }
    }
}
