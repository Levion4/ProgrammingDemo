using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phone;

        /// <summary>
        /// Ссылка на страницу VK контакта.
        /// </summary>
        private string _vK;

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(FullName));
                _fullName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        public string VK
        {
            get
            {
                return _vK;
            }
            set
            {
                _vK = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="fullName">Полное имя.</param>
        /// <param name="dateOfBirth">Дата рождения.</param>
        /// <param name="phone">Номер телефона.</param>
        /// <param name="vK">Ссылка на страницу VK.</param>
        public Contact(string fullName, DateTime dateOfBirth, string phone, string vK)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            VK = vK;
        }

    }
}
