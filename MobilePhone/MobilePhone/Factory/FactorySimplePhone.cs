using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Factory
{
    /// <summary>
    /// Конкретный создатель телефона обычного телефона
    /// </summary>
    public class FactorySimplePhone : FactoryPhone
    {
        public FactorySimplePhone(String nameFactory) : base(nameFactory) { }

        public override BasePhone GetPhone()
        {
            SimplePhone phone = new SimplePhone();
            return phone;
        }
    }
}
