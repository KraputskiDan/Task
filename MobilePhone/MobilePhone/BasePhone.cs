using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib
{
    /// <summary>
    /// Базовый интерфейс телефона
    /// </summary>
    public abstract class BasePhone
    {
        /// <summary>
        /// Название телефона
        /// </summary>
        public abstract String PhoneName { get; set; } 
        /// <summary>
        /// Разрешение экрана
        /// </summary>
        public abstract String ScreenResolution { get; set; }
        /// <summary>
        /// Диагональ экрана
        /// </summary>
        public abstract Int32 ScreenDiagonal { get; set; }
        /// <summary>
        /// Тип дисплея
        /// </summary>
        public abstract string DisplayType { get; set; }
        /// <summary>
        /// Операционная система
        /// </summary>
        public abstract string OperatingSystem { get; set; }
        /// <summary>
        /// Количество ядер процессора
        /// </summary>
        public abstract Int32 CPU { get; set; }
        /// <summary>
        /// Внутрення память
        /// </summary>
        public abstract Int32 Memory { get; set; }
        /// <summary>
        /// Оперативная память
        /// </summary>
        public abstract Int32 RAM { get; set; }
        /// <summary>
        /// Колиство МП камеры
        /// </summary>
        public abstract Int32 Camera { get; set; }
        /// <summary>
        /// Емкость аккумулятора
        /// </summary>
        public abstract Int32 Battery { get; set; }

        /// <summary>
        /// Получение информации о телефоне
        /// </summary>
        /// <returns></returns>
        public abstract String GetInformation();

    }
}
