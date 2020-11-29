using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox1.Text); // Парсим значение из текстового поля textBox1.
            string[] sNums = textBox2.Text.Split(',',' '); // Разбиваем текст из текстового поля textBox2, на массив строк, разделителем является , [запятая без пробелов].
            if (c > sNums.Length)
            { // Если кол-во элементов введенных в textBox1 больше элементов в массиве, то выводим сообщение.
                MessageBox.Show("Длина массива не соответствует введенному!");
                return;
            }
            int[] nums = new int[c]; // объявляем новый массив с количеством элементов = c.
            for (int i = 0; i < c; i++)
                nums[i] = int.Parse(sNums[i]); // проходимся по каждому элементу массива sNums и заносим значение в соответствующий элемент массива nums, перед этим его распарсив.
                                               // Далее по тексту.
                                               //сортировка введенного массива
            Array.Sort(nums);
            int max = nums.Max(), min = nums.Min();
            textBox5.Text = max.ToString();
            textBox4.Text = min.ToString();
            string mas_digit=default,
                   all_unpaired_elems=default,
                   sum_all_elems=default,
                   averageArifmethicValue="";
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]%2 != 0)
                {
                    all_unpaired_elems += nums[i].ToString() + " ";
                }
                sum += nums[i];
                mas_digit += Convert.ToString( nums[i].ToString())+" ";
            }
            textBox6.Text = averageArifmethicValue = (sum / nums.Length).ToString();
            sum_all_elems = sum.ToString();
            textBox7.Text = sum_all_elems.ToString();
            textBox8.Text = all_unpaired_elems.ToString();
                            //вывод в TextBox3 отсортированного массива

            for (int i = 0; i < nums.Length; i++)
            {
                textBox3.Text = mas_digit.ToString() ;

            }
        }
    }
}
