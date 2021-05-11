using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Decorator
{
    /// <summary>
    /// Декоратор для телефона Nokia
    /// </summary>
    public class PhoneNokia : DecoratorPhone
    {
        public PhoneNokia(BasePhone phone) : base(phone)
        {
        }

        public override string PhoneName { get { return "Nokia 5"; } }
        public override String ScreenResolution { get { return "1280x720"; } }
        public override Int32 ScreenDiagonal { get { return 0; } } 
        public override string DisplayType { get { return "IPS"; } }
        public override string OperatingSystem { get { return "Android 7.1"; } }
        public override Int32 CPU { get { return 8; } } 
        public override Int32 Memory { get { return 16; } }
        public override Int32 RAM { get { return 2; } }
        public override Int32 Camera { get { return 13; } }
        public override Int32 Battery { get { return 3000; } }

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
