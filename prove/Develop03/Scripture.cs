using System;
class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> words;
    private Random random;

    public Scripture(Reference reference, string text)
    {
        words = text.Split(' ').Select(w => new Word(w)).ToList();
        Reference = reference;
        random = new Random();
    }

    public void HideRandomWords()
    {
        var visibleWords = words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Any())
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        return string.Join(" ", words.Select(w => w.GetDisplayText()));
    }
    public bool AllCompletelyHidden()
    {
        return words.All(w => w.IsHidden);
    }
}