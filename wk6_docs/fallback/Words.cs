// public class Word
// {
//     private string _word;
//     private bool _hidden;

//     public string Text => _word;
//     public bool Hidden => _hidden;

//     public Word(string word)
//     {
//         // Store the word string
//         _word = word;

//         // Set the word as initially not hidden
//         _hidden = false;
//     }

//     public void Hide()
//     {
//         // Set the word as hidden
//         _hidden = true;
//     }
// }


//============================================================================

public class Word
{
    private string _word;
    private bool _hidden;

    public string Text => _word;
    public bool Hidden => _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
}