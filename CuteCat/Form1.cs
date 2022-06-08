namespace CuteCat
{
    public partial class Form1 : Form
    {
        Cat MyCat = new Cat("jimi", 2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            MyCat.play();
            CatScreen.Text = MyCat.Express();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            MyCat.Eat();
            CatScreen.Text = MyCat.Express();
        }

        private void CatTimer_Tick(object sender, EventArgs e)
        {
            MyCat.GetBorad();
            CatScreen.Text = MyCat.Express();
        }

        private void CatScreen_Click(object sender, EventArgs e)
        {        
            CatScreen.Text = MyCat.Express();
        }
    }
}