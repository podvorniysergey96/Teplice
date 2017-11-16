using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int t = 10; // Температура
        int v = 70; // Вологість
        int w = 70; // Вода

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // Оголошення рамдому
            int a = rnd.Next(0, 10); // Отримання рамдомної перемінної для оновлення температури 





            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false && checkBox6.Checked == false)
            {
                textBox5.Text = "Датчики вимкнено";
            }
            else
            {
                textBox5.Text = "Датчики увімкнено";
            }

            if (a == 0) // Якщо а = 0, то температура оновлюється
            {
                int t1 = rnd.Next(10, 40); // отримання рамдомної температури в межах від 10 до 40     
                t = t1;
            }
            if (t >= 29) // Якщо температура >= 29, то температура  зменшується
            {
                t--;



                textBox6.Text = "Зменшення температури до норми 18-28 градусів";




            }
            else if (t <= 17) // Якщо температура <= 17, то температура  збільшується
            {
                t++;



                textBox6.Text = "Збільшення температури до норми 18-28 градусів";



            }
            else if (t >= 18 && t <= 28)
            {

                textBox6.Text = "Температура в межах норми 18-28 градусів";
            }
            if (v < 70)
            {
                t++;
                textBox3.Text = "Підвищення вологості до 70%";
            }
            else if (v > 70)
            {
                t--;
                textBox3.Text = "Зменшення вологості до 70%";
            }
            else if (v == 70)
            {

                textBox3.Text = "Оптимальна вологість 70%";
            }
            if (t >= 35 & t <= 40)
            {
                w = w - 3;
            }
            else if (t >= 30 & t <= 44)
            {
                w = w - 2;
            }
            else if (t >= 26 & t <= 29)
            {
                w = w - 1;
            }















            if (checkBox1.Checked == true)
            {
                textBox1.Text = t.ToString();

            }
            if (checkBox2.Checked == true)
            {
                textBox4.Text = t.ToString();

            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                label3.Text = "1-й та 2-й датчики вимкнено";
                textBox1.Text = " ";
                textBox4.Text = " ";
                textBox6.Text = "Датчики вимкнено";
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                label3.Text = "1-й датчик увімкнено";
                textBox4.Text = " ";
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                label3.Text = "2-й датчик увімкнено";
                textBox1.Text = " ";
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                label3.Text = "1-й та 2-й датчики увімкнено";

            }
            if (t == 18)
            {
                v = 65;
            }
            else if (t == 19)
            {
                v = 65;
            }
            else if (t == 20)
            {
                v = 66;
            }
            else if (t == 21)
            {
                v = 67;
            }
            else if (t == 22)
            {
                v = 68;
            }
            else if (t == 23)
            {
                v = 69;
            }
            else if (t == 24)
            {
                v = 69;
            }
            else if (t == 25)
            {
                v = 70;
            }
            else if (t == 26)
            {
                v = 71;
            }
            else if (t == 27)
            {
                v = 71;
            }
            else if (t == 28)
            {
                v = 72;
            }
            else if (t == 29)
            {
                v = 72;
            }
            else if (t == 30)
            {
                v = 73;
            }
            else if (t == 31)
            {
                v = 73;
            }
            else if (t == 32)
            {
                v = 74;
            }
            else if (t == 33)
            {
                v = 74;
            }
            else if (t == 34)
            {
                v = 75;
            }
            else if (t == 35)
            {
                v = 76;
            }
            else if (t == 36)
            {
                v = 77;
            }
            else if (t == 37)
            {
                v = 78;
            }
            else if (t == 38)
            {
                v = 78;
            }
            else if (t == 39)
            {
                v = 79;
            }
            else if (t == 40)
            {
                v = 80;
            }
            else if (t == 17)
            {
                v = 64;
            }
            else if (t == 16)
            {
                v = 62;
            }
            else if (t == 15)
            {
                v = 61;
            }
            else if (t == 14)
            {
                v = 60;
            }
            else if (t == 13)
            {
                v = 58;
            }
            else if (t == 12)
            {
                v = 55;
            }
            else if (t == 11)
            {
                v = 51;
            }
            else if (t == 10)
            {
                v = 48;
            }


            if (checkBox3.Checked == true)
            {
                textBox2.Text = v.ToString();

            }
            if (checkBox4.Checked == true)
            {
                textBox7.Text = v.ToString();

            }
            if (checkBox3.Checked == false && checkBox4.Checked == false)
            {
                label4.Text = "1-й та 2-й датчики вимкнено";
                textBox2.Text = " ";
                textBox7.Text = " ";
                textBox3.Text = "Датчики вимкнено";
            }
            if (checkBox3.Checked == true && checkBox4.Checked == false)
            {
                label4.Text = "1-й датчик увімкнено";
                textBox7.Text = " ";
            }
            if (checkBox3.Checked == false && checkBox4.Checked == true)
            {
                label4.Text = "2-й датчик увімкнено";
                textBox2.Text = " ";
            }
            if (checkBox3.Checked == true && checkBox4.Checked == true)
            {
                label4.Text = "1-й та 2-й датчики увімкнено";

            }















            if (w == 90)
            {
                textBox8.Text = "Оптимальний рівень води";
            }
            if (w < 90)
            {
                w++;
                textBox8.Text = "Додавання води";
            }

            if (checkBox5.Checked == true)
            {
                textBox9.Text = w.ToString();

            }
            if (checkBox6.Checked == true)
            {
                textBox10.Text = w.ToString();

            }
            if (checkBox5.Checked == false && checkBox6.Checked == false)
            {
                label5.Text = "1-й та 2-й датчики вимкнено";
                textBox9.Text = " ";
                textBox10.Text = " ";
                textBox8.Text = "Датчики вимкнено";
            }
            if (checkBox5.Checked == true && checkBox6.Checked == false)
            {
                label5.Text = "1-й датчик увімкнено";
                textBox10.Text = " ";
            }
            if (checkBox5.Checked == false && checkBox6.Checked == true)
            {
                label5.Text = "2-й датчик увімкнено";
                textBox9.Text = " ";
            }
            if (checkBox5.Checked == true && checkBox6.Checked == true)
            {
                label5.Text = "1-й та 2-й датчики увімкнено";

            }








        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;
                checkBox1.Text = "Вкл.";
            }
                
            else
            {
                textBox1.Visible = false;
                checkBox1.Text = "Викл.";

            }



        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)

            {
                textBox2.Visible = true;
                checkBox3.Text = "Вкл.";
            }
            else
            {
                textBox2.Visible = false;
                checkBox3.Text = "Викл.";

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)

            {
                textBox9.Visible = true;
                checkBox5.Text = "Вкл.";
            }
            else
            {
                textBox9.Visible = false;
                checkBox5.Text = "Викл.";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)

            {
                textBox4.Visible = true;
                checkBox2.Text = "Вкл.";
            }
            else
            {
                textBox4.Visible = false;
                checkBox2.Text = "Викл.";

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)

            {
                textBox7.Visible = true;
                checkBox4.Text = "Вкл.";
            }
            else
            {
                textBox7.Visible = false;
                checkBox4.Text = "Викл.";

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)

            {
                textBox10.Visible = true;
                checkBox6.Text = "Вкл.";
            }
            else
            {
                textBox10.Visible = false;
                checkBox6.Text = "Викл.";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
