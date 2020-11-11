namespace PassiveElementForm
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataPassiveElementView = new System.Windows.Forms.DataGridView();
            this.AddPassiveElementButton = new System.Windows.Forms.Button();
            this.DeletePassiveElementButton = new System.Windows.Forms.Button();
            this.SavePassiveElementButton = new System.Windows.Forms.Button();
            this.LoadPassiveElementButton = new System.Windows.Forms.Button();
            this.SearchPassiveElementButton = new System.Windows.Forms.Button();
            this.GetRandomPassiveElementButton = new System.Windows.Forms.Button();
            this.realPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypesOfPassiveElementsComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteSearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imaginaryPartSearchTextBox = new System.Windows.Forms.TextBox();
            this.realPartSearchComboBox = new System.Windows.Forms.ComboBox();
            this.imaginaryPartSearchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPassiveElementView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPassiveElementView
            // 
            this.dataPassiveElementView.AllowUserToAddRows = false;
            this.dataPassiveElementView.AllowUserToDeleteRows = false;
            this.dataPassiveElementView.AllowUserToResizeRows = false;
            this.dataPassiveElementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPassiveElementView.Location = new System.Drawing.Point(12, 39);
            this.dataPassiveElementView.Name = "dataPassiveElementView";
            this.dataPassiveElementView.ReadOnly = true;
            this.dataPassiveElementView.RowHeadersWidth = 51;
            this.dataPassiveElementView.RowTemplate.Height = 24;
            this.dataPassiveElementView.Size = new System.Drawing.Size(751, 281);
            this.dataPassiveElementView.TabIndex = 0;
            // 
            // AddPassiveElementButton
            // 
            this.AddPassiveElementButton.Location = new System.Drawing.Point(12, 418);
            this.AddPassiveElementButton.Name = "AddPassiveElementButton";
            this.AddPassiveElementButton.Size = new System.Drawing.Size(135, 29);
            this.AddPassiveElementButton.TabIndex = 1;
            this.AddPassiveElementButton.Text = "Добавить";
            this.AddPassiveElementButton.UseVisualStyleBackColor = true;
            this.AddPassiveElementButton.Click += new System.EventHandler(this.AddPassiveElementButton_Click);
            // 
            // DeletePassiveElementButton
            // 
            this.DeletePassiveElementButton.Location = new System.Drawing.Point(153, 418);
            this.DeletePassiveElementButton.Name = "DeletePassiveElementButton";
            this.DeletePassiveElementButton.Size = new System.Drawing.Size(134, 29);
            this.DeletePassiveElementButton.TabIndex = 2;
            this.DeletePassiveElementButton.Text = "Удалить";
            this.DeletePassiveElementButton.UseVisualStyleBackColor = true;
            this.DeletePassiveElementButton.Click += new System.EventHandler(this.DeletePassiveElementButton_Click);
            // 
            // SavePassiveElementButton
            // 
            this.SavePassiveElementButton.Location = new System.Drawing.Point(293, 418);
            this.SavePassiveElementButton.Name = "SavePassiveElementButton";
            this.SavePassiveElementButton.Size = new System.Drawing.Size(144, 29);
            this.SavePassiveElementButton.TabIndex = 3;
            this.SavePassiveElementButton.Text = "Сохранить";
            this.SavePassiveElementButton.UseVisualStyleBackColor = true;
            this.SavePassiveElementButton.Click += new System.EventHandler(this.SavePassiveElementButton_Click);
            // 
            // LoadPassiveElementButton
            // 
            this.LoadPassiveElementButton.Location = new System.Drawing.Point(443, 418);
            this.LoadPassiveElementButton.Name = "LoadPassiveElementButton";
            this.LoadPassiveElementButton.Size = new System.Drawing.Size(144, 29);
            this.LoadPassiveElementButton.TabIndex = 4;
            this.LoadPassiveElementButton.Text = "Загрузить";
            this.LoadPassiveElementButton.UseVisualStyleBackColor = true;
            this.LoadPassiveElementButton.Click += new System.EventHandler(this.LoadPassiveElementButton_Click);
            // 
            // SearchPassiveElementButton
            // 
            this.SearchPassiveElementButton.Location = new System.Drawing.Point(677, 339);
            this.SearchPassiveElementButton.Name = "SearchPassiveElementButton";
            this.SearchPassiveElementButton.Size = new System.Drawing.Size(86, 29);
            this.SearchPassiveElementButton.TabIndex = 5;
            this.SearchPassiveElementButton.Text = "Поиск";
            this.SearchPassiveElementButton.UseVisualStyleBackColor = true;
            this.SearchPassiveElementButton.Click += new System.EventHandler(this.SearchPassiveElementButton_Click);
            // 
            // GetRandomPassiveElementButton
            // 
            this.GetRandomPassiveElementButton.Location = new System.Drawing.Point(593, 418);
            this.GetRandomPassiveElementButton.Name = "GetRandomPassiveElementButton";
            this.GetRandomPassiveElementButton.Size = new System.Drawing.Size(170, 29);
            this.GetRandomPassiveElementButton.TabIndex = 6;
            this.GetRandomPassiveElementButton.Text = "Рандомный элемент";
            this.GetRandomPassiveElementButton.UseVisualStyleBackColor = true;
            this.GetRandomPassiveElementButton.Click += new System.EventHandler(this.GetRandomPassiveElementButton_Click);
            // 
            // realPartSearchTextBox
            // 
            this.realPartSearchTextBox.Location = new System.Drawing.Point(574, 339);
            this.realPartSearchTextBox.Name = "realPartSearchTextBox";
            this.realPartSearchTextBox.Size = new System.Drawing.Size(89, 22);
            this.realPartSearchTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Действительная часть:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вид элемента";
            // 
            // TypesOfPassiveElementsComboBox
            // 
            this.TypesOfPassiveElementsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypesOfPassiveElementsComboBox.FormattingEnabled = true;
            this.TypesOfPassiveElementsComboBox.Items.AddRange(new object[] {
            "Индуктивность",
            "Конденсатор",
            "Резистор"});
            this.TypesOfPassiveElementsComboBox.Location = new System.Drawing.Point(126, 356);
            this.TypesOfPassiveElementsComboBox.Name = "TypesOfPassiveElementsComboBox";
            this.TypesOfPassiveElementsComboBox.Size = new System.Drawing.Size(121, 24);
            this.TypesOfPassiveElementsComboBox.TabIndex = 11;
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Location = new System.Drawing.Point(677, 374);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(86, 29);
            this.DeleteSearchButton.TabIndex = 12;
            this.DeleteSearchButton.Text = "Сбросить";
            this.DeleteSearchButton.UseVisualStyleBackColor = true;
            this.DeleteSearchButton.Visible = false;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Мнимая часть:";
            // 
            // imaginaryPartSearchTextBox
            // 
            this.imaginaryPartSearchTextBox.Location = new System.Drawing.Point(573, 377);
            this.imaginaryPartSearchTextBox.Name = "imaginaryPartSearchTextBox";
            this.imaginaryPartSearchTextBox.Size = new System.Drawing.Size(89, 22);
            this.imaginaryPartSearchTextBox.TabIndex = 14;
            // 
            // realPartSearchComboBox
            // 
            this.realPartSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.realPartSearchComboBox.FormattingEnabled = true;
            this.realPartSearchComboBox.Items.AddRange(new object[] {
            "Больше или равно",
            "Меньше или равно"});
            this.realPartSearchComboBox.Location = new System.Drawing.Point(444, 339);
            this.realPartSearchComboBox.Name = "realPartSearchComboBox";
            this.realPartSearchComboBox.Size = new System.Drawing.Size(120, 24);
            this.realPartSearchComboBox.TabIndex = 15;
            // 
            // imaginaryPartSearchComboBox
            // 
            this.imaginaryPartSearchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imaginaryPartSearchComboBox.FormattingEnabled = true;
            this.imaginaryPartSearchComboBox.Items.AddRange(new object[] {
            "Больше или равно",
            "Меньше или равно"});
            this.imaginaryPartSearchComboBox.Location = new System.Drawing.Point(443, 377);
            this.imaginaryPartSearchComboBox.Name = "imaginaryPartSearchComboBox";
            this.imaginaryPartSearchComboBox.Size = new System.Drawing.Size(119, 24);
            this.imaginaryPartSearchComboBox.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 460);
            this.Controls.Add(this.imaginaryPartSearchComboBox);
            this.Controls.Add(this.realPartSearchComboBox);
            this.Controls.Add(this.imaginaryPartSearchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteSearchButton);
            this.Controls.Add(this.TypesOfPassiveElementsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.realPartSearchTextBox);
            this.Controls.Add(this.GetRandomPassiveElementButton);
            this.Controls.Add(this.SearchPassiveElementButton);
            this.Controls.Add(this.LoadPassiveElementButton);
            this.Controls.Add(this.SavePassiveElementButton);
            this.Controls.Add(this.DeletePassiveElementButton);
            this.Controls.Add(this.AddPassiveElementButton);
            this.Controls.Add(this.dataPassiveElementView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пассивные элементы электрической цепи";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPassiveElementView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPassiveElementView;
        private System.Windows.Forms.Button AddPassiveElementButton;
        private System.Windows.Forms.Button DeletePassiveElementButton;
        private System.Windows.Forms.Button SavePassiveElementButton;
        private System.Windows.Forms.Button LoadPassiveElementButton;
        private System.Windows.Forms.Button SearchPassiveElementButton;
        private System.Windows.Forms.Button GetRandomPassiveElementButton;
        private System.Windows.Forms.TextBox realPartSearchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypesOfPassiveElementsComboBox;
        private System.Windows.Forms.Button DeleteSearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imaginaryPartSearchTextBox;
        private System.Windows.Forms.ComboBox realPartSearchComboBox;
        private System.Windows.Forms.ComboBox imaginaryPartSearchComboBox;
    }
}

