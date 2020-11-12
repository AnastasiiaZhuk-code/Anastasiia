using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace PassiveElementForm
{
    /// <summary>
    /// 
    /// </summary>
    public static class ReadingAndParsing
    {
        /// <summary>
        /// Считывает и переводит в тип double 
        /// входное значение параметра
        /// </summary>
        /// <param name="textValue">Входное значение 
        /// параметра</param>
        /// <param name="nameOfParameter">Имя параметра
        /// пассивного элемента</param>
        /// <param name="doubleValue">Выходное значение параметра</param>
        /// <returns>Обработанную строку</returns>
        public static double ReadAndParse(string textValue, string nameOfParameter,
            out double doubleValue)
        {
            var isParseOK = double.TryParse(textValue.Replace(',', '.'),
                NumberStyles.Float, CultureInfo.InvariantCulture, out _);

            if (isParseOK)
            {
                return doubleValue = double.Parse(textValue.Replace(',', '.'),
                    CultureInfo.InvariantCulture);
            }
            else
            {
                throw new FormatException($"Введено не" +
                    $" число в поле {nameOfParameter}.\n");
            }
        }

    }
}
