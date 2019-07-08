using StorageCalculator.Interfaces;

namespace StorageCalculator.Models
{
    /// <summary>
    /// Информация о размере груз Кранящегося на складе
    /// </summary>
    public class CargoInfo : IBoxable
    {
        /// <summary>
        /// КОнструктор инициализации
        /// (он не обязателен, однако в зависимости от версии .NET работа базовых инициализаторов может отличатся)
        /// </summary>
        public CargoInfo()
        {
            Y = 0;
            X = 0;
            Z = 0;
        }

        /// <summary>
        /// Высота контейнера
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Ширина контейнера
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Глубина контейнера
        /// </summary>
        public int Z { get; set; }
    }
}