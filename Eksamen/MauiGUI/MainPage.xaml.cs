using BLL;
using DTOL.Model; 

namespace MauiGUI
{
    public partial class MainPage : ContentPage
    {
        TidsSystemBLL bll;

        public MainPage()
        {
            InitializeComponent();

            bll = new TidsSystemBLL();

            List<Medarbejder> medarbejdere = bll.GetMedarbejdere();
            foreach (var medarbejder in medarbejdere)
            {
                MedarbejderPicker.Items.Add(medarbejder.Navn);
            }
        }

        private void OnMedarbejderSelected(object sender, EventArgs e)
        {
            int selectedIndex = MedarbejderPicker.SelectedIndex;
            if (selectedIndex == -1) return; 

            var selectedMedarbejder = bll.GetMedarbejdere()[selectedIndex];

            var tidsregistreringer = bll.GetTidsregistreringerForMedarbejder(selectedMedarbejder.MedarbejderId);

            TidsregistreringCollectionView.ItemsSource = tidsregistreringer;

            TimerUgeLabel.Text = bll.GetTimerArbejdetUge(selectedMedarbejder.MedarbejderId);
        } 
    }

}
