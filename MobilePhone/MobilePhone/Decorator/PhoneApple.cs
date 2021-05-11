using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Decorator
{
    /// <summary>
    /// Декоратор для телефона Apple
    /// </summary>
    public class PhoneApple : DecoratorPhone
    {
        public PhoneApple(BasePhone phone) : base(phone)
        {
        }

        public override string PhoneName { get { return "Apple iPhone 11"; } }
        public override String ScreenResolution { get { return "1792x828"; } }
        public override Int32 ScreenDiagonal { get { return 6; } } 
        public override string DisplayType { get { return "Liquid Retina HD"; } }
        public override string OperatingSystem { get { return "iOS 14"; } }
        public override Int32 CPU { get { return 6; } } 
        public override Int32 Memory { get { return 64; } }
        public override Int32 RAM { get { return 4; } }
        public override Int32 Camera { get { return 12; } }
        public override Int32 Battery { get { return 3110; } }

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
