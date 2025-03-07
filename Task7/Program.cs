
Book book1 = new Book("Kadirov Kamoliddin", "Be brace", 7);
Console.WriteLine($"Autor: {book1.Author}, Title: {book1.Title}, Pages: {book1.Pages}");


public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public int Pages { get; set; }

    public Book(string author, string title, int pages)
    {
        Author = author;
        Title = title;
        Pages = pages;
    }
}