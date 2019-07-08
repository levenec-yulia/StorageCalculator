using StorageCalculator.Common;
using System;
using System.Collections.Generic;
using StorageCalculator.Interfaces;

namespace StorageCalculator.Models
{
    /// <summary>
    /// Информаця о хранилище грузов
    /// </summary>
    public class StorageInfo : IBoxable
    {
        private List<StorageStateInfo> _changInfos;

        /// <summary>
        /// Конструктор инициализации
        /// (он ОБЯЗАТЕЛЕН ввиду угрозы выброса NulllReferenc Exception)
        /// </summary>
        public StorageInfo()
        {
            Y = 0;
            X = 0;
            Z = 0;
            _changInfos = new List<StorageStateInfo>();
            CargoType = new CargoInfo();
        }

        /// <summary>
        /// Высота склада
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Ширина склада
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Глубина склада
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Тип груза на складе
        /// </summary>
        public CargoInfo CargoType { get; set; }

        /// <summary>
        /// Получение копиии спискака загруженности склада
        /// </summary>
        public List<StorageStateInfo> CloneChangeInfos
        {
            get
            {
                _changInfos.Sort((x, y) => x.TimeChange.CompareTo(y.TimeChange));

                List<StorageStateInfo> newInfos = new List<StorageStateInfo>();

                foreach (StorageStateInfo info in _changInfos)
                {
                    newInfos.Add(info);
                }
                return newInfos;
            }
        }

        /// <summary>
        /// Фиксирование изменений в загруженности склада
        /// </summary>
        /// <param name="info">The information.</param>
        public void AddChangeInfo(StorageStateInfo info)
        {
            _changInfos.Add(info);
            _changInfos.Sort((x, y) => x.TimeChange.CompareTo(y.TimeChange));
        }

        /// <summary>
        /// Максимальная вместимость склада
        /// </summary>
        /// <returns></returns>
        public int CalculateMaxCapacity()
        {
            //проверка деления на ноль
            if(CargoType.Y == 0 || CargoType.X == 0 || CargoType.Z == 0)
            {
                throw new Exception(ErrorConstants.CANT_CALCULATE_MAX_CAPACITY);
            }

            int maxCargoY = Y / CargoType.Y;
            int maxCargoX = X / CargoType.X;
            int maxCargoZ = Z / CargoType.Z;

            return maxCargoY * maxCargoX * maxCargoZ;
        }

        /// <summary>
        /// Заполненность склада
        /// </summary>
        /// <returns></returns>
        public int CalculateOccupancy()
        {
            if (CloneChangeInfos == null || CloneChangeInfos.Count == 0)
            {
                throw new Exception(ErrorConstants.CANT_CALCULATE_OCCUPANCY);
            }

            return CloneChangeInfos[CloneChangeInfos.Count - 1].StorageFullness;
        }

        /// <summary>
        /// Свободное пространство на складе
        /// </summary>
        /// <returns></returns>
        public int CalculateFreeSpace()
        {
            return CalculateMaxCapacity() - CalculateOccupancy();
        }
    }
}