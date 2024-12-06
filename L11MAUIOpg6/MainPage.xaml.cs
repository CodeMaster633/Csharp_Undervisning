

namespace L11MAUIOpg6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            //btn1.Clicked += Button_Clicked;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
          
        }

        private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
        {
            var menupunkt = sender as MenuFlyoutItem;

            Lbl1.Text = menupunkt.Text;
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var btn = sender as Button;

        //    Lbl1.Text += "\n"+btn.Text;

        //} Opgave 6
    }

}
