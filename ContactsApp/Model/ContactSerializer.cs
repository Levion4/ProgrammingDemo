using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ContactsApp.Model
{
    /// <summary>
    /// Предоставляет методы для сериализации данных.
    /// </summary>
    public class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь к файлу.
        /// </summary>
        public static string Filename { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        static ContactSerializer()
        {
            var appDataFolder = 
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\Lunev\ContactApp\userdata.json";
            Filename = appDataFolder;
        }

        /// <summary>
        /// Проверяет, существует ли папка, указанная в свойстве Filename.
        /// И, если папка не существует, то создает папку.
        /// </summary>
        public static void CheckDirectory()
        {
            if (!Directory.Exists(Filename))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Filename));
            }
        }

        /// <summary>
        /// Сохраняет данные о контактах в файл.
        /// </summary>
        /// <param name="contact">Список контактов, которые нужно сохранить.</param>
        /// <exception cref="Exception">Возникает, 
        /// если произошла ошибка при сохранении.</exception>
        public static void SaveToFile(List<Contact> contact)
        {
            try
            {
                CheckDirectory();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(Filename))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, contact);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// Загружает данные из файла и передает их в список.
        /// </summary>
        /// <returns>Возвращает список контактов.</returns>
        public static List<Contact> LoadFromFile()
        {
            List<Contact> contact = null;
            try
            {
                CheckDirectory();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(Filename))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    contact = serializer.Deserialize<List<Contact>>(reader);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return contact;
        }

    }
}
