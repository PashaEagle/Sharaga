using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        List<String> all;

        int new_size = 0;
        int size = 0;
        //glob[] all;
        int all_index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (size == 0)
                {
                    MessageBox.Show("You need to create list first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (all.Remove(textBox3.Text.ToString()) != true)
                {
                    MessageBox.Show("Cannot find element " + textBox3.Text.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                };
                all.Sort();

                DG2.Rows.Clear();
                DG2.Rows.Add(--size);

                for (int i = 0; i < size; ++i)
                {
                    DG2.Rows[i].Cells[0].Value = i + 1;
                    DG2.Rows[i].Cells[1].Value = all[i];
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Удалити значення";
            button2.Text = "Удалити індекс";
            button3.Text = "Відсортувати за прізвищем";
            button4.Text = "Очитстити";
            button5.Text = "Вихід";
            button6.Text = "Знайти";
            button7.Text = "Створити";
            button8.Text = "Додати";
            button9.Text = "Переглянути";
            label1.Text = "Структура даних";
            label2.Text = "Відсортована структура";
            label3.Text = "Створити новий список\n з             елементами";
            this.Text = "Динамічні масиви";
            DG1.AllowUserToAddRows = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int num;
                if (size == 0)
                {
                    MessageBox.Show("You need to create list first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                try
                {
                   num = Convert.ToInt32(textBox4.Text);
                }
                catch
                {
                    MessageBox.Show("You must enter digit ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (num > size)
                {
                    MessageBox.Show("Index is too big ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                };
                if (size > 0)
                {
                    all.RemoveAt(num - 1);
                    all.Sort();

                    DG2.Rows.Clear();
                    
                    if (size == 1) { --size; } else
                    DG2.Rows.Add(--size);

                    for (int i = 0; i < size; ++i)
                    {
                        DG2.Rows[i].Cells[0].Value = i + 1;
                        DG2.Rows[i].Cells[1].Value = all[i];
                    }
                    
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
         
        }


        private void button4_Click(object sender, EventArgs e)
        {
            DG1.Rows.Clear();
            DG2.Rows.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            try
            {
                size = Convert.ToInt32(textBox1.Text);
                all = new List<String>(size);

                DG1.Rows.Clear();
                DG1.Rows.Add(size);
                button9.Enabled = true;
                button8.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Number must be positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < size; ++i)
                {
                    all.Add( DG1.Rows[i].Cells[0].Value.ToString());               
                }

                all.Sort();
                DG2.Rows.Clear();
                DG2.Rows.Add(size);

                for (int i = 0; i < size; ++i)
                {
                    DG2.Rows[i].Cells[0].Value = i + 1;
                    DG2.Rows[i].Cells[1].Value = all[i];
                }


                button9.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button8.Enabled = true;

            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Did you fill all the fields ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Unable to show lsit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (size == 0)
                {
                    MessageBox.Show("You need to create list first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                all.Add(textBox2.Text.ToString());
                all.Sort();

                DG2.Rows.Clear();
                DG2.Rows.Add(++size);

                for (int i = 0; i < size; ++i)
                {
                    DG2.Rows[i].Cells[0].Value = i + 1;
                    DG2.Rows[i].Cells[1].Value = all[i];
                }

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

      
    }
}
