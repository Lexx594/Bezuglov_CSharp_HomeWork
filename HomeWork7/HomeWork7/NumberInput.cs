using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class NumberInput : Form
    {
        public Sample number { get; set; }

        public NumberInput()
        {
            InitializeComponent();
        }

        public void UpdateNumber()
        {
            textBoxNumberInput.Text = number.MyNumber;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Regex regex = new Regex("[0-9]");
        private void buttonNumberEnter_Click(object sender, EventArgs e)
        {
            if (regex.IsMatch(textBoxNumberInput.Text))
            {
                if(int.Parse(textBoxNumberInput.Text) > 0 && int.Parse(textBoxNumberInput.Text) < 101)
                {
                    number.MyNumber = textBoxNumberInput.Text;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Вы ввели неверное число", "Загадочник", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              

            }
            else
            {
                MessageBox.Show("Вы ввели недопустимое значение", "Загадочник", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

        }
    }
}
