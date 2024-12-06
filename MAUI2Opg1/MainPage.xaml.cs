//using Accelerate;

namespace MAUI2Opg1
{
    public partial class MainPage : ContentPage
    {

            NotificationBil b1 = new NotificationBil("i3", 300, false);
        public MainPage()
        {
            InitializeComponent();

            //Bil b2 = new Bil("107", 65, false);
            //Bil b3 = new Bil("Model Y", 200, true);

            Model.BindingContext = b1;
            Heste.BindingContext = b1;
            Elbil.BindingContext = b1;

        }

        private void Submit_Clicked(object sender, EventArgs e)
        {
            Beskrivelse.Text = b1.Model+" "+b1.Heste+" "+b1.Elbil;
        }
        private void Submit2_Clicked(object sender, EventArgs e)
        {
            b1.Model = "Test gået godt";
        }
    }

}
