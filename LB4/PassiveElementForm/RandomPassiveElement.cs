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
        /// Создание случайной пассивного элемента 
        /// </summary>
        /// <returns>Ексемпляр пассивного элемента</returns>
        public static PassiveElementBase GetRandomPassiveElement()
        {
            PassiveElementBase passiveElement = new Capacitor();

            int typePassiveElement = _random.Next(0, 3);

            if (typePassiveElement == 0)
            {
                passiveElement = new Capacitor();

                (passiveElement as Capacitor).Сapacity =
                    Convert.ToDouble(_random.Next(1, 100));

                (passiveElement as Capacitor).Frecuency =
                    Convert.ToDouble(_random.Next(1, 10));
            }

            if (typePassiveElement == 1)
            {
                passiveElement = new Resistor();

                (passiveElement as Resistor).Resistance = 
                    Convert.ToDouble(_random.Next(1, 100));
            }

            if (typePassiveElement == 2)
            {
                passiveElement = new Inductor();

                (passiveElement as Inductor).Inductance =
                    Convert.ToDouble(_random.Next(1, 100));

                (passiveElement as Inductor).Frecuency =
                    Convert.ToDouble(_random.Next(1, 10));
            }

            return passiveElement;
        }
    }
}
