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
    /*1*/   string name = textBox1.Text;//заполнение переменной name данными из текстбокса

            int temp = 0;
            string res="";
            string text="";
            try
            {
    /*2*/       if (string.IsNullOrWhiteSpace(textBox1.Text))// условие наличие пустот или пробелов
                {
    /*3*/            throw new Exception();//ошибка
    /*4*/       }//завершение условия
    /*5*/       string[] mystring = name.Split(' ');//запись в массив слов из строки
    /*6*/       for (int i = 0; i < mystring.Length; i++)//начало цикла, условие i<mystring.Length (количество элементов в массиве)
                {
    /*7*/           if (mystring[i].Length == 3)//начало условия, mystring[i].Length==3
                    {
    /*8*/               res = simbol(ref temp, mystring, i); //вызов метода
    /*9*/           }//конец условия                                             
    /*10*/      }//конец цикла                                                 
    /*11*/      for (int i = 0; i < mystring.Length; i++)//начало цикла, условие i < mystring.Length (колличество элементов в массиве)
                {
    /*12*/          text+=mystring[i] + " ";//запись элементов в строку через пробел
    /*13*/      }//конец цикла
    /*14*/      label5.Text = text;//вывод результата в label
            }
            catch (Exception) 
            {
                DialogResult result = MessageBox.Show("Пустое значение и пробелы недопустимы! " +
    /*15*/          "Попробуйте снова!", "Ошибка", MessageBoxButtons.YesNo);//вывод ошибки на экран
    /*16*/      if (result == DialogResult.No)//условие нажатие на кнопку No
                {
    /*17*/          Application.Exit();//завершение приложения
    /*18*/      }//конец условия
    /*19*/      else//условие нажатия на кнопку Yes
                {
    /*20*/          Application.Restart();//повторные запуск приложения
    /*21*/      }//конец условия
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
        private static string simbol(ref int temp, string[] mystring, int i)
        {
            int resultat;
    /*22*/  for (int l = 0; l < mystring[i].Length; l++)//начало цикла, условие  
            {
    /*23*/      temp += (int)(mystring[i])[l];//преобразование символа в его код и суммирование результатов
    /*24*/  }//конец цикла
    /*25*/  resultat = (temp / 3);//деление результата на три, для нахождение среднего арифметического 
    /*26*/  mystring[i] = Convert.ToString((char)resultat);//конвертация кода в символ
    /*27*/  return mystring[i];//возвращение резулт
        }
    }
}
