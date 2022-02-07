namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            
        {


           

            if (radioButton1.Checked)
            {
                MessageBox.Show("You are " + radioButton1.Text+ " Your favorite food is " + listBox1.SelectedItem.ToString() + " Your favorite sport is " + checkedListBox1.SelectedItem.ToString());

            }

            else if (radioButton2.Checked)
            {
                MessageBox.Show("You are " + radioButton2.Text + " Your favorite food is " + listBox1.SelectedItem.ToString() + " Your favorite sport is " + checkedListBox1.SelectedItem.ToString());
            }

            //MessageBox.Show("Your favorite food is " + listBox1.SelectedItem.ToString()+ " Your favorite sport is " + checkedListBox1.SelectedItem.ToString() + " You are" + collegeStudent);

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}