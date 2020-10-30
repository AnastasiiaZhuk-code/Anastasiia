namespace PassiveElementForm
{
    partial class AddPassiveElementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rangeOfTypesPassiveElementsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PassiveElementParameter1_textBox = new System.Windows.Forms.TextBox();
            this.PassiveElementParameter2_textBox = new System.Windows.Forms.TextBox();
            this.PassiveElementParameter1 = new System.Windows.Forms.Label();
            this.PassiveElementParameter2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddPassiveElementButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип пассивного элемента:";
            // 
            // rangeOfTypesPassiveElementsComboBox
            // 
            this.rangeOfTypesPassiveElementsComboBox.FormattingEnabled = true;
            this.rangeOfTypesPassiveElementsComboBox.Items.AddRange(new object[] {
            "Индуктивность",
            "Конденсатор",
            "Резистор"});
            this.rangeOfTypesPassiveElementsComboBox.Location = new System.Drawing.Point(270, 24);
            this.rangeOfTypesPassiveElementsComboBox.Name = "rangeOfTypesPassiveElementsComboBox";
            this.rangeOfTypesPassiveElementsComboBox.Size = new System.Drawing.Size(121, 24);
            this.rangeOfTypesPassiveElementsComboBox.TabIndex = 5;
            this.rangeOfTypesPassiveElementsComboBox.SelectedIndexChanged += new System.EventHandler(this.rangeOfTypesPassiveElementsComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassiveElementParameter2);
            this.groupBox1.Controls.Add(this.PassiveElementParameter1);
            this.groupBox1.Controls.Add(this.PassiveElementParameter2_textBox);
            this.groupBox1.Controls.Add(this.PassiveElementParameter1_textBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите параметры элемента";
            // 
            // PassiveElementParameter1_textBox
            // 
            this.PassiveElementParameter1_textBox.Location = new System.Drawing.Point(264, 33);
            this.PassiveElementParameter1_textBox.Name = "PassiveElementParameter1_textBox";
            this.PassiveElementParameter1_textBox.Size = new System.Drawing.Size(121, 22);
            this.PassiveElementParameter1_textBox.TabIndex = 0;
            // 
            // PassiveElementParameter2_textBox
            // 
            this.PassiveElementParameter2_textBox.Location = new System.Drawing.Point(264, 80);
            this.PassiveElementParameter2_textBox.Name = "PassiveElementParameter2_textBox";
            this.PassiveElementParameter2_textBox.Size = new System.Drawing.Size(121, 22);
            this.PassiveElementParameter2_textBox.TabIndex = 1;
            // 
            // PassiveElementParameter1
            // 
            this.PassiveElementParameter1.AutoSize = true;
            this.PassiveElementParameter1.Location = new System.Drawing.Point(7, 38);
            this.PassiveElementParameter1.Name = "PassiveElementParameter1";
            this.PassiveElementParameter1.Size = new System.Drawing.Size(46, 17);
            this.PassiveElementParameter1.TabIndex = 2;
            this.PassiveElementParameter1.Text = "label2";
            // 
            // PassiveElementParameter2
            // 
            this.PassiveElementParameter2.AutoSize = true;
            this.PassiveElementParameter2.Location = new System.Drawing.Point(7, 85);
            this.PassiveElementParameter2.Name = "PassiveElementParameter2";
            this.PassiveElementParameter2.Size = new System.Drawing.Size(46, 17);
            this.PassiveElementParameter2.TabIndex = 3;
            this.PassiveElementParameter2.Text = "label3";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(316, 199);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 31);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddPassiveElementButton
            // 
            this.AddPassiveElementButton.Location = new System.Drawing.Point(220, 199);
            this.AddPassiveElementButton.Name = "AddPassiveElementButton";
            this.AddPassiveElementButton.Size = new System.Drawing.Size(87, 31);
            this.AddPassiveElementButton.TabIndex = 8;
            this.AddPassiveElementButton.Text = "ОК";
            this.AddPassiveElementButton.UseVisualStyleBackColor = true;
            // 
            // AddPassiveElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 241);
            this.Controls.Add(this.AddPassiveElementButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rangeOfTypesPassiveElementsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "AddPassiveElementForm";
            this.Text = "Добавить пассивный элемент";
            this.Load += new System.EventHandler(this.AddPassiveElementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rangeOfTypesPassiveElementsComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PassiveElementParameter2;
        private System.Windows.Forms.Label PassiveElementParameter1;
        private System.Windows.Forms.TextBox PassiveElementParameter2_textBox;
        private System.Windows.Forms.TextBox PassiveElementParameter1_textBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddPassiveElementButton;
    }
}