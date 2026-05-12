namespace zad21_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTopicChanged(object sender, EventArgs e)
        {
            priorityPicker.Items.Clear();

            if (topicPicker.SelectedIndex == -1)
                return;

            string selectedTopic = topicPicker.SelectedItem.ToString();

            if (selectedTopic == "Reklamacja")
            {
                priorityPicker.IsEnabled = true;

                priorityPicker.Items.Add("Niski");
                priorityPicker.Items.Add("Średni");
                priorityPicker.Items.Add("Wysoki");
            }
            else if (selectedTopic == "Pytanie")
            {
                priorityPicker.IsEnabled = true;

                priorityPicker.Items.Add("Niski");
                priorityPicker.Items.Add("Średni");
            }
            else
            {
                priorityPicker.IsEnabled = false;
            }
        }

        private async void OnSendClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameEntry.Text) ||
                string.IsNullOrWhiteSpace(emailEntry.Text) ||
                topicPicker.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(messageEditor.Text))
            {
                await DisplayAlertAsync("Błąd","Uzupełnij wszystkie wymagane pola.","OK");

                return;
            }

            string topic =topicPicker.SelectedItem.ToString();


            string priority = "Brak";


            if (priorityPicker.IsEnabled &&
                priorityPicker.SelectedIndex != -1)
            {
                priority =priorityPicker.SelectedItem.ToString();
            }


            string copy =
                copyCheckBox.IsChecked ? "Tak" : "Nie";

            await DisplayAlertAsync(
                "Wiadomość wysłana",
                $"Imię: {nameEntry.Text}\n" +
                $"Email: {emailEntry.Text}\n" +
                $"Temat: {topic}\n" +
                $"Priorytet: {priority}\n" +
                $"Kopia na email: {copy}\n\n" +
                $"Wiadomość:\n{messageEditor.Text}",
                "OK");
        }
    }
}
