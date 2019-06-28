using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notifyicon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //кнопка вкл иконки
        private void Button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true; //показывает иконку в панели задач
        }
        //кнопка выкл иконки
        private void Button2_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false; //скрывает иконку из панели задач
        }

        //выдача уведомления на 5 сек
        private void Button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "ВНИМАНИЕ";   //заголовок уведомления
            notifyIcon1.BalloonTipText = "АДМИН МУДАК"; //текст уведомления

            notifyIcon1.ShowBalloonTip(5000);           /*время выдачи уведомления 
                                                          в м.сек (1сек=1000м.сек)*/
        }


        //сообщение по клику на уведомление диалоговое окно
        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("НУ ПОЛНЫЙ МУДАК"); // выдача диалога с кнопкой ОК и текстом сообщения
        }
        
        //обработчик нажатий на кнопки мыши по иконке
        private void NotifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
             if (e.Button == MouseButtons.Left) //для левой кнопки
                {
                  MessageBox.Show("левая кнопка");
            }
            /*else if (e.Button == MouseButtons.Right) //для правой кнопки
            {
                MessageBox.Show("правая кнопка");
            }*/
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "ВНИМАНИЕ";   //заголовок уведомления
            notifyIcon1.BalloonTipText = "АДМИН МУДАК"; //текст уведомления

            notifyIcon1.ShowBalloonTip(5000);           /*время выдачи уведомления 
                                                          в м.сек (1сек=1000м.сек)*/
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("strip menu");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
