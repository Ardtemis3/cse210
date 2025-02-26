using System;

class Verse
{
    
        private List<string> _words = new List<string> {"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding.", "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."};
        // private Random random = new Random();
        private List<Word> _listWord = new List<Word>();

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
    


    public void Load() {
        foreach (string theWord in _words) {
            _listWord.Add(new Word(theWord));
        }
    }
    public void Display(){
        foreach (Word word in _listWord){
            word.Display();
        }
    }
    
}