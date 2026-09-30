namespace electircity_bill_costomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cerating variables
            try
            {
                String customername = txtcustomername.Text;
                double previousreading = double.Parse(txtpreviousreading.Text);
                double currentreading = double.Parse(txtcurrentreading.Text);
                double priceperunit = double.Parse(txtpriceunit.Text);
                //calculate usage
                double usage = currentreading - previousreading;
                // calculate bill
                double electricitycost = usage * priceperunit;
                double tax = electricitycost * (0.07);
                double fixedcharge = 5;
                //calculate total
                double totalbill = electricitycost + tax + fixedcharge;

                //display out put
                lbloutputelectriciyusage.Text = usage.ToString("c");
                lbloutputtaxamount.Text = "$" + tax.ToString("0.00");
                lbloutputamountbill.Text = "$" + totalbill.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("inviled data was intered");
            }
            
        }
    }
}
