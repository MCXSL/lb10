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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.labelAge.Location = new System.Drawing.Point(55, 136);
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
            this.labelType.Location = new System.Drawing.Point(55, 264);
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
            this.buttonCreate.Location = new System.Drawing.Point(115, 364);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(324, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            // 
            // VetClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 477);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelNumberPhone);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelWeightLast3Mounth);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Name = "VetClinic";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

