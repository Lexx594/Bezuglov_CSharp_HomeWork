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
    
    public partial class Main : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int count;
        private int second;
        private int minutes;

        Stack<int> stackUserNumber = new Stack<int>();    //работает по принципу "последним пришел - первым вышел"
        //List<int> stackUserNumber2 = new List<int>();     //тоже самое, но толькочерез коллекцию List

        public Main()
        {
            InitializeComponent();
            //UpdateGameState(userNumber, random.Next(5, 20), count);
        }

        private void UpdateGameState(int userNumber, int count)
        {
            labelUserNumber.Text = $"Текущее число: {userNumber}";
            labelCount.Text = $"Счетчик ходов: {count}";
        }

        private void UpdateGameState(int userNumber, int computerNumber, int count)
        {
            UpdateGameState(userNumber, count);
            this.computerNumber = computerNumber;
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 0, random.Next(5, 20), count *= 0);
            second = 0;
            labelTimerSec.Text = "00";
            minutes = 0;
            labelTimerMin.Text = "00";
            MessageBox.Show($"Вам необходимо получить число: {computerNumber}", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer.Enabled = true;
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 0, count *= 0);
            second = 0;
            labelTimerSec.Text = "00";
            minutes = 0;
            labelTimerMin.Text = "00";
            timer.Enabled = true;
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if(timer.Enabled)
            {
                UpdateGameState(userNumber *= 2, ++count);
                //stackUserNumber2.Add(userNumber);
                stackUserNumber.Push(userNumber); //передаем число игрока в список
                CheckWin();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                //userNumber = stackUserNumber2[stackUserNumber2.Count - 2];
                //stackUserNumber2.RemoveAt(stackUserNumber2.Count - 1);
                
                stackUserNumber.Pop();   
                userNumber = stackUserNumber.Peek();
                UpdateGameState(userNumber, count);
            }
            catch
            {
                userNumber = 0;
                UpdateGameState(userNumber, count);
            }

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if(timer.Enabled)
            {
                UpdateGameState(++userNumber, ++count);
                //stackUserNumber2.Add(userNumber);
                stackUserNumber.Push(userNumber); //передаем число игрока в список
                CheckWin();
            }
        }

        private void CheckWin()
        {
            if (userNumber == computerNumber)
            {
                timer.Enabled = false;
                
                if(minutes == 0) MessageBox.Show($"Вы успешно завершили игру за {second} секунд!", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show($"Вы успешно завершили игру за {minutes} минут {second} секунд!", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //UpdateGameState(userNumber *= 0, random.Next(5, 20), count *= 0);
                }
                else
                {

                }
            }
            else if(userNumber > computerNumber)
            {
                timer.Enabled = false;
                MessageBox.Show("Вы проиграли!", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //UpdateGameState(userNumber *= 0, random.Next(5, 20), count *= 0);
                }
                else
                {

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(second < 59)
            {
                second++;
                if(second < 10) labelTimerSec.Text = $"0{second}";
                else labelTimerSec.Text = second.ToString();
            }
            else
            {
                if(minutes < 59)
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
