public static class DbInitializer
{
    public static void Initialize()
    {
        using (var db = new LibraryContext())
        {
            db.Database.EnsureCreated();

            if (db.Authors.Any()) return;

            for (int i = 1; i <= 50; i++)
            {
                var author = new Author
                {
                    Name = $"Author {i}",
                    Books = new List<Book>()
                };

                for (int j = 1; j <= 100; j++)
                {
                    author.Books.Add(new Book
                    {
                        Title = $"Book {i}-{j}"
                    });
                }

                db.Authors.Add(author);
            }

            db.SaveChanges();
        }
    }
}