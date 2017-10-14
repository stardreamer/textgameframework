using System;
using Xunit;
using TextGameFramework.Ensure;

namespace TextGameFramework.Ensure.Tests
{
    public class EnsureTests
    {
        [Fact]
        public void ShouldAlwaysWork()
        {
            Assert.True(true);
        }

        [Fact]
        public void ShouldThrowExceptionWhenWrongValueWasPassedToIsPositive()
        {
            var testValue = -11;
            var ex = Assert.Throws<EnsureException>(() => Ensure.IsPositive(nameof(testValue),testValue));
            Assert.True(ex.Message.Contains(nameof(testValue)) && ex.Message.Contains("positive"));
        }

        [Fact]
        public void ShouldThrowExceptionWhenWrongValueWasPassedToIsNegative()
        {
            var testValue = 11;
            var ex = Assert.Throws<EnsureException>(() => Ensure.IsNegative(nameof(testValue),testValue));
            Assert.True(ex.Message.Contains(nameof(testValue)) && ex.Message.Contains("negative"));
        }
    }
}
