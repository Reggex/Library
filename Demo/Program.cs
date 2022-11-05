// See https://aka.ms/new-console-template for more information
using Domain;

var authors = new HashSet<Author>
{
    new Author("Чехов", "Антон", "Павлович")
};

var publisher1 = new Publisher("Москва", 1990);
var book1 = new Book("Вишнёвый сад", authors, publisher1);
var publisher2 = new Publisher("Питер", 2008);
var book2 = new Book("Три сестры", authors, publisher2);
Console.WriteLine(book1);
Console.WriteLine(book2);
