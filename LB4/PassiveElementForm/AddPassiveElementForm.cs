using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassiveElementLibrary;
using System.Globalization;

namespace PassiveElementForm
{
    /// <summary>
    /// Класс, описывающий добавление пассивного элемента
    /// </summary>
    public partial class AddPassiveElementForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddPassiveElementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Пассивный элемент
        /// </summary>
        private PassiveElementBase _passiveElement;

        /// <summary>
        /// Лист сообщений и исключений
        /// </summary>
        private List<string> _exceptionMessagesList;

        /// <summary>
        /// Флаг для внесения данных и закрытия формы
        /// </summary>
        private bool _isCorrect;

        /// <summary>
        /// Вывод информации о пассивном элементе
        /// </summary>
        public PassiveElementBase PassiveElementAdd
        {
            get
            {
                return _passiveElement;
            }
        }

        private void AddPassiveElementForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Закрытие окна нажатием кнопки Отмена
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Событие при выборе
        /// вида пассивного элемента в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rangeOfTypesPassiveElementsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeOfPassiveElement = 
                rangeOfTypesPassiveElementsComboBox.SelectedItem.ToString();

            if (typeOfPassiveElement == "Конденсатор")
            {
                PassiveElementParameter1.Visible = true;
                PassiveElementParameter1.Text = "Частота: ";
                PassiveElementParameter1_textBox.Visible = true;
                PassiveElementParameter2.Visible = true;
                PassiveElementParameter2.Text = "Емкость: ";
                PassiveElementParameter2_textBox.Visible = true;

                _passiveElement = new Capacitor();
            }
            if (typeOfPassiveElement == "Индуктивность")
            {
                PassiveElementParameter1.Visible = true;
                PassiveElementParameter1.Text = "Частота: ";
                PassiveElementParameter1_textBox.Visible = true;
                PassiveElementParameter2.Visible = true;
                PassiveElementParameter2.Text = "Индуктивность: ";
                PassiveElementParameter2_textBox.Visible = true;

                _passiveElement = new Inductor();
            }
            if (typeOfPassiveElement == "Резистор")
            {
                PassiveElementParameter1.Visible = true;
                PassiveElementParameter1.Text = "Активное сопротивление: ";
                PassiveElementParameter1_textBox.Visible = true;
                PassiveElementParameter2.Visible = false;
                PassiveElementParameter2_textBox.Visible = false;

                _passiveElement = new Resistor();
            }
        }

        /// <summary>
        /// Установить значение свойствам экземпляра класса 
        /// Индуктивнось/Конденсатор/Резистор
        /// </summary>
        /// <param name="action">Делегат Action</param>
        private void SetValue(Action action)
        {
            try
            {
                action.Invoke();
                return;
            }
            catch (Exception exception)
            {
                _isCorrect = false;
                if (exception is ArgumentException ||
                    exception is FormatException)
                {
                    _exceptionMessagesList.Add(exception.Message);
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Преобразование string в double, 
        /// и замена точки на запятую в строке
        /// </summary>
        /// <param name="textValue">Преобразуемая строка</param>
        /// <param name="doubleValue">Преобразованная строка к типу double</param>
        /// <param name="textBoxName">Имя TextBox</param>
        /// <returns>Строку, преобразованную к типу double</returns>
        private double TryConvertingToDouble(string textValue,
            out double doubleValue, string textBoxName)
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
                throw new FormatException("\nВведено не число!" +
                    "Попробуйте снова\n" +
                    "\nОшибка в: " + textBoxName + "\n");
            }
        }

    }
}
