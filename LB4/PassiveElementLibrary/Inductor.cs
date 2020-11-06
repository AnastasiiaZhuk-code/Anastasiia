using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PassiveElementLibrary
{
    /// <summary>
    /// Индуктивный элемент
    /// </summary>
    [Serializable]
    public class Inductor : PassiveElementBase
    {

        /// <summary>
        /// Частота
        /// </summary>
        public double _frecuency;

        /// <summary>
        /// Индуктивность
        /// </summary>
        public double _inductance;

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
                _frecuency = ElementChecker.ValueChecker(value,
                    "ЧАСТОТА");
            }
        }

        /// <summary>
        /// Индукивность
        /// </summary>
        public double Inductance
        {
            get
            {
                return _inductance;
            }

            set
            {
                _inductance = ElementChecker.DiapasonChecker(
                    ElementChecker.ValueChecker(value, "ИНДУКТИВНОСТЬ"),
                    1e6, "Индуктивность");
            }
        }

        /// <summary>
        /// Комплексное сопротивление
        /// </summary>
        protected override Complex ComplexResistance
        {
            get
            {
                return new Complex(0, (Frecuency * Inductance));
            }
        }

        /// <summary>
        /// Тип пассивного элемента
        /// </summary>
        public override string PassiveElementType => "Индуктивность";
    }
}
