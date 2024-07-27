namespace _21day
{
    partial class FacultativForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(59, 383);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "Название факультатива";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(345, 383);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 1;
            textBox2.Text = "Часы";
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(485, 383);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 29);
            textBox3.TabIndex = 2;
            textBox3.Text = "Тип занятия";
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 302);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(211, 302);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(132, 23);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(658, 375);
            button1.Name = "button1";
            button1.Size = new Size(91, 42);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(699, 268);
            button2.Name = "button2";
            button2.Size = new Size(89, 36);
            button2.TabIndex = 6;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(286, 337);
            label1.Name = "label1";
            label1.Size = new Size(241, 30);
            label1.TabIndex = 7;
            label1.Text = "Добавить факультатив";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 250);
            dataGridView1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 279);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 9;
            label2.Text = "Фильтр по названию";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(211, 280);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 10;
            label3.Text = "Фильтр по часам";
            // 
            // FacultativForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FacultativForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить факультатив";
            Load += FacultativForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
    }
}