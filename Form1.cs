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

            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("�п�J�j�g�r���r��");
            }
            else
            {
                if (textBox2.Text.Length > 0)
                {
                    int result = SearchTextIndex(chars, 0);
                    if (result != -1)
                    {
                        label4.Text = result.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("�п�J�j�M�r��");
                }
            }
        }


        private int SearchTextIndex(char[] chars, int index)
        {
            if ((index + 1) > chars.Length)
            {
                MessageBox.Show("�j�M�������۲Ŧr��");
                return -1;
            }
            else
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

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 65 && e.KeyChar <= 96))
            {
                e.Handled = true;
            }
        }
    }
}