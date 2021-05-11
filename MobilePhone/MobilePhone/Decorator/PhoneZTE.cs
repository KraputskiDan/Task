using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Decorator
{
    /// <summary>
    /// Декоратор для телефона ZTE
    /// </summary>
    public class PhoneZTE : DecoratorPhone
    {
        public PhoneZTE(BasePhone phone) : base(phone)
        {
        }

        public override string PhoneName { get { return "ZTE Blade L8"; } }
        public override String ScreenResolution { get { return "960x480"; } }
        public override Int32 ScreenDiagonal { get { return 5; } }
        public override string DisplayType { get { return "TFT"; } }
        public override string OperatingSystem { get { return "Android 9"; } }
        public override Int32 CPU { get { return 4; } }
        public override Int32 Memory { get { return 16; } }
        public override Int32 RAM { get { return 1; } }
        public override Int32 Camera { get { return 8; } }
        public override Int32 Battery { get { return 2000; } }

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
