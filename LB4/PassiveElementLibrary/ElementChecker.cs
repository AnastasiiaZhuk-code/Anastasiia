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
        public static double ValueChecker(double value)
        {
            if (value <= 0 || double.IsNaN(value))
            {
                throw new ArgumentOutOfRangeException("Невозможно" +
                    " передать значение параметра по одной из" +
                    " причин: отрицательное или нулевое значение," +
                    " нечисловой формат. Попробуйте снова!");
            }
            return value;
        }

        public static double DiapasonChecker(double parameterOfElement,
            double maxValue, string nameOfElement)
        {
            if (parameterOfElement <= 0 || parameterOfElement >= maxValue)
            {
                throw new ArgumentException($"{nameOfElement} " +
                        " должна находиться " +
                        $"в пределах от 0 до {maxValue}.");
            }
            return parameterOfElement;
        }
    }
}
