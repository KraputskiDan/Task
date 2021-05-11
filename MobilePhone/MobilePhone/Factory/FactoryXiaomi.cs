using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneLib.Decorator;

namespace MobilePhoneLib.Factory
{
    /// <summary>
    /// Конкретный создатель телефона Xiaomi
    /// </summary>
    public class FactoryXiaomi : FactoryPhone
    {
        public FactoryXiaomi(String nameFactory) : base(nameFactory) { }

        public override BasePhone GetPhone()
        {
            SimplePhone phone = new SimplePhone();
            return new PhoneXiaomiRedmi(phone);
        }
    }
}
