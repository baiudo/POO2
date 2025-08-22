namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_converte_Click(object sender, EventArgs e)
        {
            float tempC = float.Parse(textBox_C.Text);
            float tempF = (float)(tempC * 1.8 + 32);
            label_conversao.Text = $"{tempF}ºF";
        }
    }
}
