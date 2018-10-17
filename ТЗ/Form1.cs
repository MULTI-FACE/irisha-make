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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string word;
            int temp = 0;
            string resultat="";
            string text="";
            int kod = 0;
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
                        word = mystring[i];
                        for (int l =0; l<word.Length; l++)
                        {
                            temp += (int)word[l];
                        }
                        resultat += Convert.ToString((temp / 3));
                        kod = Convert.ToInt32(resultat);
                        mystring[i] = Convert.ToString((char)kod);
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
    }
}
