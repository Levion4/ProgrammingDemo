using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для валидации.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что значение положительное.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение отрицательное или равно нулю.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"The {propertyName} cannot be negative or equal to zero, " +
                    $"but was {value}");
            }
        }

        /// <summary>
        /// Проверяет, что значение положительное.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение отрицательное или равно нулю.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"The {propertyName} cannot be negative or equal to zero, " +
                    $"but was {value}");
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение не входит в заданный диапазон.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}");
            }
        }

        /// <summary>
        /// Проверяет, что значение входит в заданный диапазон.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница диапазона.</param>
        /// <param name="max">Верхняя граница диапазона.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда значение не входит в заданный диапазон.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверямая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда строка строка состоит не только из букв.</exception>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            for (var i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new ArgumentException($"{propertyName} must contains letters only");
                }
            }
        }
    }
}
