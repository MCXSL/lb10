using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
                string[] animalStr = Animal.FormingString(animal);
                dataGridViewAllAnimal.Rows.Add(animalStr[0], animalStr[1], animalStr[2], animalStr[3], animalStr[4]);
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

        private void buttonGenerationColection_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            for (int i = 0 ; i < 100; i++)
            {
                Animal animal = new Animal();
                animals.Add(animal);
                string[] animalStr = Animal.FormingString(animals[i]);
                dataGridViewAllAnimal.Rows.Add(animalStr[0], animalStr[1], animalStr[2], animalStr[3], animalStr[4]);
            }
            textBoxKolvoZapisei.Text = Animal.EnterNumberAnimals();
            // генератор коллекциии сделать в классе Animal
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //dataGridViewAllAnimal.Select();
        }

        private void dataGridViewAllAnimal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewAllAnimal.Rows[e.RowIndex];
                string[] weightLast3Mounth = Animal.UnformingWeight(row.Cells["WeightLast3Mounth"].Value.ToString());

                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxAge.Text = row.Cells["Age"].Value.ToString();
                textBoxWeightLast3Mounth1.Text = weightLast3Mounth[0];
                textBoxWeightLast3Mounth2.Text = weightLast3Mounth[1];
                textBoxWeightLast3Mounth3.Text = weightLast3Mounth[2];
                textBoxNumberPhone.Text = row.Cells["NumberPhone"].Value.ToString();
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
