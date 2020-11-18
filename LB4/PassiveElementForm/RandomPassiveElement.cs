using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassiveElementLibrary;

namespace PassiveElementForm
{
    /// <summary>
    /// Рандомный пассивный элемент
    /// </summary>
    public static class RandomPassiveElement
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создание случайного пассивного элемента 
        /// </summary>
        /// <returns>Ексемпляр пассивного элемента</returns>
        public static PassiveElementBase GetRandomPassiveElement()
        {
            var typePassiveElement = _random.Next(0, 3);

            switch(typePassiveElement)
            {
                case 0:
                {
                    return new Capacitor
                    {
                        Сapacity = Convert.ToDouble(_random.Next(1, 100)),
                        Frecuency = Convert.ToDouble(_random.Next(1, 10))
                    };
                }
                case 1:
                {
                    return new Resistor
                    {
                        Resistance = Convert.ToDouble(_random.Next(1, 100))
                    };
                }
                case 2:
                {
                    return new Inductor
                    {
                        Inductance = Convert.ToDouble(_random.Next(1, 100)),
                        Frecuency = Convert.ToDouble(_random.Next(1, 10))
                    };
                }
                default:
                {
                    throw new ArgumentException("Нет такого элемента!");
                }
            }
        }
    }
}
