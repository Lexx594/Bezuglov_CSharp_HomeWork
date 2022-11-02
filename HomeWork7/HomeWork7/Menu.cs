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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();


            labelInfo.Text = "Домашняя работа №7\nСтудент Безуглов Алексей\nГруппа: GU_games_3169";
        
        }

        private void buttonPlayMulti_Click(object sender, EventArgs e)
        {

            Main main = new Main();
            main.ShowDialog();
            
        }

        private void buttonPlayNumber_Click(object sender, EventArgs e)
        {
            Number num = new Number();
            num.ShowDialog();
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
