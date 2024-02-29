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
            Animal animal = new Animal(textBoxName.Text, Convert.ToInt32(textBoxAge.Text),Animal.ConvToArr(textBoxWeightLast3Mounth1.Text,textBoxWeightLast3Mounth2.Text, textBoxWeightLast3Mounth3.Text), comboBoxType.Text, textBoxNumberPhone.Text);
            textBoxKolvoZapisei.Text = Animal.EnterNumberAnimals();
            listBoxAllAnimal.Items.Add(Animal.FormingString(animal));
        }
    }
}
