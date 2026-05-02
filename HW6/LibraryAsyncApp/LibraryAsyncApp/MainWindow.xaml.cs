using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;

namespace LibraryAsyncApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DbInitializer.Initialize();
            LoadAuthors();
        }

        private async void LoadAuthors()
        {
            using (var db = new LibraryContext())
            {
                comboAuthors.ItemsSource = await db.Authors.ToListAsync();
            }
        }

        private async void comboAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboAuthors.SelectedItem is Author author)
            {
                using (var db = new LibraryContext())
                {
                    listBooks.ItemsSource = await db.Books
                        .Where(b => b.AuthorId == author.Id)
                        .ToListAsync();
                }
            }
        }

        private async void textSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = textSearch.Text;

            if (text.Length < 3) return;

            using (var db = new LibraryContext())
            {
                listBooks.ItemsSource = await db.Books
                    .Where(b => b.Title.Contains(text))
                    .ToListAsync();
            }
        }
    }
}