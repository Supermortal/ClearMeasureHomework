// See https://aka.ms/new-console-template for more information
using NewNamesHelper;
using System.Text;

var namesAndIndiciesList = WriteNameToConsole.WriteNamesToConsole();

foreach (var nameOrIndex in namesAndIndiciesList)
{
    Console.WriteLine(nameOrIndex.ToString());
}
