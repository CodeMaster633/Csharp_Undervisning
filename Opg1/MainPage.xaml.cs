namespace MAUI2Opg1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Bil b1 = new Bil("i3",300,false);
            Bil b2 = new Bil("107",65,false);
            Bil b3 = new Bil("Model Y",200,true);

        }

        
    }

}
