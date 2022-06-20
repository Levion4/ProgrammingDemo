using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
    public static class Validator
    {
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) && !char.IsWhiteSpace(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contains letters only.");
                }
            }
        }

        public static void AssertValueInRange(int value, int max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range up to {max}, " +
                    $"but was {value}.");
            }
        }

        public static void AssertValueInRange(DateTime value, DateTime max, string propertyName)
        {
            if (value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range up to {max}, " +
                    $"but was {value}.");
            }
        }

        public static void IsUrlValid(string value, string propertyName)
        {
            if(!Regex.IsMatch(value, @"(https?:\/\/)?(www\.)?(vk.com\/)(id\d|[a-zA-z][a-zA-Z0-9_.]{2,})"))
            {
                throw new ArgumentException($"There must be a url link to {propertyName}.");
            }
        }

        public static void IsPhoneValid(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^(\+)[\d]{11}$"))
            {
                throw new ArgumentException(
                    $"The {propertyName} must start with '+' and contain 11 digits.");
            }
        }
    }
}
