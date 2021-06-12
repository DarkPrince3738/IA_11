using System;

namespace Task1
{
    /*З enum легше*/
    class Program
    {
        static void Main(string[] args)
        {
            var englishWords = new string[] { "word", "mother", "apple" };
            var ukraineWords = new string[] { "слово", "мама", "яблуко" };
            var germanyWords = new string[] { "wort", "mutter", "apfel" };
            var russianWords = new string[] { "слово", "мама", "яблоко" };
            var italianWords = new string[] { "parola", "madre", "mela" };

            var fromLanguage = Enum.Parse(typeof(Languages), Console.ReadLine());
            var word = Console.ReadLine();
            var toLanguage = Enum.Parse(typeof(Languages), Console.ReadLine());

            var wordIndex = -1;

            switch (fromLanguage)
            {
                case Languages.english:
                    {
                        for (int i = 0; i < englishWords.Length; i++)
                        {
                            if (englishWords[i] == word)
                            {
                                wordIndex = i;
                            }
                        }
                        break;
                    }
                case Languages.ukraine:
                    {
                        for (int i = 0; i < ukraineWords.Length; i++)
                        {
                            if (ukraineWords[i] == word)
                            {
                                wordIndex = i;
                            }
                        }
                        break;
                    }
                case Languages.germany:
                    {
                        for (int i = 0; i < germanyWords.Length; i++)
                        {
                            if (germanyWords[i] == word)
                            {
                                wordIndex = i;
                            }
                        }
                        break;
                    }
                case Languages.russian:
                    {
                        for (int i = 0; i < russianWords.Length; i++)
                        {
                            if (russianWords[i] == word)
                            {
                                wordIndex = i;
                            }
                        }
                        break;
                    }
                case Languages.italian:
                    {
                        for (int i = 0; i < italianWords.Length; i++)
                        {
                            if (italianWords[i] == word)
                            {
                                wordIndex = i;
                            }
                        }
                        break;
                    }
            }

            switch (toLanguage)
            {
                case Languages.english:
                    {
                        Console.WriteLine(englishWords[wordIndex]);
                        break;
                    }
                case Languages.ukraine:
                    {
                        Console.WriteLine(ukraineWords[wordIndex]);
                        break;
                    }
                case Languages.germany:
                    {
                        Console.WriteLine(germanyWords[wordIndex]);
                        break;
                    }
                case Languages.russian:
                    {
                        Console.WriteLine(russianWords[wordIndex]);
                        break;
                    }
                case Languages.italian:
                    {
                        Console.WriteLine(italianWords[wordIndex]);
                        break;
                    }

            }
        }
    }

    enum Languages
    {
        english,
        ukraine,
        germany,
        russian,
        italian
    }
    class Dictionary
    {
        public void Translate(string fromLanguage, string toLanguage, string word)
        {
            Console.WriteLine($"{fromLanguage}: {word} - {toLanguage}: translated {word}");
        }
    }

}
