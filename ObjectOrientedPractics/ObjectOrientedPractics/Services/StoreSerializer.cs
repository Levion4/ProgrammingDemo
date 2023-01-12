using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации данных о магазине.
    /// </summary>
    public static class StoreSerializer
    {
        /// <summary>
        /// Возвращает и задает путь к файлу.
        /// </summary>
        public static string Filename { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="StoreSerializer"/>
        /// </summary>
        static StoreSerializer()
        {
            var appDataFolder =
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Lunev\ObjectOrientedPractics\userdata.json";
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
        /// Сохраняет данные о товарах в файл.
        /// </summary>
        /// <param name="store">Данные о магазине, которые нужно сохранить.</param>
        /// <exception cref="Exception">Возникает, 
        /// если произошла ошибка при сохранении.</exception>
        public static void SaveToFile(Store store)
        {
            try
            {
                CreateDirectory();
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                JsonSerializer serializer = new JsonSerializer();
                serializer = JsonSerializer.Create(settings);
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, store);
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
        /// <returns>Возвращает список товаров.</returns>
        public static Store LoadFromFile()
        {
            Store item = null;

            try
            {
                CreateDirectory();
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };
                JsonSerializer serializer = new JsonSerializer();
                serializer = JsonSerializer.Create(settings);
                using (StreamReader sr = new StreamReader(Filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    item = serializer.Deserialize<Store>(reader);
                }
            }
            catch
            {
                return new Store();
            }

            return item;
        }
    }
}
