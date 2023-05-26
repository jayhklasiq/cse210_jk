using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public bool AllWordsHidden => _words.All(eachWord => eachWord.Hidden);

    public Scripture(Reference reference, string text)
    {
        // Store the reference object
        _reference = reference;

        // Parse the scripture text into words
        _words = ParseWords(text);

        // Create a new Random object for random word selection
        _random = new Random();
    }

    public void Display()
    {
        // Display the scripture reference
        Console.WriteLine(_reference.ToString());

        // Display each word, either as hidden or visible
        foreach (Word word in _words)
        {
            if (word.Hidden)
                Console.Write("_______ ");
            else
                Console.Write(word.Text + " ");
        }

        // Add a new line after displaying the words
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        // Get all visible words (not yet hidden)
        List<Word> visibleWords = _words.Where(eachWord => !eachWord.Hidden).ToList();

        // If there are visible words, hide a random word
        if (visibleWords.Count >= 0)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
        }
    }

    private List<Word> ParseWords(string text)
    {
        // Split the scripture text into individual word strings
        string[] wordStrings = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Create Word objects for each word string
        return wordStrings.Select(w => new Word(w)).ToList();
    }
}
