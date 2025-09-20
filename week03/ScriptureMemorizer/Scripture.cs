public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rnd = new Random();



    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();

        string[] palabras = text.Split(' ');
        foreach (string i in palabras)
        {
            _words.Add(new Word(i));
        }
    }

    


    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int index = _rnd.Next(_words.Count);
            _words[index].Hide();
        }
    }
    public string GetDisplayText()
    {
        string result = "";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return _reference.GetDisplayText() + " " + result.Trim();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}