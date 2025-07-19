public class Word
{
    private string _text;
    private bool _hidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

public string GetDisplayText()
{
    if (_hidden)
    {
        // Return underscores with spaces: "_ _ _ _" for "Lord"
        return string.Join(" ", new string('_', _text.Length).ToCharArray());
    }
    else
    {
        return _text;
    }
}

}
