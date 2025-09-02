// See https://aka.ms/new-console-template for more information
using NamesHelper;
using NewNamesHelper;
using System.Text;

var namesAndIncidies = new List<NameIndexPair>()
{
    new() { Name = "Jeffery", Index = 5  },
    new() { Name = "Chris", Index = 3  },
};

var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(20, 80, namesAndIncidies);

foreach (var nameOrIndex in namesAndIndiciesStringList)
{
    Console.WriteLine(nameOrIndex.ToString());
}
