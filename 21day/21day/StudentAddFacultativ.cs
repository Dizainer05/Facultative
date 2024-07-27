using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21day
{
    public partial class StudentAddFacultativ : Form
    {
        public StudentAddFacultativ()
        {
            InitializeComponent();
        }

        private void StudentAddFacultativ_Load(object sender, EventArgs e)
        {
            using (var context = new Datab())
            {
                var elemt1 = context.Students.Where(e => e.InFacultativ == false);
                foreach (var elemt in elemt1)
                {
                    comboBox1.Items.Add(elemt.LastName);
                }
                var elemt2 = context.Facultative.ToList();
                foreach (var facultativ in elemt2)
                {
                    comboBox2.Items.Add(facultativ.Title);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stdName = comboBox1.Text, facName = comboBox2.Text;
            int workhours = Convert.ToInt32(textBox1.Text);
            if (stdName.Length == 0 || facName.Length == 0 || workhours == 0)
            {
                throw new Exception("Заполните все поля.");
            }
            else
            {
                using (var context = new Datab()) // Открывает подключение
                {
                    try
                    {
                        var facultative = context.Facultative.FirstOrDefault(f => f.Title == facName);
                        var std = context.Students.FirstOrDefault(std => std.LastName == stdName);

                        if (facultative == null)
                        {
                            MessageBox.Show("Факультатив не найден.", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }

                        if (std == null)
                        {
                            MessageBox.Show("Студент не найден.", "Ошибка", MessageBoxButtons.OK);
                            return;
                        }

                        FacultativeRecord facultativeRecord = new FacultativeRecord(std.StudentId, facultative.FacultativeId, DateTime.Now, workhours);
                        std.InFacultativ = true;
                        context.FacultativeRecord.Add(facultativeRecord);
                        MessageBox.Show("Данные сохранены.", "Успешно", MessageBoxButtons.OK);
                        context.SaveChanges(); // Сохраняем изменения
                    }
                    catch (DbUpdateException ex)
                    {
                        MessageBox.Show($"Произошла ошибка при сохранении изменений: {ex.Message}\n{ex.InnerException?.Message}", "Ошибка", MessageBoxButtons.OK);
                    }


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Количество отработанных часов";
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
