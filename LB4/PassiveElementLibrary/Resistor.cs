using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PassiveElementLibrary
{
    /// <summary>
    /// Резистор
    /// </summary>
    [Serializable]
    public class Resistor : PassiveElementBase
    {

        /// <summary>
        /// Активное сопротивление
        /// </summary>
        public double _resistance;

        /// <summary>
        /// Активное сопротивление
        /// </summary>
        public double Resistance
        {
            get
            {
                return _resistance;
            }

            set
            {
                _resistance = ElementChecker.ValueChecker(value, 
                    "АКТИВНОЕ СОПРОТИВЛЕНИЕ");
            }
        }

        /// <summary>
        /// Комплексное сопротивление
        /// </summary>
        protected override Complex ComplexResistance
        {
            get
            {
                return new Complex(Resistance, 0);
            }
        }

        /// <summary>
        /// Тип пассивного элемента
        /// </summary>
        public override string PassiveElementType => "Резистор";
    }
}
