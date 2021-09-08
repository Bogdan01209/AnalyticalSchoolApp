using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace AnalyticalSchoolApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        FormHelp f2;
        private FormOpenFile f3;

        public object Writer { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new FormHelp();
            f2.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите расположение ");
                return;
            }
            File.WriteAllText(textBox7.Text, textBox8.Text + textBox9.Text, Encoding.Default);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            f3 = new FormOpenFile();
            f3.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите расположение");
                return;
            }
            File.AppendAllText(textBox7.Text, textBox8.Text + textBox9.Text, Encoding.Default);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            decimal x = (numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value + numericUpDown10.Value + numericUpDown11.Value + numericUpDown12.Value + numericUpDown13.Value + numericUpDown14.Value + numericUpDown15.Value + numericUpDown16.Value + numericUpDown17.Value + numericUpDown18.Value + numericUpDown19.Value + numericUpDown20.Value) / numericUpDown21.Value;
            if (comboBox1.Text == "Номер класса")
            {
                MessageBox.Show("выберете номер класса");
                return;
            }
            if (comboBox2.Text == "Придмет")
            {
                MessageBox.Show("выберете придмет");
                return;
            }
            if (comboBox4.Text == "Буква класса")
            {
                MessageBox.Show("выберете букву класса");
                return;
            }
            if (comboBox5.Text == "Четверть")
            {
                MessageBox.Show("выберете четверть");
                return;
            }
            if (numericUpDown1.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown2.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown3.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown4.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown5.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown6.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown7.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown8.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown9.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown10.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown11.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown12.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown13.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown14.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown15.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown16.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown17.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown18.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown19.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }
            if (numericUpDown20.Value == 1)
            {
                MessageBox.Show("1 выберете другое");
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("заполнените Фамилию учителя");
                return;
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("заполнените Имя учителя ");
                return;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("заполнените Отчество учителя");
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("заполнените Фамилию учиника");
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("заполнените Имя учиника");
                return;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("заполнените Отчество учиника");
                return;
            }

            textBox8.AppendText(comboBox5.Text + " Учитель: " + textBox4.Text + " " + textBox5.Text + " " + textBox6.Text + " " + " придмет: " + comboBox2.Text + " класс: " + comboBox1.Text + comboBox4.Text + " Ученик: " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text);
            textBox9.AppendText(" Оценки: " + numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown7.Value + numericUpDown8.Value + numericUpDown9.Value + numericUpDown10.Value + numericUpDown11.Value + numericUpDown12.Value + numericUpDown13.Value + numericUpDown14.Value + numericUpDown15.Value + numericUpDown16.Value + numericUpDown17.Value + numericUpDown18.Value + numericUpDown19.Value + numericUpDown20.Value + " cредний бал: " + x);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Введите расположение");
                return;
            }
            File.AppendAllText(textBox7.Text, textBox8.Text + textBox9.Text, Encoding.Default);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}



