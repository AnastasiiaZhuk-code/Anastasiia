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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nameOfResistance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TypesOfPassiveElementsComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteSearchButton = new System.Windows.Forms.Button();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPassiveElementView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPassiveElementView
            // 
            this.dataPassiveElementView.AllowUserToAddRows = false;
            this.dataPassiveElementView.AllowUserToDeleteRows = false;
            this.dataPassiveElementView.AllowUserToResizeRows = false;
            this.dataPassiveElementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPassiveElementView.Location = new System.Drawing.Point(9, 32);
            this.dataPassiveElementView.Margin = new System.Windows.Forms.Padding(2);
            this.dataPassiveElementView.Name = "dataPassiveElementView";
            this.dataPassiveElementView.ReadOnly = true;
            this.dataPassiveElementView.RowHeadersWidth = 51;
            this.dataPassiveElementView.RowTemplate.Height = 24;
            this.dataPassiveElementView.Size = new System.Drawing.Size(563, 228);
            this.dataPassiveElementView.TabIndex = 0;
            // 
            // AddPassiveElementButton
            // 
            this.AddPassiveElementButton.Location = new System.Drawing.Point(6, 302);
            this.AddPassiveElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddPassiveElementButton.Name = "AddPassiveElementButton";
            this.AddPassiveElementButton.Size = new System.Drawing.Size(101, 24);
            this.AddPassiveElementButton.TabIndex = 1;
            this.AddPassiveElementButton.Text = "Добавить";
            this.AddPassiveElementButton.UseVisualStyleBackColor = true;
            this.AddPassiveElementButton.Click += new System.EventHandler(this.AddPassiveElementButton_Click);
            // 
            // DeletePassiveElementButton
            // 
            this.DeletePassiveElementButton.Location = new System.Drawing.Point(112, 302);
            this.DeletePassiveElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeletePassiveElementButton.Name = "DeletePassiveElementButton";
            this.DeletePassiveElementButton.Size = new System.Drawing.Size(100, 24);
            this.DeletePassiveElementButton.TabIndex = 2;
            this.DeletePassiveElementButton.Text = "Удалить";
            this.DeletePassiveElementButton.UseVisualStyleBackColor = true;
            this.DeletePassiveElementButton.Click += new System.EventHandler(this.DeletePassiveElementButton_Click);
            // 
            // SavePassiveElementButton
            // 
            this.SavePassiveElementButton.Location = new System.Drawing.Point(217, 302);
            this.SavePassiveElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.SavePassiveElementButton.Name = "SavePassiveElementButton";
            this.SavePassiveElementButton.Size = new System.Drawing.Size(108, 24);
            this.SavePassiveElementButton.TabIndex = 3;
            this.SavePassiveElementButton.Text = "Сохранить";
            this.SavePassiveElementButton.UseVisualStyleBackColor = true;
            this.SavePassiveElementButton.Click += new System.EventHandler(this.SavePassiveElementButton_Click);
            // 
            // LoadPassiveElementButton
            // 
            this.LoadPassiveElementButton.Location = new System.Drawing.Point(329, 302);
            this.LoadPassiveElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoadPassiveElementButton.Name = "LoadPassiveElementButton";
            this.LoadPassiveElementButton.Size = new System.Drawing.Size(108, 24);
            this.LoadPassiveElementButton.TabIndex = 4;
            this.LoadPassiveElementButton.Text = "Загрузить";
            this.LoadPassiveElementButton.UseVisualStyleBackColor = true;
            this.LoadPassiveElementButton.Click += new System.EventHandler(this.LoadPassiveElementButton_Click);
            // 
            // SearchPassiveElementButton
            // 
            this.SearchPassiveElementButton.Location = new System.Drawing.Point(460, 271);
            this.SearchPassiveElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPassiveElementButton.Name = "SearchPassiveElementButton";
            this.SearchPassiveElementButton.Size = new System.Drawing.Size(56, 24);
            this.SearchPassiveElementButton.TabIndex = 5;
            this.SearchPassiveElementButton.Text = "Поиск";
            this.SearchPassiveElementButton.UseVisualStyleBackColor = true;
            this.SearchPassiveElementButton.Click += new System.EventHandler(this.SearchPassiveElementButton_Click);
            // 
            // GetRandomPassiveElementButton
            // 
            this.GetRandomPassiveElementButton.Location = new System.Drawing.Point(442, 302);
            this.GetRandomPassiveElementButton.Margin = new System.Windows.Forms.Padding(2);
            this.GetRandomPassiveElementButton.Name = "GetRandomPassiveElementButton";
            this.GetRandomPassiveElementButton.Size = new System.Drawing.Size(128, 24);
            this.GetRandomPassiveElementButton.TabIndex = 6;
            this.GetRandomPassiveElementButton.Text = "Рандомный элемент";
            this.GetRandomPassiveElementButton.UseVisualStyleBackColor = true;
            this.GetRandomPassiveElementButton.Click += new System.EventHandler(this.GetRandomPassiveElementButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(406, 274);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(50, 20);
            this.searchTextBox.TabIndex = 8;
            this.searchTextBox.Visible = false;
            // 
            // nameOfResistance
            // 
            this.nameOfResistance.AutoSize = true;
            this.nameOfResistance.Location = new System.Drawing.Point(181, 275);
            this.nameOfResistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameOfResistance.Name = "nameOfResistance";
            this.nameOfResistance.Size = new System.Drawing.Size(92, 26);
            this.nameOfResistance.TabIndex = 10;
            this.nameOfResistance.Text = "Действительная\r\nчасть:";
            this.nameOfResistance.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
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
            this.TypesOfPassiveElementsComboBox.Location = new System.Drawing.Point(85, 272);
            this.TypesOfPassiveElementsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TypesOfPassiveElementsComboBox.Name = "TypesOfPassiveElementsComboBox";
            this.TypesOfPassiveElementsComboBox.Size = new System.Drawing.Size(92, 21);
            this.TypesOfPassiveElementsComboBox.TabIndex = 11;
            this.TypesOfPassiveElementsComboBox.SelectedIndexChanged += new System.EventHandler(this.TypesOfPassiveElementsComboBox_SelectedIndexChanged);
            // 
            // DeleteSearchButton
            // 
            this.DeleteSearchButton.Location = new System.Drawing.Point(520, 271);
            this.DeleteSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteSearchButton.Name = "DeleteSearchButton";
            this.DeleteSearchButton.Size = new System.Drawing.Size(52, 24);
            this.DeleteSearchButton.TabIndex = 12;
            this.DeleteSearchButton.Text = "Сброс";
            this.DeleteSearchButton.UseVisualStyleBackColor = true;
            this.DeleteSearchButton.Click += new System.EventHandler(this.DeleteSearchButton_Click);
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Больше или равно",
            "Меньше или равно"});
            this.searchComboBox.Location = new System.Drawing.Point(277, 273);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(125, 21);
            this.searchComboBox.TabIndex = 15;
            this.searchComboBox.Visible = false;
            this.searchComboBox.SelectedIndexChanged += new System.EventHandler(this.searchComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 333);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.DeleteSearchButton);
            this.Controls.Add(this.TypesOfPassiveElementsComboBox);
            this.Controls.Add(this.nameOfResistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.GetRandomPassiveElementButton);
            this.Controls.Add(this.SearchPassiveElementButton);
            this.Controls.Add(this.LoadPassiveElementButton);
            this.Controls.Add(this.SavePassiveElementButton);
            this.Controls.Add(this.DeletePassiveElementButton);
            this.Controls.Add(this.AddPassiveElementButton);
            this.Controls.Add(this.dataPassiveElementView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label nameOfResistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypesOfPassiveElementsComboBox;
        private System.Windows.Forms.Button DeleteSearchButton;
        private System.Windows.Forms.ComboBox searchComboBox;
    }
}

