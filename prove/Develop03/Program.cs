using System;

class Program
{
    static void Main(){

        // Create string lists
        List<string> _verseWords1 = new List<string> {"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own", "understanding."};
        List<string> _verseWords2 = new List<string> {"In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."};

        // Create verses from string lists
        Verse verse1 = new Verse(_verseWords1);
        Verse verse2 = new Verse(_verseWords2);

        // Create list of verses
        List<Verse> _listOfVerses = new List<Verse> {verse1, verse2};

        // Create scripture
        Scripture scripture = new Scripture(_listOfVerses);
        
    }

}
