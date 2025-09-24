namespace ContadorManual.Gui
{
    public partial class MainPage : ContentPage
    {


        private int _conteo;
        public MainPage()
        {
            InitializeComponent();
            _conteo = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            _conteo = 0;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            _conteo++;
        }
    }
}
