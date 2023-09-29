namespace RelogioDigital_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}