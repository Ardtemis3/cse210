using System;

class Verse
{
    

        private Random random = new Random();
        private List<Word> _listWord = new List<Word>{};

//5: Trust in the Lord with all thine heart; and lean not unto thine own understanding.

//6: In all thy ways acknowledge him, and he shall direct thy paths.

        // HashSet<int> usedIndices = new HashSet<int>();

        // Replace exactly 3 random words
        // while (usedIndices.Count < 3)
        // {
        //     int randomIndex = random.Next(words.Count);
        //     if (!usedIndices.Contains(randomIndex))
        //     {
        //         words[randomIndex] = new string('-', words[randomIndex].Length);
        //         usedIndices.Add(randomIndex);
        //     }
        // }
    

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