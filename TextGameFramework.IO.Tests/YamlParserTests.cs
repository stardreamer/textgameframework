using System;
using Xunit;
using System.IO;
using TextGameFramework.IO.Parser;

namespace TextGameFramework.IO.Tests
{
    public class YamlParserTests
    {
        private void SetUpTest()
        {
            Directory.SetCurrentDirectory("../../../Parser/v0.0.1");
        }

        [Fact]
        public void ShouldWork()
        {
            SetUpTest();
            Assert.True(true);
        }
    }
}
