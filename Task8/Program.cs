//Default Construction
Library unnamedLibrary = new Library();
unnamedLibrary.DisplayLibraryDetails();
//Parameterize Construction
Library library = new Library("Central Library", "Capital City");
library.DisplayLibraryDetails();



public class Library
{
    public string FirstName;

    public string Location;

    public Library()
    {
        FirstName = "#######";
        Location = "#######";
    }

    public Library(string firstName, string location)
    {
        FirstName = firstName;
        Location = location;
    }

    public void DisplayLibraryDetails()
    {
        Console.WriteLine($"Name: {FirstName},  Location: {Location}");
    }
}