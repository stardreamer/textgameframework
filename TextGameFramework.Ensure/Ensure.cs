using System;
using System.ComponentModel;
using System.Linq;

namespace TextGameFramework.Ensure
{
    public static class Ensure
    {
        private static string GetDescriptionFromType(string valueName, Type parentType)
        {
            var property = parentType.GetProperty(valueName);
            if (property == null)
            {
                return null;
            }

            var descriptions = property.GetCustomAttributes(typeof(DescriptionAttribute), true);

            return !descriptions.Any() ? null : (descriptions[0] as DescriptionAttribute)?.Description;
        }

        private static void ThrowEnsureException<T>(string valueName, T value, string validationProblem, Type parentType = null)
        {
            if(parentType == null)
                throw new EnsureException($"There is a problem with variable {valueName}! {validationProblem}! Current value {value}!");
            
            var description = GetDescriptionFromType(valueName, parentType);

            throw new EnsureException($"There is a problem with variable {valueName}({description})! {validationProblem}! Current value {value}!");
        }

        private static void PerformEnsureCheck<T>(string valueName, T value, Func<T,bool> condition, string valueProblem, Type parentType = null)
        {
            if(condition(value))
                return;
            
            ThrowEnsureException(valueName, value, valueProblem, parentType);
        }

        public static void IsPositive(string valueName, double value, Type parentType = null)
        {
            PerformEnsureCheck(valueName, value, (v) => v > 0, "Must be positive", parentType);
        }

        public static void IsNegative(string valueName, double value, Type parentType = null)
        {
            PerformEnsureCheck(valueName, value, (v) => v < 0, "Must be negative", parentType);
        }
    }
}
