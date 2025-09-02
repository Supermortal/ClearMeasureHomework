using NamesHelper;
using System.Text;

namespace NewNamesHelper
{
    public class WriteNameToConsole
    {
        public static List<string> WriteNamesToConsole(int LowerBounds, int UpperBounds, List<NameIndexPair> NamesAndIndicies)
        {
            var namesAndIndiciesStringList = new List<string>();
            for (var i = LowerBounds; i <= UpperBounds; i++)
            {
                var currentNameAndIndicies = NamesAndIndicies.Where(ni => i % ni.Index == 0);
                if (!currentNameAndIndicies.Any())
                {
                    namesAndIndiciesStringList.Add($"{i}");
                    continue;
                }

                var names = new StringBuilder();
                foreach (var nameAndIndex in currentNameAndIndicies)
                {
                    names.Append($"{nameAndIndex.Name} ");
                }

                namesAndIndiciesStringList.Add(names.ToString().TrimEnd(' '));
            }

            return namesAndIndiciesStringList;
        }
    }
}
