namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }  

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Person new_person;
            if (NameBox.Text == "")
            {
                MessageBox.Show("¬вед≥ть ≥м'€");
            }

            if (AgeBox.Text != "")
            {
                if (ProfessionBox.Text != "")
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text), ProfessionBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text, Convert.ToInt32(AgeBox.Text), "не вказано");
                }
            }
            else
            {
                if (ProfessionBox.Text != "")
                {
                    new_person = new Person(NameBox.Text, 0, ProfessionBox.Text);
                }
                else
                {
                    new_person = new Person(NameBox.Text, 0, "не вказано");
                }
            }
            ResultBox.Text += new_person.GetInformation();
        }
    }
}
