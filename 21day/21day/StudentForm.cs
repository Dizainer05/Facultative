using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _21day
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Имя";
                return;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Фамилия";
                return;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Отчество";
                return;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Группа";
                return;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Телефон";
                return;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            FilterStudents();
            //if (textBox6.Text == "")
            //{
            //    textBox6.Text = "Фильтр по имени";
            //    return;
            //}
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.SelectAll();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            FilterStudents();
            //if (textBox7.Text == "")
            //{
            //    textBox7.Text = "Фильтр по группе";
            //    return;
            //}
        }

        private void FilterStudents()
        {
            using (var context = new Datab())
            {
                string nameFilter = textBox6.Text;
                string groupFilter = textBox7.Text;

                // Получаем значение чекбоксов
                bool inFacultative = checkBox1.Checked;
                bool notInFacultative = checkBox2.Checked;

                var students = context.Students.AsQueryable(); // Начинаем с всех студентов

                // Фильтруем по участию в факультативе, если выбран соответствующий чекбокс
                if (inFacultative)
                {
                    students = students.Where(s => s.InFacultativ == true);
                }
                else if (notInFacultative)
                {
                    students = students.Where(s => s.InFacultativ == false);
                }

                // Продолжаем фильтрацию по имени и группе
                if (!string.IsNullOrEmpty(nameFilter))
                {
                    students = students.Where(s => s.FirstName.Contains(nameFilter));
                }

                var result = from s in students
                             join fr in context.FacultativeRecord on s.StudentId equals fr.StudentId into sf
                             from x in sf.DefaultIfEmpty()
                             join f in context.Facultative on x.FacultativeId equals f.FacultativeId into fs
                             from y in fs.DefaultIfEmpty()
                             select new
                             {
                                 ID = s.StudentId,
                                 Имя = s.FirstName,
                                 Фамилия = s.LastName,
                                 Отчество = s.MiddleName,
                                 Группа = s.Group,
                                 Телефон = s.PhoneNumber,
                                 Факультатив = y == null ? "None" : y.Title
                             };

                if (!string.IsNullOrEmpty(groupFilter))
                {
                    result = result.Where(r => r.Группа.Contains(groupFilter));
                }
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Отчество";
                dataGridView1.Columns[4].HeaderText = "Группа";
                dataGridView1.Columns[5].HeaderText = "Телефон";
                dataGridView1.Columns[6].HeaderText = "Факультатив";
                AdjustColumnWidths();
            }
        }




        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text, lastname = textBox2.Text, middlename = textBox3.Text, group = textBox4.Text, phone = textBox5.Text;
            if (name.Length == 0 || lastname.Length == 0 || middlename.Length == 0 || group.Length == 0 || phone.Length == 0)
            {
                throw new Exception("Заполните все поля.");
            }
            else
            {
                using (var context = new Datab()) // Открывает подключение
                {
                    try
                    {
                        Students students = new Students(name, lastname, middlename, group, phone, false);
                        var st = context.Students.FirstOrDefault(em => em.FirstName == students.FirstName && em.LastName == students.LastName);
                        if (st == null) // Если таких нет, то записываем студента в базу
                        {
                            context.Students.Add(students);
                            MessageBox.Show("Данные сохранены.", "Успешно", MessageBoxButtons.OK);
                            context.SaveChanges(); // Сохраняем изменения
                            context.ChangeTracker.DetectChanges(); // Обнаруживаем изменения
                            reloadTable();
                        }
                        else
                        {
                            MessageBox.Show("Студент уже есть в базе данных.", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                    catch (DbUpdateException ex)
                    {
                        // Вывод информации обо всех внутренних исключениях
                        Exception currentException = ex;
                        while (currentException != null)
                        {
                            MessageBox.Show(currentException.Message, "Ошибка", MessageBoxButtons.OK);
                            currentException = currentException.InnerException;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {
            using (var context = new Datab())
            {
                var result = context.Students;
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Отчество";
                dataGridView1.Columns[4].HeaderText = "Группа";
                dataGridView1.Columns[5].HeaderText = "Телефон";
                dataGridView1.Columns[6].Visible = false;
            }
            AdjustColumnWidths();
            checkBox1.Checked = true;
        }
        private void reloadTable()
        {
            using (var context = new Datab())
            {
                var result = context.Students;
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Имя";
                dataGridView1.Columns[2].HeaderText = "Фамилия";
                dataGridView1.Columns[3].HeaderText = "Отчество";
                dataGridView1.Columns[4].HeaderText = "Группа";
                dataGridView1.Columns[5].HeaderText = "Телефон";
                dataGridView1.Columns[6].Visible = false;
                AdjustColumnWidths();
            }

        }
        private void AdjustColumnWidths()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)//проверка на выделение полей для удаления
            {
                MessageBox.Show("Нет выделенных объектов для удаления", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                using (var context = new Datab())
                {
                    int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                    Students students = context.Students.FirstOrDefault(s => s.StudentId == id);
                    context.Students.Remove(students);
                    MessageBox.Show("Удаление завершено!", "Успех!", MessageBoxButtons.OK);

                    context.SaveChanges();//сохраняем данные
                }
                reloadTable();//перезаписываем таблицу
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FilterStudents();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            FilterStudents();
        }
    }
}
