using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    throw new ArgumentException($"{propertyName} must contains letters only");
                }
            }
        }
    }
}
