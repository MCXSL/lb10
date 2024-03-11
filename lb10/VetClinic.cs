using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lb10
{
    public partial class VetClinic : Form
    {
        public VetClinic()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string[] weightLast3Mounth = { textBoxWeightLast3Mounth1.Text, textBoxWeightLast3Mounth2.Text, textBoxWeightLast3Mounth3.Text };
            bool corectWeightLast3Mounth = Animal.CheackWeightLast3Mounth(weightLast3Mounth);
            bool corectAge = Animal.CheackAge(textBoxAge.Text);

            if (corectWeightLast3Mounth && corectAge)
            {
                Animal animal = new Animal(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), Animal.ConvToArr(weightLast3Mounth), comboBoxType.Text, textBoxNumberPhone.Text);
                textBoxKolvoZapisei.Text = Animal.EnterNumberAnimals();
                dataGridViewAllAnimal.Rows.Add(textBoxName.Text, Convert.ToInt32(textBoxAge.Text), Animal.ConvToArr(weightLast3Mounth), comboBoxType.Text, textBoxNumberPhone.Text);
                labelAlarm.Text = null;
            }
            else 
            {
                textBoxAge.Text = null;
                textBoxWeightLast3Mounth1.Text = null;
                textBoxWeightLast3Mounth2.Text = null;
                textBoxWeightLast3Mounth3.Text = null;
                labelAlarm.Text = "Введите корректные значения";
            }
        }

        

        //private void listBoxAllAnimal_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int temp = listBoxAllAnimal.SelectedIndex;

        //    if (temp >= 1)
        //    {
        //        string[] strings = Animal.UnformingString(listBoxAllAnimal.Items[temp].ToString());
        //        textBoxName.Text = strings[0].Trim();
        //        textBoxAge.Text = strings[1].Trim();
        //        textBoxWeightLast3Mounth1.Text = strings[2].Trim();
        //        textBoxWeightLast3Mounth2.Text = strings[3].Trim();    
        //        textBoxWeightLast3Mounth3.Text = strings[4].Trim();
        //        textBoxNumberPhone.Text = strings[6].Trim();
        //    }
                
        //}

    }
}
