namespace UP_lesson1_z3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            добавитьПеснюToolStripMenuItem = new ToolStripMenuItem();
            плэйлистToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { добавитьПеснюToolStripMenuItem, плэйлистToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(849, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // добавитьПеснюToolStripMenuItem
            // 
            добавитьПеснюToolStripMenuItem.Name = "добавитьПеснюToolStripMenuItem";
            добавитьПеснюToolStripMenuItem.Size = new Size(139, 24);
            добавитьПеснюToolStripMenuItem.Text = "Добавить песню";
            добавитьПеснюToolStripMenuItem.Click += добавитьПеснюToolStripMenuItem_Click;
            // 
            // плэйлистToolStripMenuItem
            // 
            плэйлистToolStripMenuItem.Name = "плэйлистToolStripMenuItem";
            плэйлистToolStripMenuItem.Size = new Size(88, 24);
            плэйлистToolStripMenuItem.Text = "Плэйлист";
            плэйлистToolStripMenuItem.Click += плэйлистToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 255);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "Автор:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 128, 255);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(172, 20);
            label2.TabIndex = 2;
            label2.Text = "Название композиции:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 128, 255);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 3;
            label3.Text = "Путь к файлу:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.White;
            button1.Location = new Point(90, 175);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 128, 255);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(85, 50);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = "Текущая песня";
            label4.Visible = false;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(177, 169);
            button2.Name = "button2";
            button2.Size = new Size(41, 40);
            button2.TabIndex = 10;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(53, 169);
            button3.Name = "button3";
            button3.Size = new Size(41, 40);
            button3.TabIndex = 11;
            button3.Text = "<<";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 128, 255);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(20, 256);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 12;
            label6.Text = "Введите номер песни:";
            label6.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(190, 253);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(79, 27);
            textBox4.TabIndex = 13;
            textBox4.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(102, 296);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Вывести";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Teal;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(59, 331);
            button5.Name = "button5";
            button5.Size = new Size(190, 31);
            button5.TabIndex = 15;
            button5.Text = "В начало плэйлиста";
            button5.UseVisualStyleBackColor = false;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 128, 255);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(342, 132);
            label8.Name = "label8";
            label8.Size = new Size(258, 20);
            label8.TabIndex = 17;
            label8.Text = "Введите номер песни для удаления";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 128, 255);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(342, 175);
            label9.Name = "label9";
            label9.Size = new Size(171, 20);
            label9.TabIndex = 18;
            label9.Text = "или нажмите на песню";
            label9.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(625, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 19;
            textBox5.Visible = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Teal;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(506, 256);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 20;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(85, 368);
            button7.Name = "button7";
            button7.Size = new Size(151, 29);
            button7.TabIndex = 21;
            button7.Text = "Удалить плэйлист";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 102);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 22;
            label5.Text = "Плэйлист пуст!";
            label5.Visible = false;
            label5.Click += label5_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(542, 175);
            label7.Name = "label7";
            label7.Size = new Size(208, 20);
            label7.TabIndex = 23;
            label7.Text = "нажмите на название песни";
            label7.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(849, 419);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьПеснюToolStripMenuItem;
        private ToolStripMenuItem плэйлистToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label6;
        private TextBox textBox4;
        private Button button4;
        private Button button5;
        private Label label8;
        private Label label9;
        private TextBox textBox5;
        private Button button6;
        private Button button7;
        private Label label5;
        private Label label7;
    }
}
