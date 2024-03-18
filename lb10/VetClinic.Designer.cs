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
            this.buttonGenerationColection = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(41, 60);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя животного";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(41, 110);
            this.labelAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(106, 13);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "Возраст животного";
            // 
            // labelWeightLast3Mounth
            // 
            this.labelWeightLast3Mounth.AutoSize = true;
            this.labelWeightLast3Mounth.Location = new System.Drawing.Point(41, 156);
            this.labelWeightLast3Mounth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeightLast3Mounth.Name = "labelWeightLast3Mounth";
            this.labelWeightLast3Mounth.Size = new System.Drawing.Size(111, 26);
            this.labelWeightLast3Mounth.TabIndex = 2;
            this.labelWeightLast3Mounth.Text = "Вес животного за \r\nпоследние 3 месяца";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(41, 214);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(26, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Вид";
            // 
            // labelNumberPhone
            // 
            this.labelNumberPhone.AutoSize = true;
            this.labelNumberPhone.Location = new System.Drawing.Point(41, 250);
            this.labelNumberPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberPhone.Name = "labelNumberPhone";
            this.labelNumberPhone.Size = new System.Drawing.Size(137, 13);
            this.labelNumberPhone.TabIndex = 4;
            this.labelNumberPhone.Text = "Номер телефона хозяина";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(232, 288);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(74, 19);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(232, 60);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(76, 20);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(232, 110);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(76, 20);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxWeightLast3Mounth1
            // 
            this.textBoxWeightLast3Mounth1.Location = new System.Drawing.Point(232, 164);
            this.textBoxWeightLast3Mounth1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWeightLast3Mounth1.Name = "textBoxWeightLast3Mounth1";
            this.textBoxWeightLast3Mounth1.Size = new System.Drawing.Size(76, 20);
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
            this.comboBoxType.Location = new System.Drawing.Point(232, 208);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(92, 21);
            this.comboBoxType.TabIndex = 9;
            // 
            // labelKolvoZapisei
            // 
            this.labelKolvoZapisei.AutoSize = true;
            this.labelKolvoZapisei.Location = new System.Drawing.Point(568, 31);
            this.labelKolvoZapisei.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKolvoZapisei.Name = "labelKolvoZapisei";
            this.labelKolvoZapisei.Size = new System.Drawing.Size(82, 13);
            this.labelKolvoZapisei.TabIndex = 11;
            this.labelKolvoZapisei.Text = "Всего записей";
            // 
            // textBoxKolvoZapisei
            // 
            this.textBoxKolvoZapisei.Location = new System.Drawing.Point(699, 28);
            this.textBoxKolvoZapisei.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKolvoZapisei.Name = "textBoxKolvoZapisei";
            this.textBoxKolvoZapisei.ReadOnly = true;
            this.textBoxKolvoZapisei.Size = new System.Drawing.Size(76, 20);
            this.textBoxKolvoZapisei.TabIndex = 12;
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.Location = new System.Drawing.Point(232, 245);
            this.textBoxNumberPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.Size = new System.Drawing.Size(76, 20);
            this.textBoxNumberPhone.TabIndex = 13;
            // 
            // textBoxWeightLast3Mounth2
            // 
            this.textBoxWeightLast3Mounth2.Location = new System.Drawing.Point(342, 164);
            this.textBoxWeightLast3Mounth2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWeightLast3Mounth2.Name = "textBoxWeightLast3Mounth2";
            this.textBoxWeightLast3Mounth2.Size = new System.Drawing.Size(76, 20);
            this.textBoxWeightLast3Mounth2.TabIndex = 14;
            this.textBoxWeightLast3Mounth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWeightLast3Mounth3
            // 
            this.textBoxWeightLast3Mounth3.Location = new System.Drawing.Point(458, 164);
            this.textBoxWeightLast3Mounth3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWeightLast3Mounth3.Name = "textBoxWeightLast3Mounth3";
            this.textBoxWeightLast3Mounth3.Size = new System.Drawing.Size(73, 20);
            this.textBoxWeightLast3Mounth3.TabIndex = 15;
            this.textBoxWeightLast3Mounth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWeightLast3Mounth1
            // 
            this.labelWeightLast3Mounth1.AutoSize = true;
            this.labelWeightLast3Mounth1.Location = new System.Drawing.Point(239, 149);
            this.labelWeightLast3Mounth1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeightLast3Mounth1.Name = "labelWeightLast3Mounth1";
            this.labelWeightLast3Mounth1.Size = new System.Drawing.Size(65, 13);
            this.labelWeightLast3Mounth1.TabIndex = 16;
            this.labelWeightLast3Mounth1.Text = "Этот месяц";
            // 
            // labelWeightLast3Mounth2
            // 
            this.labelWeightLast3Mounth2.AutoSize = true;
            this.labelWeightLast3Mounth2.Location = new System.Drawing.Point(340, 149);
            this.labelWeightLast3Mounth2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeightLast3Mounth2.Name = "labelWeightLast3Mounth2";
            this.labelWeightLast3Mounth2.Size = new System.Drawing.Size(90, 13);
            this.labelWeightLast3Mounth2.TabIndex = 17;
            this.labelWeightLast3Mounth2.Text = "Прошлый месяц";
            // 
            // labelWeightLast3Mounth3
            // 
            this.labelWeightLast3Mounth3.AutoSize = true;
            this.labelWeightLast3Mounth3.Location = new System.Drawing.Point(451, 149);
            this.labelWeightLast3Mounth3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWeightLast3Mounth3.Name = "labelWeightLast3Mounth3";
            this.labelWeightLast3Mounth3.Size = new System.Drawing.Size(115, 13);
            this.labelWeightLast3Mounth3.TabIndex = 18;
            this.labelWeightLast3Mounth3.Text = "Позапрошлый Месяц";
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.Location = new System.Drawing.Point(272, 367);
            this.labelAlarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(0, 13);
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
            this.dataGridViewAllAnimal.Location = new System.Drawing.Point(570, 73);
            this.dataGridViewAllAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAllAnimal.Name = "dataGridViewAllAnimal";
            this.dataGridViewAllAnimal.ReadOnly = true;
            this.dataGridViewAllAnimal.RowHeadersWidth = 51;
            this.dataGridViewAllAnimal.RowTemplate.Height = 24;
            this.dataGridViewAllAnimal.Size = new System.Drawing.Size(511, 122);
            this.dataGridViewAllAnimal.TabIndex = 21;
            this.dataGridViewAllAnimal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllAnimal_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 125;
            // 
            // WeightLast3Mounth
            // 
            this.WeightLast3Mounth.HeaderText = "Вес за 3 месяца";
            this.WeightLast3Mounth.MinimumWidth = 6;
            this.WeightLast3Mounth.Name = "WeightLast3Mounth";
            this.WeightLast3Mounth.ReadOnly = true;
            this.WeightLast3Mounth.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Вид";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // NumberPhone
            // 
            this.NumberPhone.HeaderText = "Номер телефона";
            this.NumberPhone.MinimumWidth = 6;
            this.NumberPhone.Name = "NumberPhone";
            this.NumberPhone.ReadOnly = true;
            this.NumberPhone.Width = 125;
            // 
            // buttonGenerationColection
            // 
            this.buttonGenerationColection.Location = new System.Drawing.Point(342, 288);
            this.buttonGenerationColection.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerationColection.Name = "buttonGenerationColection";
            this.buttonGenerationColection.Size = new System.Drawing.Size(150, 35);
            this.buttonGenerationColection.TabIndex = 22;
            this.buttonGenerationColection.Text = "Сгенерировать коллекцию";
            this.buttonGenerationColection.UseVisualStyleBackColor = true;
            this.buttonGenerationColection.Click += new System.EventHandler(this.buttonGenerationColection_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(734, 288);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 83);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Замеры:";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(104, 288);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(74, 19);
            this.buttonEdit.TabIndex = 25;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // VetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 540);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonGenerationColection);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button buttonGenerationColection;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEdit;
    }
}

