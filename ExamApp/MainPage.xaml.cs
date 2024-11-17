namespace ExamApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CompleteButton_Clicked(object sender, EventArgs e)
        {
            if( NameEntry.Text == null || 
                NameEntry.Text == string.Empty || 
                SurnameEntry.Text == null || 
                SurnameEntry.Text == string.Empty)
            {
                DisplayAlert("", "Wpisz imię", "OK");
                return;
            }
            string eyeColor = string.Empty;
            if (BlueButton.IsChecked)
                eyeColor = "niebieskie";
            else if (GreenButton.IsChecked)
                eyeColor = "zielony";
            else if (BeerButton.IsChecked)
                eyeColor = "piwny";
            
            DisplayAlert("", $"{NameEntry.Text} {SurnameEntry.Text} koloru oczu {eyeColor}", "OK");
        }

        private void IdEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.NewTextValue;
            if (text.Length == 3)
            {
                SignImage.IsVisible = true;
                PersonImage.IsVisible = true;

                switch (text)
                {
                    case "aaa":
                        SignImage.Source = ImageSource.FromFile("aaaodcisk.png");
                        PersonImage.Source = ImageSource.FromFile("aaazdjecie.png");
                        break;
                    case "bbb":
                        SignImage.Source = ImageSource.FromFile("bbbodcisk.png");
                        PersonImage.Source = ImageSource.FromFile("bbbzdjecie.png");
                        break;
                    case "ccc":
                        SignImage.Source = ImageSource.FromFile("cccodcisk.png");
                        PersonImage.Source = ImageSource.FromFile("ccczdjecie.png");
                        break;
                    default:
                        SignImage.IsVisible = false; 
                        PersonImage.IsVisible = false;
                        break;
                }
            }
        }
    }
}
