using System;
class Scripture
{
    private Reference refence;
    private List<Word> words;

    public Scripture(Reference _reference, string _text)
    {
        refence = _reference;
        words = new List<Word>();

        foreach(string wordString in _text.Split(' '))
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }
    }

    public void HideRandomWords(int numbeToHide)
    {
        Random random = new Random();
        for(int i = 0; i < numbeToHide; i++)
        {
            int index = random.Next(words.Count);
            words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        Console.WriteLine(refence.GetDisplayText() + " ");
        string displayText = "";
        foreach(Word word in words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word word in words)
        {
            if(!word.GetIsHidden())
            {
                return false;
            }
        }
        return  true;
    }
}