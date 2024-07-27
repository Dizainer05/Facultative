using Microsoft.VisualBasic.ApplicationServices;

namespace _21day
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm AddStudent = new StudentForm();
            AddStudent.Owner = this;
            this.Hide();
            AddStudent.FormClosed += AddStudent_FormClosed; // Обработка события закрытия формы
            AddStudent.Show(); // Используйте Show вместо ShowDialog
        }

        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // Показать первую форму, когда вторая форма закрывается
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultativForm AddFacltativ = new FacultativForm();
            AddFacltativ.Owner = this;
            this.Hide();
            AddFacltativ.FormClosed += AddStudent_FormClosed; // Обработка события закрытия формы
            AddFacltativ.Show(); // Используйте Show вместо ShowDialog
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentAddFacultativ StudentAddFacltativ = new StudentAddFacultativ();
            StudentAddFacltativ.Owner = this;
            this.Hide();
            StudentAddFacltativ.FormClosed += AddStudent_FormClosed; // Обработка события закрытия формы
            StudentAddFacltativ.Show(); // Используйте Show вместо ShowDialog
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Surnal surnal = new Surnal();
            surnal.Owner = this;
            this.Hide();
            surnal.FormClosed += AddStudent_FormClosed; // Обработка события закрытия формы
            surnal.Show(); // Используйте Show вместо ShowDialog
        }
    }
}
