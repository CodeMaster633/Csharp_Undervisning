namespace L11MAUI
{
    public partial class MainPageOpg3 : ContentPage
    {
        int count = 0;

        public MainPageOpg3()
        {
            InitializeComponent();
        }

       

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            Btn1.Text = "OK";
        }

        private void Chb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            Btn1.IsVisible = !Btn1.IsVisible;
        }
    }

}
