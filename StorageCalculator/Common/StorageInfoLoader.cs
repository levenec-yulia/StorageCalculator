using System;
using System.IO;
using Newtonsoft.Json;
using StorageCalculator.Models;

namespace StorageCalculator.Common
{
    /// <summary>
    /// Манипулирование данными о складе
    /// </summary>
    public static class StorageInfoLoader
    {
        /// <summary>
        /// Сохранение данных склада
        /// </summary>
        /// <param name="storage"></param>
        public static void Save(StorageInfo storage)
        {
            //преобразование класса хранения данных о складе в строку для поледующего сохранения в файл
            string jasonData = JsonConvert.SerializeObject(storage);

            //сохранение в файл
            File.WriteAllText(PathConstants.SETTINGS_FILE_PATH, jasonData);
        }

        /// <summary>
        /// Загрузка данных о складе
        /// </summary>
        /// <returns>StorageInfo загруженный из файла</returns>
        public static StorageInfo Load()
        {
            //проверка на налицие файла с настройками
            if (!File.Exists(PathConstants.SETTINGS_FILE_PATH))
            {
                //если его нет , значит настрок ранее небыло кохранено и создаётся новый файл настроек
                return new StorageInfo();
            }

            //иначе если файл пристутствует, считываем его текст
            string jasonData = File.ReadAllText(PathConstants.SETTINGS_FILE_PATH);
            
            //Файл найден но пуст
            if (string.IsNullOrEmpty(jasonData))
            {
                throw new Exception(ErrorConstants.CANT_LOAD_DATA);
            }

            //преобразовываем смчтанные данные в объект
            StorageInfo storage = JsonConvert.DeserializeObject<StorageInfo>(jasonData);

            //не удалось преобразовать данные
            if (storage == null)
            {
                throw new Exception(ErrorConstants.CANT_LOAD_DATA);
            }

            //возвращаем загруженные данные
            return storage;
        }
    }
}