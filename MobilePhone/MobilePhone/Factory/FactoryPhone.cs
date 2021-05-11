using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneLib.Factory
{
    /// <summary>
    /// Класс Создатель объявляет фабричный метод, который должен возвращать объект типа Продукт.
    /// </summary>
    public abstract class FactoryPhone
    {
        /// <summary>
        /// Название фирмы производителя
        /// </summary>
        public String NameFactory { get; set; }

        public FactoryPhone(String nameFactory)
        {
            NameFactory = nameFactory;
        }

        /// <summary>
        /// Фабричный метод создания объекта типа Продукт;
        /// </summary>
        /// <returns></returns>
        public abstract BasePhone GetPhone();
    }
}
