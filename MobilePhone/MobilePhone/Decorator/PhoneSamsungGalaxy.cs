using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Decorator
{
    /// <summary>
    /// Декоратор для телефона Samsung Galaxy
    /// </summary>
    public class PhoneSamsungGalaxy : DecoratorPhone
    {
        public PhoneSamsungGalaxy(BasePhone phone) : base(phone)
        {
        }

        public override string PhoneName { get { return "Samsung Galaxy A51"; } }
        public override String ScreenResolution { get { return "2400x1080"; } }
        public override Int32 ScreenDiagonal { get { return 0; } } 
        public override string DisplayType { get { return "Super AMOLED"; } }
        public override string OperatingSystem { get { return "Android 10"; } }
        public override Int32 CPU { get { return 8; } } 
        public override Int32 Memory { get { return 128; } }
        public override Int32 RAM { get { return 6; } }
        public override Int32 Camera { get { return 48; } }
        public override Int32 Battery { get { return 4000; } }

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
