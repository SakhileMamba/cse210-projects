public class Question
{   
    //Added a questions class to hold more data about the questions, whether each questions has been shown or not.
    private string _text;
    private bool _hasBeenShown;

    public Question(string text)
    {
        _text = text;
        unShow();
    }

    public void Show()
    {
        _hasBeenShown = true;
    }

    public void unShow()
    {
        _hasBeenShown = false;
    }

    public bool IsAvailableToShow()
    {
        return !_hasBeenShown;
    }

    public string GetDisplayText()
    {   
            return _text;
    }
}