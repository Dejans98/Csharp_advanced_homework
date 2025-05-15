

using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

ISerchable page = new WebPage("Welcome");
Console.WriteLine(page.Serch("Welcome"));

ISerchable document = new Document("This is a document");
Console.WriteLine(document.Serch("this"));