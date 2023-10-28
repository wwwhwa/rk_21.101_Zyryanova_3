using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _21._101_Zyryanova_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            // Получить введенное предложение
            string n = tb_input_n.Text;  //длина массива
            string a = tb_input_a.Text;    //нижняя граница
            string b = tb_input_b.Text;    //верхняя граница

            // Проверить, являются ли введенные значения целыми числами
            int aInt, bInt;
            if (!int.TryParse(a, out aInt) || !int.TryParse(b, out bInt))
            {
                MessageBox.Show("Введенные значения не являются целыми числами!");
                return;
            }

            try
            {
                int[] array = new int[int.Parse(n)];
                Random rnd = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(aInt, bInt + 1); // Добавить 1 к верхней границе, чтобы включить ее в диапазон
                }


                int[] sorted = new int[int.Parse(n)];
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        sorted[count] = array[i];
                        count++;
                    }
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        sorted[count] = array[i];
                        count++;
                    }
                }

                string output = "";
                for (int i = 0; i < array.Length; i++)
                {
                    output += sorted[i] + " ";
                }

                MessageBox.Show(output);
            }
            catch
            {
                MessageBox.Show("ошибочка вышла (длина массива не является целочисленным числом или положительным)");
            }
        }
    }
}
