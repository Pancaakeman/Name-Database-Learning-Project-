using System.Diagnostics.Eventing.Reader;

namespace Name_Database
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

        private void textbox1_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                List_of_People.Items.Add(DBName.Text);
                DBName.Text = " ";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
