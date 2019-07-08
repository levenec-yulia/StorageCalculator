namespace StorageCalculator.Interfaces
{
    /// <summary>
    /// Интерфейс объеденяющий все типы хранилищ
    /// </summary>
    public interface IBoxable
    {
        /// <summary>
        /// Высота
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Глубина
        /// </summary>
        int Z { get; set; }
    }
}
