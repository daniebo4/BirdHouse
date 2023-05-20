using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string? serialNumber = serialNumberBoxTextBox.Text;
            string? cageNumber = cageNumberTextBox.Text;
            string? dadSerial = dadSerialTextBox.Text;
            string? momSerial = momSerialTextBox.Text;
            string? HatchDate = hatchDateTimePicker.ToString();
            string? sex = serialNumberBoxTextBox.Text;

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddBirdForm_Load(object sender, EventArgs e)
        {
            var SpeciesString = Enum.GetNames(typeof(Species));
            kindComboBox.Items.AddRange(SpeciesString);
        }
    }
}
