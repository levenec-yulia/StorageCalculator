using System;

namespace StorageCalculator.Models
{
    public class StorageCapacityStateInfo
    {
        /// <summary>
        /// Конструктор инициализации
        /// (он не обязателен, однако в зависимости от версии .NET работа базовых инициализаторов может отличатся)
        /// </summary>
        public StorageCapacityStateInfo()
        {
            StorageCapacity = 0;
            TimeChange = DateTime.Now;
        }

        /// <summary>
        /// Общее пространство на складе на складе
        /// </summary>
        public int StorageCapacity { get; set; }

        /// <summary>
        /// Время внесения изменений в склад
        /// </summary>
        public DateTime TimeChange { get; set; }
    }
}