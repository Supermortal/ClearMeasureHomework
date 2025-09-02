using System.Text;

namespace NewNamesHelper
{
    public class WriteNameToConsole
    {
        public static List<string> WriteNamesToConsole()
        {
            var namesAndIndiciesList = new List<string>();
            for (var i = 20; i <= 80; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    var sb = new StringBuilder();
                    if (i % 5 == 0)
                    {
                        sb.Append("Jeffery ");
                    }
                    if (i % 3 == 0)
                    {
                        sb.Append("Chris");
                    }

                    namesAndIndiciesList.Add(sb.ToString());
                }
                else
                {
                    namesAndIndiciesList.Add($"{i}");
                }
            }

            return namesAndIndiciesList;
        }
    }
}
