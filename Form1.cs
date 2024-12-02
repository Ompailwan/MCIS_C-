namespace ProjectOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = MyFavorites.FavoriteSong();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = MyFavorites.FavoriteMovie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = MyFavorites.FavoriteFood();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
