using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneLib.Decorator;

namespace MobilePhoneLib.Factory
{
    /// <summary>
    /// Конкретный создатель телефона Samsung
    /// </summary>
    public class FactorySamsung : FactoryPhone
    {
        public FactorySamsung(String nameFactory) : base(nameFactory) { }

        public override BasePhone GetPhone()
        {
            SimplePhone phone = new SimplePhone();
            return new PhoneSamsungGalaxy(phone);
        }
    }
}
