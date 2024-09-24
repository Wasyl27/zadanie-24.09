using System.Collections.ObjectModel;

namespace _123123
{
    public partial class MainPage : ContentPage
    {
        // Kolekcja elementów typu string, która będzie źródłem danych dla ListView
        private ObservableCollection<string> items;

        public MainPage()
        {
            InitializeComponent();

            // Inicjalizacja kolekcji notatek
            items = new ObservableCollection<string>
            {
                "Notatka 1",
                "Notatka 2",
                "Notatka 3"
            };

            // Powiązanie kolekcji z ListView
            ItemsListView.ItemsSource = items;
        }

        // Metoda obsługująca zdarzenie kliknięcia przycisku "DODAJ"
        private void OnAddItemClicked(object sender, EventArgs e)
        {
            // Pobranie wartości z pola edycyjnego
            string newItem = NewItemEntry.Text;

            // Sprawdzenie, czy pole edycyjne nie jest puste
            if (!string.IsNullOrWhiteSpace(newItem))
            {
                // Dodanie nowego elementu do kolekcji
                items.Add(newItem);

                // Wyczyszczenie pola edycyjnego po dodaniu elementu
                NewItemEntry.Text = string.Empty;
            }
        }
    }
}