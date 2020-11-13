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

        private Dictionary<string, string> _parametersOfPassiveElement;

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        private string _messageException = "";

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
        private void rangeOfTypesPassiveElementsComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            _passiveElement = new Capacitor();
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
                    _messageException += exception.Message + "\n";
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Вводит данные о новом индуктивном элементе
        /// </summary>
        /// <returns></returns>
        private Inductor GetNewInductor()
        {
            var newInductor = new Inductor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    ReadingAndParsing.ReadAndParse(
                        PassiveElementParameter1_textBox.Text,
                        TranslateParameter(NamesOfPassiveElementParameters.
                        Frecuency.ToString()),
                        out double frecuency);
                    newInductor.Frecuency = frecuency;
                }),
                new Action(() =>
                {
                    ReadingAndParsing.ReadAndParse(
                        PassiveElementParameter2_textBox.Text,
                        TranslateParameter(NamesOfPassiveElementParameters.
                        Inductance.ToString()),
                        out double inductance);
                    newInductor.Inductance = inductance;
                })
            };
            actions.ForEach(SetValue);
            return newInductor;
        }

        /// <summary>
        /// Вводит данные о новом конденсаторе
        /// </summary>
        /// <returns></returns>
        private Capacitor GetNewCapacitor()
        {
            var newCapacitor = new Capacitor();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    ReadingAndParsing.ReadAndParse(
                        PassiveElementParameter1_textBox.Text,
                        TranslateParameter(NamesOfPassiveElementParameters.
                        Frecuency.ToString()),
                        out double frecuency);
                    newCapacitor.Frecuency = frecuency;
                }),
                new Action(() =>
                {
                    ReadingAndParsing.ReadAndParse(
                        PassiveElementParameter2_textBox.Text,
                        TranslateParameter(NamesOfPassiveElementParameters.
                        Capacity.ToString()),
                        out double capacity);
                    newCapacitor.Сapacity = capacity;
                })
            };
            actions.ForEach(SetValue);
            return newCapacitor;
        }

        /// <summary>
        /// Вводит данные о новом резисторе
        /// </summary>
        /// <returns></returns>
        private Resistor GetNewResistor()
        {
            var newResistor = new Resistor();
            var actions = new List<Action>()

            {
                new Action(() =>
                {
                    ReadingAndParsing.ReadAndParse(
                        PassiveElementParameter1_textBox.Text,
                        TranslateParameter(NamesOfPassiveElementParameters.
                        Resistance.ToString()),
                        out double resistance);
                    newResistor.Resistance = resistance;
                })
            };
            actions.ForEach(SetValue);
            return newResistor;
        }

        /// <summary>
        /// Ввод данных о пассивном элементе
        /// </summary>
        private void InputData()
        {
            _isCorrect = true;
            _messageException = "";

            switch (_passiveElement)
            {
                case Inductor _:
                {
                    _passiveElement = GetNewInductor();
                    break;
                }
                case Capacitor _:
                {
                    _passiveElement = GetNewCapacitor();
                    break;
                }
                case Resistor _:
                {
                    _passiveElement = GetNewResistor();
                    break;
                }
                default:
                {
                    throw new ArgumentException("Выберите вид" +
                        " пассивного элемента!");
                }
            }
        }

        /// <summary>
        /// Добавление нового пассивного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPassiveElementButton_Click(object sender, EventArgs e)
        {
            try
            {
                InputData();

                if (_isCorrect)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch(Exception exception)
            {
                _messageException += exception.Message + "\n";
            }
            finally 
            {
                if(_messageException != "")
                {
                    MessageBox.Show(_messageException);
                }
            }
        }

        
        
        /// <summary>
        /// Переводит имя параметра с английского на русский
        /// </summary>
        /// <param name="inputString">Входная строка/
        /// Имя параметра на английском</param>
        /// <returns>Выходная строка/Имя параметра на русском</returns>
        private string TranslateParameter(string inputString)
        {
             Dictionary<string, string> parametersOfPassiveElement
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

            string outputString = "";

            if(parametersOfPassiveElement.TryGetValue(
                inputString, out outputString))
            {
                return outputString;
            }

            return outputString;
        }
    }
}
