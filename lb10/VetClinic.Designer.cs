namespace lb10
{
    partial class VetClinic
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelWeightLast3Mounth = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelNumberPhone = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxWeightLast3Mounth1 = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelKolvoZapisei = new System.Windows.Forms.Label();
            this.textBoxKolvoZapisei = new System.Windows.Forms.TextBox();
            this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.textBoxWeightLast3Mounth2 = new System.Windows.Forms.TextBox();
            this.textBoxWeightLast3Mounth3 = new System.Windows.Forms.TextBox();
            this.labelWeightLast3Mounth1 = new System.Windows.Forms.Label();
            this.labelWeightLast3Mounth2 = new System.Windows.Forms.Label();
            this.labelWeightLast3Mounth3 = new System.Windows.Forms.Label();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.dataGridViewAllAnimal = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightLast3Mounth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(55, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(106, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя животного";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(55, 135);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(135, 16);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Возраст животного";
            // 
            // labelWeightLast3Mounth
            // 
            this.labelWeightLast3Mounth.AutoSize = true;
            this.labelWeightLast3Mounth.Location = new System.Drawing.Point(55, 192);
            this.labelWeightLast3Mounth.Name = "labelWeightLast3Mounth";
            this.labelWeightLast3Mounth.Size = new System.Drawing.Size(138, 32);
            this.labelWeightLast3Mounth.TabIndex = 2;
            this.labelWeightLast3Mounth.Text = "Вес животного за \r\nпоследние 3 месяца";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(55, 263);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(32, 16);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Вид";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(55, 308);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(175, 16);
            this.labelNumberPhone.TabIndex = 4;
            this.labelNumberPhone.Text = "Номер телефона хозяина";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(309, 354);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(99, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(309, 74);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(309, 135);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxWeightLast3Mounth1
            // 
            this.textBoxWeightLast3Mounth1.Location = new System.Drawing.Point(309, 202);
            this.textBoxWeightLast3Mounth1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWeightLast3Mounth1.Name = "textBoxWeightLast3Mounth1";
            this.textBoxWeightLast3Mounth1.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeightLast3Mounth1.TabIndex = 8;
            this.textBoxWeightLast3Mounth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Кошка",
            "Собака"});
            this.comboBoxType.Location = new System.Drawing.Point(309, 256);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 9;
            // 
            // labelKolvoZapisei
            // 
            this.labelKolvoZapisei.AutoSize = true;
            this.labelKolvoZapisei.Location = new System.Drawing.Point(757, 38);
            this.labelKolvoZapisei.Name = "labelKolvoZapisei";
            this.labelKolvoZapisei.Size = new System.Drawing.Size(103, 16);
            this.labelKolvoZapisei.TabIndex = 11;
            this.labelKolvoZapisei.Text = "Всего записей";
            // 
            // textBoxKolvoZapisei
            // 
            this.textBoxKolvoZapisei.Location = new System.Drawing.Point(932, 34);
            this.textBoxKolvoZapisei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKolvoZapisei.Name = "textBoxKolvoZapisei";
            this.textBoxKolvoZapisei.ReadOnly = true;
            this.textBoxKolvoZapisei.Size = new System.Drawing.Size(100, 22);
            this.textBoxKolvoZapisei.TabIndex = 12;
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.Location = new System.Drawing.Point(309, 302);
            this.textBoxNumberPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberPhone.TabIndex = 13;
            // 
            // textBoxWeightLast3Mounth2
            // 
            this.textBoxWeightLast3Mounth2.Location = new System.Drawing.Point(456, 202);
            this.textBoxWeightLast3Mounth2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWeightLast3Mounth2.Name = "textBoxWeightLast3Mounth2";
            this.textBoxWeightLast3Mounth2.Size = new System.Drawing.Size(100, 22);
            this.textBoxWeightLast3Mounth2.TabIndex = 14;
            this.textBoxWeightLast3Mounth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWeightLast3Mounth3
            // 
            this.textBoxWeightLast3Mounth3.Location = new System.Drawing.Point(611, 202);
            this.textBoxWeightLast3Mounth3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWeightLast3Mounth3.Name = "textBoxWeightLast3Mounth3";
            this.textBoxWeightLast3Mounth3.Size = new System.Drawing.Size(96, 22);
            this.textBoxWeightLast3Mounth3.TabIndex = 15;
            this.textBoxWeightLast3Mounth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWeightLast3Mounth1
            // 
            this.labelWeightLast3Mounth1.AutoSize = true;
            this.labelWeightLast3Mounth1.Location = new System.Drawing.Point(319, 183);
            this.labelWeightLast3Mounth1.Name = "labelWeightLast3Mounth1";
            this.labelWeightLast3Mounth1.Size = new System.Drawing.Size(81, 16);
            this.labelWeightLast3Mounth1.TabIndex = 16;
            this.labelWeightLast3Mounth1.Text = "Этот месяц";
            // 
            // labelWeightLast3Mounth2
            // 
            this.labelWeightLast3Mounth2.AutoSize = true;
            this.labelWeightLast3Mounth2.Location = new System.Drawing.Point(453, 183);
            this.labelWeightLast3Mounth2.Name = "labelWeightLast3Mounth2";
            this.labelWeightLast3Mounth2.Size = new System.Drawing.Size(109, 16);
            this.labelWeightLast3Mounth2.TabIndex = 17;
            this.labelWeightLast3Mounth2.Text = "Прошлый месяц";
            // 
            // labelWeightLast3Mounth3
            // 
            this.labelWeightLast3Mounth3.AutoSize = true;
            this.labelWeightLast3Mounth3.Location = new System.Drawing.Point(601, 183);
            this.labelWeightLast3Mounth3.Name = "labelWeightLast3Mounth3";
            this.labelWeightLast3Mounth3.Size = new System.Drawing.Size(143, 16);
            this.labelWeightLast3Mounth3.TabIndex = 18;
            this.labelWeightLast3Mounth3.Text = "Позапрошлый Месяц";
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.Location = new System.Drawing.Point(363, 452);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(0, 16);
            this.labelAlarm.TabIndex = 19;
            // 
            // dataGridViewAllAnimal
            // 
            this.dataGridViewAllAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Age,
            this.WeightLast3Mounth,
            this.Type,
            this.NumberPhone});
            this.dataGridViewAllAnimal.Location = new System.Drawing.Point(760, 90);
            this.dataGridViewAllAnimal.Name = "dataGridViewAllAnimal";
            this.dataGridViewAllAnimal.RowHeadersWidth = 51;
            this.dataGridViewAllAnimal.RowTemplate.Height = 24;
            this.dataGridViewAllAnimal.Size = new System.Drawing.Size(681, 150);
            this.dataGridViewAllAnimal.TabIndex = 21;
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // WeightLast3Mounth
            // 
            this.WeightLast3Mounth.HeaderText = "Вес за 3 месяца";
            this.WeightLast3Mounth.MinimumWidth = 6;
            this.WeightLast3Mounth.Name = "WeightLast3Mounth";
            this.WeightLast3Mounth.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Вид";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // NumberPhone
            // 
            this.NumberPhone.HeaderText = "Номер телефона";
            this.NumberPhone.MinimumWidth = 6;
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.Width = 125;
            // 
            // VetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 665);
            this.Controls.Add(this.dataGridViewAllAnimal);
            this.Controls.Add(this.labelAlarm);
            this.Controls.Add(this.labelWeightLast3Mounth3);
            this.Controls.Add(this.labelWeightLast3Mounth2);
            this.Controls.Add(this.labelWeightLast3Mounth1);
            this.Controls.Add(this.textBoxWeightLast3Mounth3);
            this.Controls.Add(this.textBoxWeightLast3Mounth2);
            this.Controls.Add(this.textBoxNumberPhone);
            this.Controls.Add(this.textBoxKolvoZapisei);
            this.Controls.Add(this.labelKolvoZapisei);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxWeightLast3Mounth1);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelWeightLast3Mounth);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "VetClinic";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelWeightLast3Mounth;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelNumberPhone;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxWeightLast3Mounth1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelKolvoZapisei;
        private System.Windows.Forms.TextBox textBoxKolvoZapisei;
        private System.Windows.Forms.TextBox textBoxNumberPhone;
        private System.Windows.Forms.TextBox textBoxWeightLast3Mounth2;
        private System.Windows.Forms.TextBox textBoxWeightLast3Mounth3;
        private System.Windows.Forms.Label labelWeightLast3Mounth1;
        private System.Windows.Forms.Label labelWeightLast3Mounth2;
        private System.Windows.Forms.Label labelWeightLast3Mounth3;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.DataGridView dataGridViewAllAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightLast3Mounth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberPhone;
    }
}

