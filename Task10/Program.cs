Library library = new Library();


library.AddBook(new Book ("Tojikon", "Bobojon Ghafurov", 900, 2 ));
library.AddBook(new Book ("Adabiyor", "Sadriddin Ayni", 400, 3 ));
library.AddBook(new Book ("Tojikon", "Bobojon Ghafurov", 900, 1 ));
library.DisplayBooks();


library.RemoveBook("Tojikon");
library.DisplayBooks();


Console.WriteLine();

public class Library
{
    public List<Book> Books {get; set;} = new List<Book>();
    public void AddBook(Book book)

    {
        foreach (var bookList in Books)
        {
            if (bookList.Author == book.Author && bookList.Title == book.Title)
            Console.WriteLine($"Increased quantity of '{bookList.Title}' to {bookList.Quantity}.");
            bookList.Quantity ++;
            return;
        }
        Books.Add(book);
        System.Console.WriteLine($"Book '{book.Title}'added to the library");
        

    }

    public void RemoveBook(string title)
    {
        foreach (var bookList in Books)
        {
            if (bookList.Title == title)
            {
                if (bookList.Quantity > 0)
                {
                     bookList.Quantity --;
                     Console.WriteLine($"Decreased quantity of '{bookList.Title}' to {bookList.Quantity}.");
                }
                else
                {
                    Books.Remove(bookList);
                }
                
            }
        }   
        
    }
    public void DisplayBooks()
    {
        Console.WriteLine("Library Book:");
        foreach (var book in Books)
        {
            Console.WriteLine($"{book.Title} by {book.Author}, {book.Pages}, pages(Copies: {book.Quantity})");
        }
    }
     public void SearchBook(string keyword)
     {
        foreach (var book in Books)
        {
            if(book.Title == keyword || book.Author == keyword)
            {
            Console.WriteLine($"{book.Title} by {book.Author}, {book.Pages}, pages(Copies: {book.Quantity})");
            }
        }
    }
    public void CountBooksByTitle(string title)
     {
     
        foreach (var book in Books)
        {
            if(book.Title == title)
            {
            Console.WriteLine($"Миқдори умумии '{book.Title}': {book.Quantity} ");
            }
        }
        
    }

}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int Quantity { get; set; }

    public Book(string title, string author, int pages, int quantity)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Quantity = quantity;
    }
}


