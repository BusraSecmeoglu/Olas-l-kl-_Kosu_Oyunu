using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Point old1;
        Point old2;
        int count1, count2, possibility1 = 0, possibility2 = 0, sub;
        public Form1()
        {
            InitializeComponent();
            old1 = pictureBox1.Location;
            old2 = pictureBox2.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("birinci koşucunun kazanma olasılığı:" + possibility1);
            MessageBox.Show("ikinci koşucunun kazanma olasılığı:" + possibility2);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random number = new Random();
            int jump = number.Next(0, 100);
            pictureBox1.Left += jump;
            int jump2 = number.Next(0, 100);
            pictureBox2.Left += jump2;

            if (pictureBox1.Right >= panel1.Left || pictureBox2.Right >= panel1.Left)
            {
                timer1.Stop();
                if (pictureBox1.Right > pictureBox2.Right)
                {
                    MessageBox.Show("1.kişi kazandı.");
                    count1++;
                }

                else
                {
                    MessageBox.Show("2.kişi kazandı.");
                    count2++;
                }

                pictureBox1.Location = old1;
                pictureBox2.Location = old2;
                sub = count1 + count2;
                possibility1 = (100 * count1) / sub;
                possibility2 = (100 * count2) / sub;
            }

        }

    }
}
