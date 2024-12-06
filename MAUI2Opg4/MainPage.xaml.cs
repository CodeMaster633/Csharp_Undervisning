using MAUI2Opg1;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace MAUI2Opg4
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<NotificationBil> bilListe = new ObservableCollection<NotificationBil>();
        
        public MainPage()
        {
            InitializeComponent();

            bilListe.Add(new NotificationBil("i3", 500, false));
            bilListe.Add(new NotificationBil("A8", 500, false));
            bilListe.Add(new NotificationBil("Model S", 500, true));

            BilView.ItemsSource = bilListe;
        }

        public void BilView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Model.BindingContext = e.CurrentSelection[0];
            //Heste.BindingContext = e.CurrentSelection[0];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bilListe.Add(new NotificationBil("107",65,false));
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            bilListe[0].Model = "Clio";
        }
    }

}
