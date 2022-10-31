using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для валидации.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на определенную длину.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="length">Длина,
        /// на которую проверяется строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда
        /// длина строки не равна определенной длины.</exception>
        public static void AssertStringOnCertainLength(string value,
            int length, string propertyName)
        {
            if (value.Length != length)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be equal to" +
                    $" {length}, but was {value}.");
            }
        }

        /// <summary>
        /// Проверяет строку на длину.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимально возможная длина.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое
        /// подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, когда
        /// длина строки больше максимально возможной длины.</exception>
        public static void AssertStringOnLength(string value,
            int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range" +
                    $" up to {maxLength}, but was {value}.");
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
        public static void AssertValueInRange(double value,
            double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"The {propertyName} should be in the range from {min} to {max}, " +
                    $"but was {value}");
            }
        }
    }
}
