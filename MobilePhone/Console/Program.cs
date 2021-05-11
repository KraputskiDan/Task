using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhoneLib;
using MobilePhoneLib.Factory;

namespace ConsolePhone
{
    class Program
    {
        /// <summary>
        /// Констольное меню
        /// </summary>
        static void Main(string[] args)
        {
            FactoryPhone dev = null;

            BasePhone phone = null;

            int number = 0;

            Boolean logic = true;

            while (logic)
            {
                Console.WriteLine("1. Создать телефон Apple\n" +
                    "2. Создать телефон Nokia\n" +
                    "3. Создать телефон Samsung\n" +
                    "4. Создать телефон Xiaomi\n" +
                    "5. Создать телефон ZTE\n" +
                    "6. Выход");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }               
                switch (number)
                {
                    case 1:                       
                        dev = new FactoryApple("Apple");
                        phone = dev.GetPhone();
                        Console.WriteLine($"Название производителя {dev.NameFactory}\n" + phone.GetInformation());
                        
                        break;
                    case 2:
                        dev = new FactoryNokia("Nokia");
                        phone = dev.GetPhone();
                        Console.WriteLine($"Название производителя {dev.NameFactory}\n" + phone.GetInformation());

                        break;
                    case 3:
                        dev = new FactorySamsung("Samsung");
                        phone = dev.GetPhone();
                        Console.WriteLine($"Название производителя {dev.NameFactory}\n" + phone.GetInformation());

                        break;
                    case 4:
                        dev = new FactoryXiaomi("Xiaomi");
                        phone = dev.GetPhone();
                        Console.WriteLine($"Название производителя {dev.NameFactory}\n" + phone.GetInformation());

                        break;
                    case 5:
                        dev = new FactoryZTE("ZTE");
                        phone = dev.GetPhone();
                        Console.WriteLine($"Название производителя {dev.NameFactory}\n" + phone.GetInformation());

                        break;
                    case 6:
                        logic = false;
                        break;
                    
                }
            }
        }
    }
}
