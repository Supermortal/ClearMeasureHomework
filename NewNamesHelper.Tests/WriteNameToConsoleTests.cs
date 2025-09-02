using NamesHelper;

namespace NewNamesHelper.Tests
{
    public class WriteNameToConsoleTests
    {
        [Fact]
        public void CheckCountInclusive()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(20, 80, namesAndIncidies);

            Assert.Equal(61, namesAndIndiciesStringList.Count);
        }

        [Fact]
        public void CheckZeroLowerBound()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(0, 80, namesAndIncidies);

            Assert.Equal(81, namesAndIndiciesStringList.Count);
        }

        [Fact]
        public void CheckNegativeLowerBound()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(-5, 80, namesAndIncidies);

            Assert.Equal(86, namesAndIndiciesStringList.Count);
        }

        [Fact]
        public void CheckZeroUpperBound()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(20, 0, namesAndIncidies);

            Assert.Empty(namesAndIndiciesStringList);
        }

        [Fact]
        public void CheckNegativeUpperBound()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(20, -80, namesAndIncidies);

            Assert.Empty(namesAndIndiciesStringList);
        }

        [Fact]
        public void CheckEmptyNamesAndIncidies()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(20, 80, namesAndIncidies);

            Assert.Equal(61, namesAndIndiciesStringList.Count);
        }

        [Fact]
        public void CheckOutputTwoNames()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(1, 15, namesAndIncidies);

            Assert.Equal(15, namesAndIndiciesStringList.Count);

            Assert.Equal("1", namesAndIndiciesStringList[0]);
            Assert.Equal("2", namesAndIndiciesStringList[1]);
            Assert.Equal("Chris", namesAndIndiciesStringList[2]);
            Assert.Equal("4", namesAndIndiciesStringList[3]);
            Assert.Equal("Jeffery", namesAndIndiciesStringList[4]);
            Assert.Equal("Chris", namesAndIndiciesStringList[5]);
            Assert.Equal("7", namesAndIndiciesStringList[6]);
            Assert.Equal("8", namesAndIndiciesStringList[7]);
            Assert.Equal("Chris", namesAndIndiciesStringList[8]);
            Assert.Equal("Jeffery", namesAndIndiciesStringList[9]);
            Assert.Equal("11", namesAndIndiciesStringList[10]);
            Assert.Equal("Chris", namesAndIndiciesStringList[11]);
            Assert.Equal("13", namesAndIndiciesStringList[12]);
            Assert.Equal("14", namesAndIndiciesStringList[13]);
            Assert.Equal("Jeffery Chris", namesAndIndiciesStringList[14]);
        }

        [Fact]
        public void CheckOutputThreeNames()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
                new() { Name = "Chris", Index = 3  },
                new() { Name = "Samantha", Index = 2  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(1, 15, namesAndIncidies);

            Assert.Equal(15, namesAndIndiciesStringList.Count);

            Assert.Equal("1", namesAndIndiciesStringList[0]);
            Assert.Equal("Samantha", namesAndIndiciesStringList[1]);
            Assert.Equal("Chris", namesAndIndiciesStringList[2]);
            Assert.Equal("Samantha", namesAndIndiciesStringList[3]);
            Assert.Equal("Jeffery", namesAndIndiciesStringList[4]);
            Assert.Equal("Chris Samantha", namesAndIndiciesStringList[5]);
            Assert.Equal("7", namesAndIndiciesStringList[6]);
            Assert.Equal("Samantha", namesAndIndiciesStringList[7]);
            Assert.Equal("Chris", namesAndIndiciesStringList[8]);
            Assert.Equal("Jeffery Samantha", namesAndIndiciesStringList[9]);
            Assert.Equal("11", namesAndIndiciesStringList[10]);
            Assert.Equal("Chris Samantha", namesAndIndiciesStringList[11]);
            Assert.Equal("13", namesAndIndiciesStringList[12]);
            Assert.Equal("Samantha", namesAndIndiciesStringList[13]);
            Assert.Equal("Jeffery Chris", namesAndIndiciesStringList[14]);
        }

        [Fact]
        public void CheckOutputOneName()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
                new() { Name = "Jeffery", Index = 5  },
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(1, 15, namesAndIncidies);

            Assert.Equal(15, namesAndIndiciesStringList.Count);

            Assert.Equal("1", namesAndIndiciesStringList[0]);
            Assert.Equal("2", namesAndIndiciesStringList[1]);
            Assert.Equal("3", namesAndIndiciesStringList[2]);
            Assert.Equal("4", namesAndIndiciesStringList[3]);
            Assert.Equal("Jeffery", namesAndIndiciesStringList[4]);
            Assert.Equal("6", namesAndIndiciesStringList[5]);
            Assert.Equal("7", namesAndIndiciesStringList[6]);
            Assert.Equal("8", namesAndIndiciesStringList[7]);
            Assert.Equal("9", namesAndIndiciesStringList[8]);
            Assert.Equal("Jeffery", namesAndIndiciesStringList[9]);
            Assert.Equal("11", namesAndIndiciesStringList[10]);
            Assert.Equal("12", namesAndIndiciesStringList[11]);
            Assert.Equal("13", namesAndIndiciesStringList[12]);
            Assert.Equal("14", namesAndIndiciesStringList[13]);
            Assert.Equal("Jeffery", namesAndIndiciesStringList[14]);
        }

        [Fact]
        public void CheckOutputNoNames()
        {
            var namesAndIncidies = new List<NameIndexPair>()
            {
            };

            var namesAndIndiciesStringList = WriteNameToConsole.WriteNamesToConsole(1, 15, namesAndIncidies);

            Assert.Equal(15, namesAndIndiciesStringList.Count);

            Assert.Equal("1", namesAndIndiciesStringList[0]);
            Assert.Equal("2", namesAndIndiciesStringList[1]);
            Assert.Equal("3", namesAndIndiciesStringList[2]);
            Assert.Equal("4", namesAndIndiciesStringList[3]);
            Assert.Equal("5", namesAndIndiciesStringList[4]);
            Assert.Equal("6", namesAndIndiciesStringList[5]);
            Assert.Equal("7", namesAndIndiciesStringList[6]);
            Assert.Equal("8", namesAndIndiciesStringList[7]);
            Assert.Equal("9", namesAndIndiciesStringList[8]);
            Assert.Equal("10", namesAndIndiciesStringList[9]);
            Assert.Equal("11", namesAndIndiciesStringList[10]);
            Assert.Equal("12", namesAndIndiciesStringList[11]);
            Assert.Equal("13", namesAndIndiciesStringList[12]);
            Assert.Equal("14", namesAndIndiciesStringList[13]);
            Assert.Equal("15", namesAndIndiciesStringList[14]);
        }

        [Fact]
        public void CheckNullInputList()
        {
            Assert.Throws<ArgumentNullException>(() => WriteNameToConsole.WriteNamesToConsole(1, 15, null));
        }
    }
}