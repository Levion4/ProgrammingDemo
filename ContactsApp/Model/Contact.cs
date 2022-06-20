﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ContactsApp.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Ограничение на количество символов в полном имяни контакта.
        /// </summary>
        private readonly int _characterLimit = 150;

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

        /// <summary>
        /// Возвращает и задает полное имя контакта.
        /// Должно состоять только из букв. Длина не более 150 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(FullName));
                Validator.AssertValueInRange(value.Length, _characterLimit, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает дату рождения контакта.
        /// Не должна быть больше текущего дня.
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                Validator.AssertValueInRange(value, DateTime.Today, nameof(FullName));
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// Должен начинаться с "+" и содержать 11 цифр.
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                Validator.IsPhoneValid(value, nameof(Phone));
                _phone = value;
            }
        }

        /// <summary>
        /// Возвращает и задает url-ссылку на VK контакта.
        /// Должна быть ссылкой на страницу ползователя VK.
        /// </summary>
        public string VK
        {
            get
            {
                return _vK;
            }
            set
            {
                Validator.IsUrlValid(value, nameof(VK));
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
        [JsonConstructor]
        public Contact(string fullName, DateTime dateOfBirth, string phone, string vK)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            VK = vK;
        }

    }
}
