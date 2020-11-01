using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PassiveElementLibrary
{
    /// <summary>
    /// Конденсатор
    /// </summary>
    public class Capacitor : PassiveElementBase
    {

        /// <summary>
        /// Частота
        /// </summary>
        public double _frecuency;

        /// <summary>
        /// Емкость
        /// </summary>
        public double _capacity;

        /// <summary>
        /// Частота
        /// </summary>
        public double Frecuency
        {
            get
            {
                return _frecuency;
            }

            set
            {
                _frecuency = ElementChecker.ValueChecker(value);
            }
        }

        /// <summary>
        /// Емкость
        /// </summary>
        public double Сapacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = ElementChecker.DiapasonChecker(
                    ElementChecker.ValueChecker(value), 1e5, "Емкость");
            }
        }

        /// <summary>
        /// Комплексное сопротивление
        /// </summary>
        protected override Complex ComplexResistance
        {
            get
            {
                return new Complex(0, (-1 / (Frecuency * Сapacity)));
            }
        }

        /// <summary>
        /// Тип пассивного элемента
        /// </summary>
        public override string PassiveElementType => "Конденсатор";
    }
}
