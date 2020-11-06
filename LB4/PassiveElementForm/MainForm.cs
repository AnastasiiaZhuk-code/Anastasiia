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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PassiveElementForm
{
    /// <summary>
    /// Главное окно программы
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Лист пассивных элементов
        /// </summary>
        private BindingList<PassiveElementBase> 
            _passiveElements = new BindingList<PassiveElementBase>();

        /// <summary>
        /// Список с найденными пассивными элементами
        /// </summary>
        private BindingList<PassiveElementBase> 
            _passiveElementsSearch =
            new BindingList<PassiveElementBase>();

        /// <summary>
        /// Событие при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateView(
                _passiveElements, dataPassiveElementView);
        }

        /// <summary>
        /// Добавление пассивного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPassiveElementButton_Click(object sender, EventArgs e)
        {
            var passiveElement = new AddPassiveElementForm();

            if (passiveElement.ShowDialog() == DialogResult.OK)
            {
                _passiveElements.Add(passiveElement.PassiveElementAdd);
            }
        }

        /// <summary>
        /// Удаление пассивного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePassiveElementButton_Click(object sender, EventArgs e)
        {
            var countOfRows = dataPassiveElementView.SelectedRows.Count;
            for (int i = 0; i < countOfRows; i++)
            {
                _passiveElements.RemoveAt(
                    dataPassiveElementView.SelectedRows[0].Index);
            }
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePassiveElementButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "avz files (*.avz)|*.avz";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var binaryFormatter = new BinaryFormatter();
                    var filePath = saveFileDialog.FileName;

                    using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                    {
                        binaryFormatter.Serialize(fileStream, _passiveElements);
                    }

                }
            }
        }

        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadPassiveElementButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "avz files (*.avz)|*.avz";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var formatter = new BinaryFormatter();
                    var filePath = openFileDialog.FileName;

                    try
                    {
                        using (var fileStream = new FileStream(filePath,
                        FileMode.OpenOrCreate))
                        {
                            var newPassiveElements = (BindingList<PassiveElementBase>)formatter.
                                Deserialize(fileStream);

                            foreach (var passiveElement in newPassiveElements)
                            {
                                _passiveElements.Add(passiveElement);                                
                            }
                        }
                        MessageBox.Show("Файл загружен успешно.");
                    }

                    catch (Exception exception)
                    {
                        MessageBox.Show("Невозможно загрузить, проблемы" +
                            " с файлом. Попробуйте снова!");
                    }
                }
            }
        }

        /// <summary>
        /// Генерация случайного пассивного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetRandomPassiveElementButton_Click(object sender, EventArgs e)
        {
            _passiveElements.Add(RandomPassiveElement.GetRandomPassiveElement());
        }

        /// <summary>
        /// Создает таблицу элементов
        /// </summary>
        /// <param name="passiveElements">Пассивные элементы</param>
        /// <param name="dataGridView">Таблица с элементами</param>
        private void CreateView(BindingList<PassiveElementBase> passiveElements,
            DataGridView dataGridView)
        {
            dataGridView.DataSource = passiveElements;

            dataGridView.Columns[0].HeaderText = "Вид пассивного элемента";
            dataGridView.Columns[1].HeaderText = "Комплексное сопротивление элемента";

            dataGridView.AutoSizeColumnsMode =
               DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// Поиск пассивного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchPassiveElementButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// Ищет необходимый пассивный элемент в листе
        /// </summary>
        private void Search()
        {
            _passiveElementsSearch.Clear();

            CreateView(
                _passiveElementsSearch, dataPassiveElementView);

            try
            {
                if (comboBox1.CanFocus)
                {
                    foreach (var row in _passiveElements)
                    {
                        if (row.PassiveElementType ==
                                comboBox1.SelectedItem.ToString())
                        {
                            _passiveElementsSearch.Add(row);
                        }
                    }
                }
                if (!string.IsNullOrEmpty(searchTextBox.Text))
                {
                    foreach (var row in _passiveElements)
                    {
                        if (row.GetInfo == searchTextBox.Text)
                        {
                            _passiveElementsSearch.Add(row);
                        }
                    }
                }
                if (!_passiveElementsSearch.Any())
                {
                    MessageBox.Show("Ничего не найдено!");
                }
            }
            catch (Exception exception)
            {

            }
        }

        /// <summary>
        /// Сброс поиска и отображение исходного листа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CreateView(
                _passiveElements, dataPassiveElementView);
        }
    }
}
