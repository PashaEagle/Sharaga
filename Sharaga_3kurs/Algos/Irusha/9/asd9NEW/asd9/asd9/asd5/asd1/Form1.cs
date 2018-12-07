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

        public struct glob
        {
            public string name;
            public string number;
        };

        int new_size = 0;
        int size = 0;
        glob[] all;
        int all_index = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;

            int i = 0;
            all_index = 0;

            while (DG1.Rows[i].Cells[0].Value != null)
            {
                string St0 = Convert.ToString(DG1.Rows[i].Cells[0].Value);
                string St1 = Convert.ToString(DG1.Rows[i].Cells[1].Value);

                all[all_index].name = string.Copy(St0);
                all[all_index].number = string.Copy(St1);

                all_index++;
                i++;
            }

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
                {
                    foreach (glob s in all)
                    {
                        try
                        {
                            writer.Write(s.name);
                            writer.Write(s.number);
                        }
                        catch { break; }
                    }
                }
            }
            catch
            {
                MessageBox.Show("File is not saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("File is saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Записати в файл";
            button2.Text = "Прочитати з файлу";
            button3.Text = "Відсортувати за прізвищем";
            button4.Text = "Очитстити";
            button5.Text = "Вихід";
            button6.Text = "Знайти";
            button7.Text = "Створити";
            button8.Text = "Додати";
            button9.Text = "Переглянути";
            label1.Text = "Структура даних";
            label2.Text = "Відсортована структура";
            label3.Text = "Введіть елементи, які хочете додати";
            this.Text = "Динамічні масиви";
            DG1.AllowUserToAddRows = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            if (openFileDialog1.FileName == null) return;

            string filename = openFileDialog1.FileName;

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                    {
                        all[i].name = reader.ReadString();
                        all[i].number = reader.ReadString();

                        DG1.Rows.Add();
                        DG1.Rows[i].Cells[0].Value = all[i].name;
                        DG1.Rows[i].Cells[1].Value = all[i].number;

                        ++i;
                    }
                }
                all_index = i;
                MessageBox.Show("File is opened", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show("Incorrect format of file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            glob x = new glob();
            int amount = DG1.RowCount - 1;
            for (int i = 0; i < amount; ++i)
            {
                DG2.Rows.Add();
            }

            for (int i = 1; i < amount; i++)
            {
                x = all[i];
                int j = i;
                while (j > 0 && string.Compare(x.name, all[j - 1].name) < 0)
                {
                    all[j] = all[j - 1];
                    j--;
                }
                all[j] = x;
            }

            for (int i = 0; i < amount; ++i)
            {
                DG2.Rows[i].Cells[0].Value = all[i].name;
                DG2.Rows[i].Cells[1].Value = all[i].number;
            }
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
                all = new glob[size];

                DG1.Rows.Clear();
                DG1.Rows.Add(size);
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
                    all[i].name = DG1.Rows[i].Cells[0].Value.ToString();
                    all[i].number = DG1.Rows[i].Cells[1].Value.ToString();                
                }

                DG2.Rows.Clear();
                DG2.Rows.Add(size);

                for (int i = 0; i < size; ++i)
                {
                    DG2.Rows[i].Cells[0].Value = all[i].name;
                    DG2.Rows[i].Cells[1].Value = all[i].number;
                }

            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Did you fill all the fields ?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (size == 0)
                {
                    MessageBox.Show("You need to create array first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                new_size = Convert.ToInt32(textBox2.Text);
                if (new_size == 0)
                {
                    MessageBox.Show("Number must be negative or positive but can not be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (new_size > 0)
                {
                    Array.Resize(ref all, all.Length + new_size);
                    DG1.Rows.Add(new_size);
                    size = all.Length;
                }
                else if (new_size < 0 && all.Length + new_size >= 0)
                {
                    Array.Resize(ref all, all.Length + new_size);
                    DG1.Rows.Clear();
                    size = all.Length;
                    for (int i = 0; i < size; ++i)
                    {
                        DG1.Rows.Add();
                        DG1.Rows[i].Cells[0].Value = all[i].name;
                        DG1.Rows[i].Cells[1].Value = all[i].number;
                    }
                }
                else if (new_size < 0 && all.Length + new_size < 0)
                {
                    MessageBox.Show("Amount of elements can not be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /* private void button6_Click(object sender, EventArgs e)
         {
             DG3.Rows.Clear();
             int n = DG2.RowCount - 1;
             string t = textBox1.Text.ToString();
             bool success = false;
             int l = 0, r = n, s;
             while (l < r)
             {
                 s = (l + r) / 2;
                 if (all[s].name != t)
                 {
                     if (string.Compare(t, all[s].name) > 0)
                     l = s + 1;
                     else r = s;
                 }
                 else
                 {
                     success = true;
                     int ind = 0;
                     DG3.Rows.Add();
                     DG3.Rows[ind].Cells[0].Value = all[s].name;
                     DG3.Rows[ind++].Cells[1].Value = all[s].number;
                     int i = s + 1;
                     while (i > 0 && i < n && all[i].name == t)
                     {
                         DG3.Rows.Add();
                         DG3.Rows[ind].Cells[0].Value = all[i].name;
                         DG3.Rows[ind].Cells[1].Value = all[i].number;
                         ++ind;
                         ++i;
                     }
                     i = s - 1;
                     while (i < n && i > 0 && all[i].name == t )
                     {
                         DG3.Rows.Add();
                         DG3.Rows[ind].Cells[0].Value = all[i].name;
                         DG3.Rows[ind].Cells[1].Value = all[i].number;
                         --ind;
                         --i;
                     }

                     break;
                 }
             }
             if (!success)
             {
                 MessageBox.Show("Такого прізвища немає", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 DG3.Rows.Clear();
             }

         }*/
    }
}
