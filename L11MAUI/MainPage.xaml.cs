namespace L11MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void BtnSwap1_Clicked(object sender, EventArgs e)
        {
           
            string temp = Lbl1.Text;
            Lbl1.Text = Lbl2.Text;
            Lbl2.Text = temp;
        }
        private void BtnSwap2_Clicked(object sender, EventArgs e)
        {

            string temp = Lbl3.Text;
            Lbl3.Text = Lbl4.Text;
            Lbl4.Text = temp;
        }
    }

}
