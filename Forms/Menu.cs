using System.Configuration;

namespace SeaBatle
{
    public partial class Menu : Form
    {
        int minWidth = int.Parse(ConfigurationManager.AppSettings.Get("minMenuWidth"));
        int minHeight = int.Parse(ConfigurationManager.AppSettings.Get("minMenuHeight"));

        public Menu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(minWidth, minHeight);

        }


    }
}