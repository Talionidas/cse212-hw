public class TranslatorSolution
{
    public static void Run()
    {
        var englishToGerman = new TranslatorSolution();
        englishToGerman.AddWord("House", "Haus");
        englishToGerman.AddWord("Car", "Auto");
        englishToGerman.AddWord("Plane", "Flugzeug");
        Console.WriteLine(englishToGerman.Translate("Car")); // Auto
        Console.WriteLine(englishToGerman.Translate("Plane")); // Flugzeug
        Console.WriteLine(englishToGerman.Translate("Train")); // ???
    }

    private Dictionary<string, string> _words = new();

    public void AddWord(string fromWord, string toWord)
    {
        _words[fromWord] = toWord;
    }

    public string Translate(string fromWord)
    {
        string newWord = "???";

        if (_words.ContainsKey(fromWord))
        {
            newWord = _words[fromWord];
        }

        return newWord;
    }
}