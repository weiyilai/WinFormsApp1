namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] chars = textBox1.Text.ToCharArray();

            label4.Text = SearchTextIndex(chars, 0).ToString();
        }


        private int SearchTextIndex(char[] chars, int index)
        {
            if (chars[index].ToString() == textBox2.Text)
            {
                return index;
            }
            else
            {
                return SearchTextIndex(chars, index + 1);
            }
        }
    }
}