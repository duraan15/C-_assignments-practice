namespace assignment_using_parse_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String entername = txtname.Text;
            int enterid = int.Parse(txtid.Text);
            String department = txtdepartment.Text;
            String semester = txtsemester.Text;
            String fullinfo = entername + " " + enterid + " " + department + " " + semester;
            lblouput.Text = fullinfo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lblouput.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
