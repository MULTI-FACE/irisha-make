using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТЗ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            int temp = 0;
            int resultat=0;
            string text="";
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    throw new Exception();
                }
                string[] mystring = name.Split(' ');
                for (int i = 0; i < mystring.Length; i++)
                {
                    if (mystring[i].Length == 3)
                    {
                        resultat = Simbol(ref temp, mystring, i); // Simbol - метод, который получает код символов, их среднее арифметическое и преобразует обратно
                    }                                             // Переменные: temp - входная переменная, сумма всех кодов слова, mystring - входные данные, 
                }                                                 // массив из слов, i - входная переменная, отвечающая за  конкретный элемент массива.
                for (int i = 0; i < mystring.Length; i++)
                {
                    text+=mystring[i] + " ";
                }
                label5.Text = text;
            }
            catch (Exception) 
            {
                DialogResult result = MessageBox.Show("Пустое значение и пробелы недопустимы! Попробуйте снова!", "Ошибка", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                { Application.Restart(); }
            }
        }

        private static int Simbol(ref int temp, string[] mystring, int i)
        {
            int resultat;
            for (int l = 0; l < mystring[i].Length; l++)
            {
                temp += (int)(mystring[i])[l];
            }
            resultat = (temp / 3);
            mystring[i] = Convert.ToString((char)resultat);
            return resultat;
        }
    }
}
