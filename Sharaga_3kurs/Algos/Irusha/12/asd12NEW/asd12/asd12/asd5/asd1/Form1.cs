﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace asd1
{
    public partial class Form1 : Form
    {
        public int getPriority(string x)
        {
            if (x == "+" || x == "-") return 2;
            if (x == "*" || x == "/") return 3;
            else return 1;      //Если это "("
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Text = "Вихід";
            button4.Text = "Очистити";
            button7.Text = "Інтерпретувати";
            button1.Text = "Обчислити";
            label1.Text = "Результат обчисленння";
            label3.Text = "Введіть математичний вираз";
            label4.Text = "Вираз в зворотному \nпольському записі ";
            this.Text = "Інтерпретація математичних виразів";
        }

 
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text.ToString();
            //Трепа зробити інтерпретацію будь якого виразу в форму зворотного польського запису, будь то цифри,
            //будь то букви. крім того, вивести результат обчислення який я ввела, навіть з буквами, тобто букви 
            //заміняти цифрами, а=1, b=2, c=3, d=4 etc
            // дед сказав шо можна зробити масив з букв і записати в них значення, а потом брати те яке нужне.

            //Вводити цифри или букви малеьнькі 

            /*Алго очень простой, вот лучшее объяснение
                Рассматриваем поочередно каждый символ:
                    1. Если этот символ - число (или переменная), то просто помещаем его в выходную строку.
                    2. Если символ - знак операции (+, -, *, / ), то проверяем приоритет данной операции. Операции умножения и деления имеют наивысший приоритет (допустим он равен 3). Операции сложения и вычитания имеют меньший приоритет (равен 2). Наименьший приоритет (равен 1) имеет открывающая скобка.
                    Получив один из этих символов, мы должны проверить стек: 
                        а) Если стек все еще пуст, или находящиеся в нем символы (а находится в нем могут только знаки операций и открывающая скобка) имеют меньший приоритет, чем приоритет текущего символа, то помещаем текущий символ в стек.
                        б) Если символ, находящийся на вершине стека имеет приоритет, больший или равный приоритету текущего символа, то извлекаем символы из стека в выходную строку до тех пор, пока выполняется это условие; затем переходим к пункту а).
                    3. Если текущий символ - открывающая скобка, то помещаем ее в стек.
                    4. Если текущий символ - закрывающая скобка, то извлекаем символы из стека в выходную строку до тех пор, пока не встретим в стеке открывающую скобку (т.е. символ с приоритетом, равным 1), которую следует просто уничтожить. Закрывающая скобка также уничтожается.

                Конец. Если вся входная строка разобрана, а в стеке еще остаются знаки операций, извлекаем их из стека в выходную строку.
            */

            string ans = ""; //Это выходная строка
            int priority = 0;
            Stack<string> stack = new Stack<string>(); //Тут стек
            string tt;
            for (int i = 0; i < t.Length; ++i) //Смотрим по каждому символу
            {
                tt = t[i].ToString();
                if (tt.Equals("(")) { stack.Push(tt); continue; }   //Если это "(" то просто добавляем в стек и выходим
                else if (tt.Equals("+")) priority = 2;              //Если нет - то определяем приоритет
                else if (tt.Equals("-")) priority = 2;
                else if (tt.Equals("*")) priority = 3;
                else if (tt.Equals("/")) priority = 3;
                else if (tt.Equals(")"))                            //Если это закрывающая скобка
                {
                    while (!stack.Peek().ToString().Equals("("))    // то вынимаем все из стека в выходную строку всё до Открывающей скобки
                    {
                        ans += stack.Pop();
                    }
                    stack.Pop();                                    //И удаляем саму скобку "("
                    continue;                                       //Опять выходим, идем за следующим символом
                }
                else                                                //Ну а если мы дошли до сюда значит это ни скобка и не операция
                                                                    //а просто буква или цифра, добавляем в строку и выходим
                {
                    ans += tt;
                    continue;
                }

                if (stack.Count == 0 || priority > getPriority(stack.Peek())) { stack.Push(tt); } //До сюда мы дойдем только если перед этим ставили приоритет и не выходили, то есть если это операция +,-,*,/
                else
                {
                    while (stack.Count != 0 && priority <= getPriority(stack.Peek())) //см.пункт "2"
                    {
                        ans += stack.Pop();
                    }
                    stack.Push(tt.ToString());
                }

            }


            //см.пункт "Конец", тут просто довынимаем все оставшееся из стека
            while (stack.Count > 0)
            {
                ans += stack.Pop();
            }

            textBox2.Text = ans; //И выводим результат

            }

        private void button1_Click(object sender, EventArgs e)
        {
            //А тут вообще все просто, алгоритм который считает результат из польской записи.
            /*
                1. Если очередной символ входной строки - число, то кладем его в стек. 
                2. Если очередной символ - знак операции, то извлекаем из стека два верхних числа, используем их в качестве операндов для этой операции, затем кладем результат обратно в стек. 
                Когда вся входная строка будет разобрана в стеке должно остаться одно число, которое и будет результатом данного выражения.
            */
            if (textBox2.Text == "") { MessageBox.Show("Error"); return; }
            string str = textBox2.Text; //Записали в str выражение в виде польской записи
            string tt;
            Stack<int> stack = new Stack<int>();    //Стак чисел
            for (int i = 0; i < str.Length; ++i)    //По каждому символу
            {
                tt = str[i].ToString();
                if (tt.Equals("+"))                 //Если это + то вынимаем два верхних числа из стека, плюсуем и пишем результат обратно в стек
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a + b);
                }
                else if (tt.Equals("-"))            //Если это - то вынимаем два верхних числа из стека, минусуем и пишем результат обратно в стек
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b - a);
                }
                else if (tt.Equals("*"))            //То же самое
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a * b);
                }
                else if (tt.Equals("/"))            //Тоже самое
                {
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(b / a);
                }
                else                                //А если мы дошли до сюда значит у нас число или буква
                {
                    try                             
                    {
                        int a = Convert.ToInt32(tt); //Если try не "поломается" то это число
                        stack.Push(a);               //Просто запишем
                    }
                    catch (Exception)
                    {
                        int a = Convert.ToInt32(str[i]) - 96;   //Если поломается то мы попали сюда и это буква, отнимем от кода 96, получим число (а = 1, b = 2..)
                        stack.Push(a);                  //И тоже запишем
                    }

                }
            }
            textBox3.Text = stack.Pop().ToString(); //В самом конце в стеке останется одно число - результат выражения, выводим
        }
    }
}
