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
                    var passiveElement = new Capacitor();
                    passiveElement.Сapacity =
                    Convert.ToDouble(_random.Next(1, 100));
                    passiveElement.Frecuency =
                    Convert.ToDouble(_random.Next(1, 10));
                    return passiveElement;
                }
                case 1:
                {
                    var passiveElement = new Resistor();
                    passiveElement.Resistance = 
                    Convert.ToDouble(_random.Next(1, 100));
                    return passiveElement;
                }
                case 2:
                {
                    var passiveElement = new Inductor();
                    passiveElement.Inductance =
                    Convert.ToDouble(_random.Next(1, 100));
                    passiveElement.Frecuency = Convert.ToDouble(
                        _random.Next(1, 10));
                    return passiveElement;
                    }
                default:
                {
                    throw new ArgumentException("Нет такого элемента!");
                }
            }
        }
    }
}
