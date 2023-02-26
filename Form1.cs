namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideHud();
        }

        public void HideHud()
        {
            panel3.Visible= false;
            panel4.Visible= false;
            panel5.Visible= false;
        }

        public void ShowHud(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowHud(panel3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowHud(panel4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowHud(panel5);
        }

        
    }
}