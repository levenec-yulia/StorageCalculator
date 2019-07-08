﻿using System;
using System.Windows.Forms.VisualStyles;
using StorageCalculator.Common;

namespace StorageCalculator.Models
{

    /// <summary>
    /// Информация о состоянии заполненности склада на определённый момент времени
    /// </summary>
    public class StorageStateInfo
    {
        /// <summary>
        /// Конструктор инициализации
        /// (он не обязателен, однако в зависимости от версии .NET работа базовых инициализаторов может отличатся)
        /// </summary>
        public StorageStateInfo()
        {
            StorageFullness = 0;
            TimeChange = DateTime.Now;
        }

        /// <summary>
        /// Кол-во элементов на складе
        /// </summary>
        public int StorageFullness { get; set; }

        /// <summary>
        /// Время внесения изменений на склад
        /// </summary>
        public DateTime TimeChange { get; set; }
    }
}