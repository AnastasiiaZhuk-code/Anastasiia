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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataPassiveElementView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPassiveElementView
            // 
            this.dataPassiveElementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPassiveElementView.Location = new System.Drawing.Point(12, 65);
            this.dataPassiveElementView.Name = "dataPassiveElementView";
            this.dataPassiveElementView.ReadOnly = true;
            this.dataPassiveElementView.RowHeadersWidth = 51;
            this.dataPassiveElementView.RowTemplate.Height = 24;
            this.dataPassiveElementView.Size = new System.Drawing.Size(638, 281);
            this.dataPassiveElementView.TabIndex = 0;
            // 
            // AddPassiveElementButton
            // 
            this.AddPassiveElementButton.Location = new System.Drawing.Point(104, 364);
            this.AddPassiveElementButton.Name = "AddPassiveElementButton";
            this.AddPassiveElementButton.Size = new System.Drawing.Size(90, 29);
            this.AddPassiveElementButton.TabIndex = 1;
            this.AddPassiveElementButton.Text = "Добавить";
            this.AddPassiveElementButton.UseVisualStyleBackColor = true;
            this.AddPassiveElementButton.Click += new System.EventHandler(this.AddPassiveElementButton_Click);
            // 
            // DeletePassiveElementButton
            // 
            this.DeletePassiveElementButton.Location = new System.Drawing.Point(200, 364);
            this.DeletePassiveElementButton.Name = "DeletePassiveElementButton";
            this.DeletePassiveElementButton.Size = new System.Drawing.Size(87, 29);
            this.DeletePassiveElementButton.TabIndex = 2;
            this.DeletePassiveElementButton.Text = "Удалить";
            this.DeletePassiveElementButton.UseVisualStyleBackColor = true;
            this.DeletePassiveElementButton.Click += new System.EventHandler(this.DeletePassiveElementButton_Click);
            // 
            // SavePassiveElementButton
            // 
            this.SavePassiveElementButton.Location = new System.Drawing.Point(293, 364);
            this.SavePassiveElementButton.Name = "SavePassiveElementButton";
            this.SavePassiveElementButton.Size = new System.Drawing.Size(89, 29);
            this.SavePassiveElementButton.TabIndex = 3;
            this.SavePassiveElementButton.Text = "Сохранить";
            this.SavePassiveElementButton.UseVisualStyleBackColor = true;
            this.SavePassiveElementButton.Click += new System.EventHandler(this.SavePassiveElementButton_Click);
            // 
            // LoadPassiveElementButton
            // 
            this.LoadPassiveElementButton.Location = new System.Drawing.Point(388, 364);
            this.LoadPassiveElementButton.Name = "LoadPassiveElementButton";
            this.LoadPassiveElementButton.Size = new System.Drawing.Size(86, 29);
            this.LoadPassiveElementButton.TabIndex = 4;
            this.LoadPassiveElementButton.Text = "Загрузить";
            this.LoadPassiveElementButton.UseVisualStyleBackColor = true;
            this.LoadPassiveElementButton.Click += new System.EventHandler(this.LoadPassiveElementButton_Click);
            // 
            // SearchPassiveElementButton
            // 
            this.SearchPassiveElementButton.Location = new System.Drawing.Point(12, 364);
            this.SearchPassiveElementButton.Name = "SearchPassiveElementButton";
            this.SearchPassiveElementButton.Size = new System.Drawing.Size(86, 29);
            this.SearchPassiveElementButton.TabIndex = 5;
            this.SearchPassiveElementButton.Text = "Поиск";
            this.SearchPassiveElementButton.UseVisualStyleBackColor = true;
            this.SearchPassiveElementButton.Click += new System.EventHandler(this.SearchPassiveElementButton_Click);
            // 
            // GetRandomPassiveElementButton
            // 
            this.GetRandomPassiveElementButton.Location = new System.Drawing.Point(480, 364);
            this.GetRandomPassiveElementButton.Name = "GetRandomPassiveElementButton";
            this.GetRandomPassiveElementButton.Size = new System.Drawing.Size(170, 29);
            this.GetRandomPassiveElementButton.TabIndex = 6;
            this.GetRandomPassiveElementButton.Text = "Рандомный элемент";
            this.GetRandomPassiveElementButton.UseVisualStyleBackColor = true;
            this.GetRandomPassiveElementButton.Click += new System.EventHandler(this.GetRandomPassiveElementButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(508, 26);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(89, 22);
            this.searchTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Комплексное сопротивление \r\nпассивного элемента:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вид элемента";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Индуктивность",
            "Конденсатор",
            "Резистор"});
            this.comboBox1.Location = new System.Drawing.Point(119, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.GetRandomPassiveElementButton);
            this.Controls.Add(this.SearchPassiveElementButton);
            this.Controls.Add(this.LoadPassiveElementButton);
            this.Controls.Add(this.SavePassiveElementButton);
            this.Controls.Add(this.DeletePassiveElementButton);
            this.Controls.Add(this.AddPassiveElementButton);
            this.Controls.Add(this.dataPassiveElementView);
            this.Name = "MainForm";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

