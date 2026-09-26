namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String dayoftheweek, nameofthemounth, numericofthemounth, year, fulldata;
            dayoftheweek = txtdayoftheweek.Text;
            nameofthemounth = txtnameofthemounth.Text;
            numericofthemounth = txtnumericofthemounth.Text;
            year = txtoftheyar.Text;
            fulldata = dayoftheweek + "/" + nameofthemounth + "/" + numericofthemounth + "/" + year;
            displayoutput.Text = fulldata;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdayoftheweek.Text = "";
            txtnameofthemounth.Clear();
            txtnumericofthemounth.Text = string.Empty;
            txtoftheyar.Text = string.Empty;
            displayoutput.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
