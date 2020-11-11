using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveElementForm
{
    /// <summary>
    /// Словарь названий пассивных элементов
    /// </summary>
    public static class DictionaryOfNamesOfPassiveElementParameters
    {
        /// <summary>
        /// Словарь (русско-английский) названий пассивных элментов
        /// </summary>
        public static Dictionary<string, string> parametersOfPassiveElement
            = new Dictionary<string, string>
        {
            {NamesOfPassiveElementParameters.Resistance.ToString(),
                    "Активное сопротивление"},
            {NamesOfPassiveElementParameters.Capacity.ToString(),
                    " Емкость"},
            {NamesOfPassiveElementParameters.Inductance.ToString(),
                    "Индуктивность"},
            {NamesOfPassiveElementParameters.Frecuency.ToString(),
                    "Частота"},
        };
    }
}
