using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Numerics;


namespace asd1
{
    public partial class Form1 : Form
    {
        /*
        char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                        'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };
                                                        */

        char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                         'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                         'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                         'Э', 'Ю', 'Я', 'І', ' ', '1', '2', '3', '4', '5', '6', '7',
                                         '8', '9', '0', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и',
                                         'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
                                         'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ы', 'ъ',
                                         'э', 'ю', 'я', 'і', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                         'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
                                         'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'r', 'f', 'g', 'h', 'i',
                                         'f', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v',
                                         'w', 'x', 'y', 'z'

        };

        //Encode
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox1.Text);
                long q = Convert.ToInt64(textBox2.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string s = "";

                    StreamReader sr = new StreamReader("in.txt");

                    while (!sr.EndOfStream)
                    {
                        s += sr.ReadLine();
                    }

                    sr.Close();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = RSA_Endoce(s, e_, n);

                    StreamWriter sw = new StreamWriter("out1.txt");
                    foreach (string item in result)
                        sw.WriteLine(item);
                    sw.Close();

                    textBox5.Text = d.ToString();
                    textBox6.Text = n.ToString();

                    textBox3.Text = d.ToString();
                    textBox4.Text = n.ToString();


                    button2.Enabled = true;
                    button4.Enabled = true;
                    button6.Enabled = true;
                }
                else
                    MessageBox.Show("p или q - не прості числа!");
            }
            else
                MessageBox.Show("Введіть p и q!");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            label1.Text = "Для зашифрування введіть два\n    простих числа і текст ";
            label7.Text = "Для розшифрування введіть\n     зашифрований текст і \n        секретний  ключ";
        }

 
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("out1.txt");

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("out1.txt");

        }
        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        //зашифровать
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
                bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        //расшифровать
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        //вычисление параметра e
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("in.txt");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Process.Start("out2.txt");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Process.Start("out1.txt");
        }

        //Decode
        private void button6_Click(object sender, EventArgs e)
        {

            if ((textBox3.Text.Length > 0) && (textBox4.Text.Length > 0))
            {
                long d = Convert.ToInt64(textBox3.Text);
                long n = Convert.ToInt64(textBox4.Text);

                List<string> input = new List<string>();

                StreamReader sr = new StreamReader("out1.txt");

                while (!sr.EndOfStream)
                {
                    input.Add(sr.ReadLine());
                }

                sr.Close();

                string result = RSA_Dedoce(input, d, n);

                StreamWriter sw = new StreamWriter("out2.txt");
                sw.WriteLine(result);
                sw.Close();

                MessageBox.Show("Успех!");

                button5.Enabled = true;

            }
            else
                MessageBox.Show("Введіть секретний ключ!");
        }
    }
}
