public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        Show();
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {   
        if(IsHidden())
        {
            string dashing = "";
            int length = _text.Length;
            for(int i = 0; i < length; i++)
            {
                dashing = dashing + "_";
            }
            return dashing;
        }
        else
        {
            return _text;
        }
        
    }
}