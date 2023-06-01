// public class Reference
// {
//     private string _book;
//     private int _chapter;
//     private int _verseStart;
//     private int _verseEnd;

//     public Reference(string reference)
//     {
//         // Parse the reference string into individual parts
//         ParseReference(reference);
//     }

//     private void ParseReference(string reference)
//     {
//         // Split the reference into book, chapter, and verse parts
//         string[] parts = reference.Split(' ', ':', '-');

//         // Extract the book name
//         _book = parts[0];

//         // Extract the chapter number
//         _chapter = int.Parse(parts[1]);

//         // Extract the starting verse number
//         _verseStart = int.Parse(parts[2]);

//         // Check if the reference includes a range of verses
//         if (parts.Length > 3)
//         {
//             // Extract the ending verse number
//             _verseEnd = int.Parse(parts[3]);
//         }
//         else
//         {
//             // If no range is specified, set the ending verse equal to the starting verse
//             _verseEnd = _verseStart;
//         }
//     }

//     public override string ToString()
//     {
//         // Format the reference as "Book Chapter:VerseStart-VerseEnd"
//         return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
//     }
// }


//==============================================================

public class Reference
{
    private int _bookNumber;
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string reference)
    {
        ParseReference(reference);
    }

    private void ParseReference(string reference)
    {
        string[] parts = reference.Split(' ', ':', '-', '|');

        if (_bookNumber == 0)
        {
            _book = parts[0];
            _chapter = int.Parse(parts[1]);
            _verseStart = int.Parse(parts[2]);
        }
        else 
        {
            _bookNumber = int.Parse(parts[0]);
             _book = parts[1];
            _chapter = int.Parse(parts[2]);
            _verseStart = int.Parse(parts[3]);
        }

        if (parts.Length > 3)
        {
            _verseEnd = int.Parse(parts[4]);
        }
        else
        {
            _verseEnd = _verseStart;
        }
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}