using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib
{
    /// <summary>
    /// Конкретный телефон
    /// </summary>
    public class SimplePhone : BasePhone
    {       
        public override string PhoneName { get; set; }

        public override Int32 Battery { get; set; }

        public override Int32 Camera { get; set; }

        public override Int32 RAM { get; set; }

        public override string ScreenResolution { get; set; }

        public override Int32 ScreenDiagonal { get; set; }

        public override string DisplayType { get; set; }

        public override string OperatingSystem { get; set; }

        public override Int32 CPU { get; set; }

        public override Int32 Memory { get; set; }

        public override String GetInformation()
        {
            return $"Название телефона: {PhoneName}\n" +
                   $"Разрешение экрана: {ScreenResolution}\n" +
                   $"Диагональ экрана: {ScreenDiagonal}\n" +
                   $"Тип дисплея: { DisplayType}\n" +
                   $"ОС телефона: {OperatingSystem }\n" +
                   $"Количество ядер процессора: {CPU}\n" +
                   $"Внутрення память: {Memory}\n" +
                   $"Оперативная память: {RAM}\n" +
                   $"Количество МП камеры: {Camera}\n" +
                   $"Емкость аккумулятора в мАч: {Battery}\n";
        }
    }
}
