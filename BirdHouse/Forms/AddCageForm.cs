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
    public partial class AddCageForm : Form
    {
        public AddCageForm()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? serial = SerialNumberTextBox.Text;
            string? material = MaterialComboBox.SelectedItem as string;
            if (material == null)
            {
                MessageBox.Show("Enter Material!");
                return;
            }

            string? length = LengthTextBox.Text;
            if (length.Length > 0)
            {
                foreach (char c in length)
                {

                    if (!(char.IsNumber(c) || char.IsLetter(c)))
                    {
                        MessageBox.Show("Invalide Legnth! \njust numbers and letters allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Length!");
                return;
            }
            string? width = WidthTextBox.Text;
            if (width.Length > 0)
            {
                foreach (char c in width)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalide Width! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Widgth!");
                return;
            }
            string? height = HeightTextBox.Text;
            if (height.Length > 0)
            {
                foreach (char c in height)
                {

                    if (!(char.IsNumber(c)))
                    {
                        MessageBox.Show("Invalide Height! \njust numbers allowed!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Height!");
                return;
            }
            Cage cage_test = new Cage(serial, length, width, height, material);
        }

        private void SerialNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCageForm_Load(object sender, EventArgs e)
        {
            var MaterialString = Enum.GetNames(typeof(Material));
            MaterialComboBox.Items.AddRange(MaterialString);
        }
    }
}
