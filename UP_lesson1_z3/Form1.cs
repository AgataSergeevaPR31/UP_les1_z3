namespace UP_lesson1_z3
{
    public partial class Form1 : Form
    {
        Playlist myPlaylist = new Playlist();
        string deleteSong = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //���������� �������� ��� ����� ������ � ����� 
            //label
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            //button
            button1.Visible = true;
            //textBox
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;

            //�������� �������� ��� ������ � ����������
            //label
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            //button
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            //textBox
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //�������� �������� ��� ����� ������ � ����� 
            //label
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            //button
            button1.Visible = false;
            //textBox
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;



            //���������� �������� ��� ������ � ����������
            //label
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            //button
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            //textBox
            textBox4.Visible = true;
            textBox5.Visible = true;
            UpdateSong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text;
            string title = textBox2.Text;
            string filename = textBox3.Text;

            if (author != "" && title != "" && filename != "")
            {
                if (author.Length > 1)
                {
                    if (filename.Length > 4)
                    {
                        myPlaylist.AddSong(author, title, filename);
                        MessageBox.Show("��������� ����� '" + title + "'");
                        //������� ���� ��� ������ �����
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        UpdateSong();
                    }
                    else MessageBox.Show("���� � ����� ������ ��������� �� ����� 5 ��������!!");
                }
                else MessageBox.Show("��� ������ ����� ������ ��������� �� ����� 2-� ��������!");
            }
            else MessageBox.Show("����������, ���������, ��� �� ��������� ��� ����!");
        }

        //����� ��� ������ ������� �����
        private void UpdateSong()
        {
            //����� ������ ��� ����, ����� �������� ���� �� � ��������� ����� ��� �� ����
            if (myPlaylist.Count > 0)
            {
                Song songNow = myPlaylist.CurrentSong();
                label5.Text = songNow.author + "\n" + songNow.title;
            }
            else
            {
                label5.Text = "�������� ����!";
            }
        }

        //������������ �� ��������� �����
        private void button2_Click(object sender, EventArgs e)
        {
            myPlaylist.NextSong();
            UpdateSong();
        }

        //������������ �� ���������� �����
        private void button3_Click(object sender, EventArgs e)
        {
            myPlaylist.BeforeSong();
            UpdateSong();
        }

        //����� ����� �� �������
        private void button4_Click(object sender, EventArgs e)
        {
            var index = textBox4.Text;
            if (int.TryParse(index, out int ind))
            {
                MessageBox.Show(myPlaylist.Index(ind - 1));
                UpdateSong();
            }
        }

        //� ������ ���������
        private void button5_Click(object sender, EventArgs e)
        {
            myPlaylist.Start();
            UpdateSong();
        }

        //������� ��� ������� ������ � ����� ������� � ������� ��� ��������
        private void label5_Click(object sender, EventArgs e)
        {
            if (myPlaylist.Count > 0)
            {
                Song currentSong = myPlaylist.CurrentSong();
                label7.Text = $"{currentSong.author}\n{currentSong.title}\n{currentSong.filename}";
                deleteSong = $"{currentSong.author}~{currentSong.title}~{currentSong.filename}";
            }
        }

        //������� ��� �������� �����
        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox5.Text, out int index))
            {
                if (index >= 0 && index < myPlaylist.Count)
                {
                    myPlaylist.RemoveSong(index - 1);
                    MessageBox.Show("����� ������� �� �������.");
                    textBox5.Clear();
                    UpdateSong();
                }
                else
                {
                    MessageBox.Show("� ��� ��� ������� �����!");
                }
            }
            else if (label7.Text != "")
            {
                string[] res = deleteSong.Split('~');
                Song songDelete = new Song(res[0], res[1], res[2]);
                myPlaylist.RemoveSong(songDelete);
                MessageBox.Show("����� ������� �� ������ � �����.");
                label7.Text = "";
                UpdateSong();
            }
            else MessageBox.Show("�� �� ������� �������� ��������!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myPlaylist.Clear();
            UpdateSong();
        }

        //������� ��� ������� ������ � ����� ������� � ������� ��� ��������
        private void label5_Click_1(object sender, EventArgs e)
        {
            if (myPlaylist.Count > 0)
            {
                Song currentSong = myPlaylist.CurrentSong();
                label7.Text = $"{currentSong.author}\n{currentSong.title}\n{currentSong.filename}";
                deleteSong = $"{currentSong.author}~{currentSong.title}~{currentSong.filename}";
            }
        }
    }
}
