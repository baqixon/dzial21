namespace zad21_2
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isEmailFilled =
                !string.IsNullOrWhiteSpace(emailEntry.Text);

            bool isPasswordFilled =
                !string.IsNullOrWhiteSpace(passwordEntry.Text);

            loginButton.IsEnabled =
                isEmailFilled && isPasswordFilled;
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await DisplayAlertAsync("Sukces","Zalogowano!","OK");
        }
    }
}
