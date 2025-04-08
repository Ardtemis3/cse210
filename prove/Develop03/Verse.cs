using System;

class Verse
{
    private Random random = new Random();
    private List<Word> _listWord = new List<Word>{};

    public Verse(List<String> _fullVerse){
        foreach (string theWord in _fullVerse) {
            _listWord.Add(new Word(theWord));   
        }
    }

    public void HideWord(Random random){
        int count = 0;
        while (count < 3){
            int index = random.Next(_listWord.Count);
            Word wordFromList = _listWord[index];
            wordFromList.Hide();
            count++;
        }
    }

    public void Display(){
        foreach (Word word in _listWord){
            word.Display();
        }
    }
    
}