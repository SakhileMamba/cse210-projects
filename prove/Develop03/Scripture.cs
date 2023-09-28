public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] split = text.Split(" ");
        foreach (string word in split)
        {
            Word wordToAdd = new Word(word);
            _words.Add(wordToAdd);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int rounds = 0;
        void RecursiveFindAndHide()
        {
            
                int index = random.Next(0, _words.Count);
                if(_words[index].IsHidden())
                {
                    RecursiveFindAndHide();
                }
                else
                {
                    _words[index].Hide();
                    rounds+=1;
                }
            
        }

        do
        {
        RecursiveFindAndHide();
        } while (rounds < numberToHide);
    }

    public string GetDisplayText()
    {   
        string textpart = "";
        int index = 0;
        foreach(Word word in _words)
        {
            textpart += (word.GetDisplayText());
            if (index != (_words.Count - 1))
            {
                textpart += " ";
            }
            index++;
            
        }
        return $"{_reference.GetDisplayText()} {textpart}";
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

    /*
    I have added the method ShowAll() below to make all the words in the scripture show text instead of
    dashes after they have been hidden, which helps in case the users want to memorize a scripture again.
    */ 
    public void ShowAll()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
        
    }

    public int AvailableWords()
    {
        int available = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                available+=1;
            }
        }
        return available;
    }
}