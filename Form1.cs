namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();// 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor = Color.FromArgb(rd.Next(250), rd.Next(250), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/shnd-n",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.수원대7;
        }
    }
}
