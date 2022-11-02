using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Number : Form
    {
        public Sample number { get; set; } = new Sample
        {
            MyNumber = ""
        };

        private Random random = new Random();
        private int computerNumber;
        private int count = 1;
        private int second;
        private int minutes;
        private List<int> userNumberList = new List<int>();
        private string allNumbers = "Введенные числа: ";

        public Number()
        {
            InitializeComponent();
            labelInputNumber.Text = number.MyNumber;
        }
               

        private void buttonToInputForm_Click(object sender, EventArgs e)
        {

            if(timer.Enabled)
            {
                NumberInput numberInput = new NumberInput();
                numberInput.number = number;
                numberInput.UpdateNumber();
                if (numberInput.ShowDialog() == DialogResult.OK)
                {
                    labelInputNumber.Text = number.MyNumber;
                    count++;
                    labelCount.Text = $"Попытка №{count.ToString()}";
                    userNumberList.Add(int.Parse(number.MyNumber));
                    PrintUserNumber(userNumberList, allNumbers);
                    CheckWin();
                }
            }            
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            computerNumber = random.Next(1, 101);
            MessageBox.Show($"Вам необходимо угадать число от 1 до 100, которое я загадал", "Загадочник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            allNumbers = "Введенные числа: ";
            userNumberList.Clear();
            PrintUserNumber(userNumberList, allNumbers);
            count = 1;
            labelCount.Text = $"Попытка №{count.ToString()}";
            labelInputNumber.Text = "";
            second = 0;
            labelTimerSec.Text = "00";
            minutes = 0;
            labelTimerMin.Text = "00";
            timer.Enabled = true;

        }

        private void CheckWin()
        {
            if(int.Parse(number.MyNumber) == computerNumber)
            {
                timer.Enabled = false;
                MessageBox.Show($"Вы успешно завершили игру за {count - 1} попыток!", "Загадочник", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                

            }
            else if(int.Parse(number.MyNumber) > computerNumber)
            {
                MessageBox.Show("Загаданное число меньше", "Загадочник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Загаданное число больше", "Загадочник", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void PrintUserNumber(List<int> ints, string str)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                str = str + $"{ints[i]}, ";
            }
            labelAllNumbers.Text = str;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (second < 59)
            {
                second++;
                if (second < 10) labelTimerSec.Text = $"0{second}";
                else labelTimerSec.Text = second.ToString();
            }
            else
            {
                if (minutes < 59)
                {
                    minutes++;
                    if (minutes < 10) labelTimerMin.Text = $"0{minutes}";
                    else labelTimerMin.Text = minutes.ToString();
                    second = 0;
                    labelTimerSec.Text = "00";
                }
                else
                {
                    minutes = 0;
                    labelTimerMin.Text = "00";

                }

            }
        }
    }
}
