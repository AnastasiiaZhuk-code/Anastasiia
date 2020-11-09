using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveElementLibrary
{
    /// <summary>
    /// Класс, реализуюший проверку введенных параметров пассивных
    /// элементов
    /// </summary>
    public static class ElementChecker
    {
        /// <summary>
        /// Проверяет корректность значения параметра
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ValueChecker(double value, string nameOfElement)
        {
            if (double.IsNaN(value))
            {
                throw new ArgumentException($" {nameOfElement} " +
                    " имеет неверный формат." +
                    "Попробуйте снова!");
            }
            return value;
        }

        /// <summary>
        /// Проверяет входное значение на диапазон
        /// </summary>
        /// <param name="parameterOfElement"></param>
        /// <param name="maxValue"></param>
        /// <param name="nameOfElement"></param>
        /// <returns></returns>
        public static double DiapasonChecker(double parameterOfElement,
            double maxValue, string nameOfElement, string unitOfParameter)
        {
            if (parameterOfElement <= 0 || parameterOfElement >= maxValue)
            {
                throw new ArgumentException($"Значение параметра " +
                    $"{nameOfElement} должно находиться " +
                    $"в пределах от 0 до {maxValue} {unitOfParameter}.\n");
            }
            return parameterOfElement;
        }
    }
}
