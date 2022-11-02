using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {
        TrueFalseEngine engine;
        int trueCount;
        public Main()
        {
            InitializeComponent();
        }
        public bool flag = false;


        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Add("Вопрос", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
        //    do
        //    {
        //        OpenFileDialog dlg = new OpenFileDialog();
        //        if (dlg.ShowDialog() == DialogResult.OK)
        //        {
        //            flag = true;
        //            engine = new TrueFalseEngine(dlg.FileName);
        //            engine.Load();
        //            if (engine.Count < 1)
        //            {
        //                MessageBox.Show("Неверный формат файла\n Выберете новый файл", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    while(engine.Count < 1);
        //    nudNumber.Minimum = 1;
        //    nudNumber.Maximum = engine.Count;
        //    nudNumber.Value = 1;
        //}





        M:
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                engine = new TrueFalseEngine(dlg.FileName);
                engine.Load();
                if (engine.Count < 1)
                {
                    MessageBox.Show("Неверный формат файла\n Выберете новый файл", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto M;
                }
                else
                {
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = engine.Count;
                    nudNumber.Value = 1;
                    flag = true;
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                engine.Save();
            }
            else
            {
                MessageBox.Show("Нет файла для сохранения", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    engine.FileName = dlg.FileName;
                    engine.Save();
                }                                        
            }
            else
            {
                MessageBox.Show("Нет файла для сохранения", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                engine.Add($"#{engine.Count + 1}", true);
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = engine.Count;
            }
            else
            {
                MessageBox.Show("Не загружен вопросник", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                if (nudNumber.Maximum == 1)
                {
                    MessageBox.Show("Нельзя удалять последний вопрос", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        engine.Remove((int)nudNumber.Value - 1);
                        nudNumber.Maximum--;
                        nudNumber.Value--;
                    }
                    catch
                    {
                        nudNumber.Value = 1;
                        tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                        cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                    }
                }
            }
            else
            {
                MessageBox.Show("Не загружен вопросник", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else
            {
                MessageBox.Show("Не загружен вопросник", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProgForm progFormn = new ProgForm();
            progFormn.ShowDialog();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                if (panelDL.Visible)
                {
                    panelDL.Visible = false;
                    panelDR.Visible = false;
                    btnNo.Visible = true;
                    btnYes.Visible = true;
                    labelCountQuestion.Visible = true;
                    btnStartGame.BackColor = Color.DarkRed;
                    btnStartGame.Text = "Завершить игру";
                    nudNumber.Value = 1;
                    labelCountQuestion.Text = $"Вопрос {nudNumber.Value}/{nudNumber.Maximum}";
                    tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                    cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
                }
                else
                {
                    panelDL.Visible = true;
                    panelDR.Visible = true;
                    btnNo.Visible = false;
                    btnYes.Visible = false;
                    labelCountQuestion.Visible = false;
                    btnStartGame.BackColor = Color.DarkGreen;
                    btnStartGame.Text = "Начать игру";
                }

            }
            else MessageBox.Show("Загрузите вопросы", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Step()
        {
            try
            {
                nudNumber.Value++;
                labelCountQuestion.Text = $"Вопрос {nudNumber.Value}/{nudNumber.Maximum}";
                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch
            {
                MessageBox.Show($"Вы ответили на {nudNumber.Value} вопросов.\nПравильных ответов {trueCount}.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnNo.Visible = false;
                btnYes.Visible = false;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            if (cbTrue.Checked)
            {
                trueCount++;
                MessageBox.Show("Верно!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Неверно!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Step();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {

            if (!cbTrue.Checked)
            {
                 trueCount++;
                 MessageBox.Show("Верно!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else MessageBox.Show("Неверно!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Step();
       
        }
    }
}
