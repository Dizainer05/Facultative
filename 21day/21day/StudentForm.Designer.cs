namespace _21day
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 250);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(30, 395);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Имя";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(166, 395);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Фамилия";
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(302, 395);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(130, 27);
            textBox3.TabIndex = 3;
            textBox3.Text = "Отчество";
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(438, 395);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 27);
            textBox4.TabIndex = 4;
            textBox4.Text = "Группа";
            textBox4.Click += textBox4_Click;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(544, 395);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(113, 27);
            textBox5.TabIndex = 5;
            textBox5.Text = "Телефон";
            textBox5.Click += textBox5_Click;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 11F);
            textBox6.Location = new Point(30, 299);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(146, 27);
            textBox6.TabIndex = 6;
            textBox6.Click += textBox6_Click;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 11F);
            textBox7.Location = new Point(182, 299);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(148, 27);
            textBox7.TabIndex = 7;
            textBox7.Click += textBox7_Click;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(681, 388);
            button1.Name = "button1";
            button1.Size = new Size(107, 41);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F);
            button2.Location = new Point(713, 268);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 9;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(302, 347);
            label1.Name = "label1";
            label1.Size = new Size(203, 30);
            label1.TabIndex = 10;
            label1.Text = "Добавить студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(30, 276);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 11;
            label2.Text = "Фильтр по имени";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(182, 276);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 12;
            label3.Text = "Фильтр по группе";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(358, 291);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(111, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "В факультативе";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(358, 316);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(128, 19);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Не в факультативе";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Студенты";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}