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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace _21day
{
    public partial class Surnal : Form
    {
        public Surnal()
        {
            InitializeComponent();
        }

        private void Surnal_Load(object sender, EventArgs e)
        {
            using (var context = new Datab())
            {
                var result = from n in context.FacultativeRecord
                             join st in context.Students on n.StudentId equals st.StudentId
                             join fac in context.Facultative on n.FacultativeId equals fac.FacultativeId
                             select new
                             {
                                 StudentName = st.FirstName,
                                 StudentLastName = st.LastName,
                                 FacultativeName = fac.Title,
                                 FacultativeType = fac.Type,
                                 FacultativeHours = fac.Hours,
                                 WorkedHours = n.WorkedHours
                             };

                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "Имя";
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Факультатив";
                dataGridView1.Columns[3].HeaderText = "Вид занятия";
                dataGridView1.Columns[4].HeaderText = "Кол. часов";
                dataGridView1.Columns[5].HeaderText = "Отрб. часов";
            }
            AdjustColumnWidths();
        }
        private void reloadTable()
        {
            using (var context = new Datab())
            {
                var result = from n in context.FacultativeRecord
                             join st in context.Students on n.StudentId equals st.StudentId
                             join fac in context.Facultative on n.FacultativeId equals fac.FacultativeId
                             select new
                             {
                                 StudentName = st.FirstName,
                                 StudentLastName = st.LastName,
                                 FacultativeName = fac.Title,
                                 FacultativeType = fac.Type,
                                 FacultativeHours = fac.Hours,
                                 WorkedHours = n.WorkedHours
                             };
                dataGridView1.DataSource = result.ToList();
                dataGridView1.Columns[0].HeaderText = "Имя";
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Факультатив";
                dataGridView1.Columns[3].HeaderText = "Вид занятия";
                dataGridView1.Columns[4].HeaderText = "Кол. часов";
                dataGridView1.Columns[5].HeaderText = "Отрб. часов";
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
        private void FilterRecords()
        {
            using (var context = new Datab())
            {
                string firstNameFilter = textBox1.Text;
                string lastNameFilter = textBox2.Text;
                string facultativeNameFilter = textBox3.Text;
                string facultativeTypeFilter = textBox4.Text;

                var result = from record in context.FacultativeRecord
                             join student in context.Students on record.StudentId equals student.StudentId
                             join facultative in context.Facultative on record.FacultativeId equals facultative.FacultativeId
                             select new
                             {
                                 StudentName = student.FirstName,
                                 StudentLastName = student.LastName,
                                 FacultativeName = facultative.Title,
                                 FacultativeType = facultative.Type,
                                 FacultativeHours = facultative.Hours,
                                 WorkedHours = record.WorkedHours
                             };

                if (!string.IsNullOrEmpty(firstNameFilter))
                {
                    result = result.Where(r => r.StudentName.Contains(firstNameFilter));
                }

                if (!string.IsNullOrEmpty(lastNameFilter))
                {
                    result = result.Where(r => r.StudentLastName.Contains(lastNameFilter));
                }

                if (!string.IsNullOrEmpty(facultativeNameFilter))
                {
                    result = result.Where(r => r.FacultativeName.Contains(facultativeNameFilter));
                }

                if (!string.IsNullOrEmpty(facultativeTypeFilter))
                {
                    result = result.Where(r => r.FacultativeType.Contains(facultativeTypeFilter));
                }

                dataGridView1.DataSource = result.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterRecords();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            FilterRecords();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            FilterRecords();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            FilterRecords();
        }
    }
}
