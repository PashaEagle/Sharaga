using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace asd1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Text = "Вихід";
            button4.Text = "Очистити";
            button9.Text = "Відсортувати";
            button1.Text = "Згенерувати нові числа";
            button2.Text = "Створити";
            label1.Text = "Введіть к-сть елементів";
            this.Text = "Порозрядне сортування";
            DG1.AllowUserToAddRows = false;
            DG2.AllowUserToAddRows = false;
            DG1.ReadOnly= true;
            DG2.ReadOnly = true;
        }

        List<int> all;
        int size = 0;
 
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DG1.Rows.Clear();
            DG2.Rows.Clear();
        }
       
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
               all = new List<int>(size);
               for (int i = 0; i < size; ++i)
                {
                    all.Add(Convert.ToInt32(DG1.Rows[i].Cells[0].Value));              
                }

                DG2.Rows.Clear();
                DG2.Rows.Add(size);

                //sort
                int range = 10;
                int length = 1;
                for (int i = 0; i < size; ++i)
                {
                    int k = 1;
                    int t = Convert.ToInt32(DG1.Rows[i].Cells[0].Value);
                    while (Math.Abs(t) > 9)
                    {
                        t /= 10;
                        ++k;
                    }
                    if (k > length) length = k;
                }


                ArrayList[] lists = new ArrayList[range];
                ArrayList[] listsNegative = new ArrayList[range];
                for (int i = 0; i < range; ++i)
                    lists[i] = new ArrayList();
                for (int i = 0; i < range; ++i)
                    listsNegative[i] = new ArrayList();

                for (int step = 0; step < length; ++step)
                {
                    //Sorting to lists
                    for (int i = 0; i < size; ++i)
                    {
                        int temp = (Math.Abs(all[i]) % (int)Math.Pow(range, step + 1)) /
                                                      (int)Math.Pow(range, step);
                        if (all[i] >= 0)
                            lists[temp].Add(all[i]);
                        else
                            listsNegative[temp].Add(all[i]);
                    }
                    //Building
                    int k = 0;
                    for (int i = range - 1; i >= 0; --i)
                    {
                        for (int j = 0; j < listsNegative[i].Count; ++j)
                        {
                            all[k++] = (int)listsNegative[i][j];
                        }
                    }
                    for (int i = 0; i < range; ++i)
                        listsNegative[i].Clear();
                    //Building2
                    for (int i = 0; i < range; ++i)
                    {
                        for (int j = 0; j < lists[i].Count; ++j)
                        {
                            all[k++] = (int)lists[i][j];
                        }
                    }
                    for (int i = 0; i < range; ++i)
                        lists[i].Clear();
                }



                for (int i = 0; i < size; ++i)
                {
                    DG2.Rows[i].Cells[0].Value = all[i];
                }

            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Did you fill all the fields ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DG1.Rows.Clear();
                DG2.Rows.Clear();
                size = Convert.ToInt32(textBox1.Text);
                all = new List<int>(size);
                Random rd = new Random();
                DG1.Rows.Add(size);
                for (int i = 0; i < size; ++i)
                {
                    all.Add(rd.Next(-200, 200));
                    DG1.Rows[i].Cells[0].Value = all[i];
                }
            }
            catch { MessageBox.Show("Error"); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                size = Convert.ToInt32(textBox1.Text);
                all = new List<int>(size);
                Random rd = new Random();
                DG1.Rows.Clear();
                DG1.Rows.Add(size);
            }
            catch { MessageBox.Show("Type correct number"); }
           

        }
    }
}
/* робочий код в консолі онлі для додатніхpublic class RadixSort
    {
        public static void sorting(int[] arr, int range, int length)
        {
            List<List<int>> lists = new List<List<int>>(range);
            for (int i = 0; i < range; ++i)
                lists.Add(new List<int>());
            for (int step = 0; step < length; ++step)
            {
                for (int i = 0; i < arr.Length; ++i)
                {
                    int temp = (arr[i] % (int)Math.Pow(range, step + 1)) / (int)Math.Pow(range, step);
                    lists[temp].Add(arr[i]);
                }
                int k = 0;
                for (int i = 0; i < range; ++i)
                {
                    for (int j = 0; j < lists[i].Count; ++j)
                    {
                        arr[k++] = (int)lists[i][j];
                    }
                }
                for (int i = 0; i < range; ++i)
                    lists[i].Clear();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(0, 200);
            }

            System.Console.WriteLine("The array before sorting:");
            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }

            RadixSort.sorting(arr, 10, 3);
            System.Console.WriteLine("\n\nThe array after sorting:");

            foreach (double x in arr)
            {
                System.Console.Write(x + " ");
            }

            System.Console.WriteLine("\n\nPress the <Enter> key");
            System.Console.ReadLine();
        }
    }*/
