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
    public partial class FacultativForm : Form
    {
        public FacultativForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Название факультатива";
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
                textBox2.Text = "Часы";
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
                textBox3.Text = "Тип занятия";
                return;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text, type = textBox3.Text; int hours = Convert.ToInt32(textBox2.Text);
            if (name.Length == 0 || hours == 0 || type.Length == 0) { throw new Exception("Заполните все поля."); }
            else
            {
                using (var context = new Datab())//открывает подключение
                {
                    try
                    {
                        Facultative facultativ = new Facultative(name, hours, type);
                        var fac = context.Facultative.FirstOrDefault(em => em.Title == facultativ.Title && em.Type == facultativ.Type);
                        if (fac == null)//если таких нет то записываем сотрудника в базу
                        {
                            context.Facultative.Add(facultativ);
                            MessageBox.Show("Данные сохранены.", "Успешно", MessageBoxButtons.OK);
                            context.SaveChanges(); // Сохраняем изменения
                            context.ChangeTracker.DetectChanges(); // Обнаруживаем изменения
                            reloadTable();
                        }
                        else
                        {
                            MessageBox.Show("Факультатив уже есть в базе данных.", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }



        private void FacultativForm_Load(object sender, EventArgs e)
        {
            using (var context = new Datab())
            {
                var result = from a in context.Facultative
                             select new
                             {
                                 Id = a.FacultativeId.ToString(),
                                 FName = a.Title,
                                 Hour = a.Hours,
                                 Type = a.Type
                             };
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Часы";
                dataGridView1.Columns[3].HeaderText = "Тип занятия";
            }
            AdjustColumnWidths();
        }
        private void reloadTable()
        {
            using (var context = new Datab())
            {
                var result = from a in context.Facultative
                             select new
                             {
                                 Id = a.FacultativeId.ToString(),
                                 FName = a.Title,
                                 Hour = a.Hours,
                                 Type = a.Type
                             };
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Часы";
                dataGridView1.Columns[3].HeaderText = "Тип занятия";
            }
            AdjustColumnWidths();
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
                    Facultative facultative = context.Facultative.FirstOrDefault(s => s.FacultativeId == id);
                    context.Facultative.Remove(facultative);
                    MessageBox.Show("Удаление завершено!", "Успех!", MessageBoxButtons.OK);

                    context.SaveChanges();//сохраняем данные
                }
                reloadTable();//перезаписываем таблицу
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            FilterFacultatives();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            FilterFacultatives();
        }
        private void FilterFacultatives()
        {
            using (var context = new Datab())
            {
                string nameFilter = textBox4.Text;
                int hoursFilter;
                Int32.TryParse(textBox5.Text, out hoursFilter);

                var result = context.Facultative.AsQueryable();

                if (!string.IsNullOrEmpty(nameFilter))
                {
                    result = result.Where(f => f.Title.Contains(nameFilter));
                }

                if (hoursFilter > 0)
                {
                    result = result.Where(f => f.Hours == hoursFilter);
                }

                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "Название";
                dataGridView1.Columns[2].HeaderText = "Часы";
                dataGridView1.Columns[3].HeaderText = "Тип занятия";
            }
        }
    }
}
