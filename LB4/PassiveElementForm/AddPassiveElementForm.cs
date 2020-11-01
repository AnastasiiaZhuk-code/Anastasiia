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
        /// Отображение полей элементов при выборе
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
                PassiveElementParameter1.Text = "Частота: ";
                PassiveElementParameter1_textBox.Visible = true;
                PassiveElementParameter2.Text = "Емкость: ";
                PassiveElementParameter2_textBox.Visible = true;

                //_passiveElement = new Capacitor();
            }
            if (typeOfPassiveElement == "Индуктивность")
            {
                PassiveElementParameter1.Text = "Частота: ";
                PassiveElementParameter1_textBox.Visible = true;
                PassiveElementParameter2.Text = "Индуктивность: ";
                PassiveElementParameter2_textBox.Visible = true;
            }
            if (typeOfPassiveElement == "Резистор")
            {
                PassiveElementParameter1.Text = "Активное сопротивление: ";
                PassiveElementParameter1_textBox.Visible = true;
                PassiveElementParameter2.Text = " ";
                PassiveElementParameter2_textBox.Visible = false;
            }
        }


    }
}
