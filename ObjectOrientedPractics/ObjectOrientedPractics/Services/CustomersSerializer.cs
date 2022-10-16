﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации данных о покупателях.
    /// </summary>
    public class CustomersSerializer
    {
        /// <summary>
        /// Возвращает и задает путь к файлу.
        /// </summary>
        public static string Filename { get; set; }
        
        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersSerializer"/>
        /// </summary>
        static CustomersSerializer()
        {
            var appDataFolder =
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Lunev\ContactApp\userdataCustomers.json";
            Filename = appDataFolder;
        }

        /// <summary>
        /// Проверяет, существует ли папка, указанная в свойстве Filename.
        /// И, если папка не существует, то создает папку.
        /// </summary>
        public static void CreateDirectory()
        {
            if (!Directory.Exists(Filename))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Filename));
            }
        }

        /// <summary>
        /// Сохраняет данные о покупателях в файл.
        /// </summary>
        /// <param name="customer">Список покупателей, которых нужно сохранить.</param>
        /// <exception cref="Exception">Возникает, 
        /// если произошла ошибка при сохранении.</exception>
        public static void SaveToFile(List<Customer> customer)
        {
            try
            {
                CreateDirectory();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, customer);
                }
            }
            catch
            {
                throw new Exception($"An error occurred while saving data to a file.");
            }
        }

        /// <summary>
        /// Загружает данные из файла и передает их в список.
        /// </summary>
        /// <returns>Возвращает список покупателей.</returns>
        public static List<Customer> LoadFromFile()
        {
            List<Customer> customer = null;
            try
            {
                CreateDirectory();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(Filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    customer = serializer.Deserialize<List<Customer>>(reader);
                }
            }
            catch
            {
                return new List<Customer>();
            }

            return customer;
        }
    }
}
