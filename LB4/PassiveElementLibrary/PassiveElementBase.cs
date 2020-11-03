using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PassiveElementLibrary
{
    /// <summary>
    /// Пассивный элемент
    /// </summary>
    [Serializable]
    public abstract class PassiveElementBase
    {

        /// <summary>
        /// Комплексное сопротивление 
        /// </summary>
        protected abstract Complex ComplexResistance
        {
            get;
        }

        /// <summary>
        /// Тип пассивного элемента
        /// </summary>
        public abstract string PassiveElementType 
        { 
            get; 
        }

        /// <summary>
        /// Выводит ифномарцию о комплексном сопротивлении
        /// </summary>
        /// <param name="element">Пассивный элемент</param>
        public string GetInfo
        {
            get
            {
                return $"{ComplexResistance.Real} + " +
                $"i * ({ComplexResistance.Imaginary})";
            }
        }
    }
}
