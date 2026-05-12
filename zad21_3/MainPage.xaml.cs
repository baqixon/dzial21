namespace zad21_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            birthDatePicker.MinimumDate =
                new DateTime(1950, 1, 1);

            birthDatePicker.MaximumDate =
                new DateTime(2006, 12, 31);

            birthDatePicker.Date =
                new DateTime(2000, 1, 1);
        }

        private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            registerButton.IsEnabled =
                termsCheckBox.IsChecked;
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Rejestracja","Rejestracja zakończona pomyślnie!","OK");
        }
    }
}