using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BirdHouse.Forms
{
    public partial class AddBirdForm : Form
    {
        public AddBirdForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddBirdButton_Click(object sender, EventArgs e)
        {
            string? kind = kindComboBox.SelectedItem as string;
            string? subKind = subKindComboBox.SelectedItem as string;
            if (kind == null)
            {
                MessageBox.Show("Enter Species!");
                            return;
            }

            if (subKind == null)
            {
                MessageBox.Show("Enter Sub Species!");
                return;
            }
            string? serialNumber = serialNumberBoxTextBox.Text;
            string? cageNumber = cageNumberTextBox.Text;
            string? dadSerial = dadSerialTextBox.Text;
            string? momSerial = momSerialTextBox.Text;
            DateTime HatchDate = hatchDateTimePicker.Value;
            string? sex = serialNumberBoxTextBox.Text;
            Bird bird_test = new Bird(serialNumber, kind, subKind, HatchDate, sex, 
                cageNumber, dadSerial, momSerial);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBirdForm_Load(object sender, EventArgs e)
        {
            var SpeciesString = Enum.GetNames(typeof(Species));
            kindComboBox.Items.AddRange(SpeciesString);
            var SubSpeciesString = Enum.GetNames(typeof(SubSpecies));
            subKindComboBox.Items.AddRange(SubSpeciesString);

        }

        private void serialNumberBoxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subKindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sexTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hatchDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
