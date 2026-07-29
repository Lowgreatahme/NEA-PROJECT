namespace NEA_PROJECT
{
    public partial class AshenVeil : Form
    {
        public AshenVeil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CharacterCreator CharacterCreator = new CharacterCreator();
            CharacterCreator.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AshenVeil_Load(object sender, EventArgs e)
        {
           
        }
    }
}
