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
                        resultat = simbol(ref temp, mystring, i); 
                    }                                             
                }                                                 
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
        /// <summary>
        /// Этот метод преобразует значение символа в цифровой код, после находит среднее арифметическое этих кодов и результат преобразует 
        /// обрратно в символ.
        /// </summary>
        /// <param name="temp">Переменноя для записи суммы всех кодов слова</param>
        /// <param name="mystring">Массив слов, которые вводил пользователь</param>
        /// <param name="i">Переменная, значение которой определяет, какой элемент массива будет обработан в методе</param>
        /// <returns>Символ после работы метода</returns>
        private static int simbol(ref int temp, string[] mystring, int i)
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
