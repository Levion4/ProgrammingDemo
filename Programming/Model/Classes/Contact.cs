using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _number;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="surname">Фамилия.</param>
        /// <param name="number">Номер телефона.</param>
        /// <param name="city">Город.</param>
        public Contact(string name, string surname, string number, string city)
        {
            Number = number;
            Name = name;
            Surname = surname;
            City = city;
        }

        /// <summary>
        /// Возвращает и задает город контакта.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            } 
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта. Должен состоять из 11 цифр.
        /// </summary>
        /// <exception cref="ArgumentException">Возникает, 
        /// когда номер телефона состоит не только из цифр и 
        /// количество цифр не равно 11.</exception>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException(
                        $"The number must contain 11 digits, " +
                        $"but was {value.Length}");
                }

                if (!int.TryParse(value, out var x))
                {
                    throw new ArgumentException(
                        $"The number must contain only digits");
                }

                _number = value;
            }
        }
    }
}
