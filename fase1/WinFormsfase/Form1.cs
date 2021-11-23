namespace WinFormsfase
{
    public partial class Increment : Form
    {
        private int teller = 0;
        private int number = 0;
        public Increment()
        {
            InitializeComponent();
            
        }

       
        private void buttonIncreament_MouseClick(object sender, MouseEventArgs e)
        {
            
            number = Convert.ToInt32(textBoxKiesCijfer.Text);
            teller +=number;
            textBoxTeller.Text = teller.ToString();
        }
    }
}