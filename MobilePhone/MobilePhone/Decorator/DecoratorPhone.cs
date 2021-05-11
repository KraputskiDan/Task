using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Decorator
{
    /// <summary>
    /// Базовый класс декоратора
    /// </summary>
    public abstract class DecoratorPhone : BasePhone
    {
        protected BasePhone _phone;

        public DecoratorPhone(BasePhone phone)
        {
            this._phone = phone;
        }

        public override string PhoneName { get; set; }
        public override String ScreenResolution { get; set; }
        public override Int32 ScreenDiagonal { get; set; }
        public override string DisplayType { get; set; }
        public override string OperatingSystem { get; set; }
        public override Int32 CPU { get; set; }
        public override Int32 Memory { get; set; }
        public override Int32 RAM { get; set; }
        public override Int32 Camera { get; set; }
        public override Int32 Battery { get; set; }

        public override string GetInformation()
        {
            if(this._phone != null)
            {
                return this._phone.GetInformation();
            }
            else
            {
                return String.Empty;
            }
        }
    }


}

