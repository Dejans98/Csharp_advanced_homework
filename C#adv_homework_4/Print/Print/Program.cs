
using Print.Helpers;

PrintInConsole printInConsole = new PrintInConsole();

printInConsole.Print("Hello");
printInConsole.Print(10);


printInConsole.PrintCollection(new List<int> { 1, 2, 3, 4, 5 });
printInConsole.PrintCollection(new List<string> { "Hey", "How" });