using System.Reflection.PortableExecutable;

class Word
{
    private string _word;
    private bool _hide;

    public Word (string theWord){
        _word = theWord;
        _hide = false;
    }
    public void Display(){
        if (_hide){
            foreach (char character in _word){
                System.Console.Write("-");
            }
        }
        else {
        System.Console.Write($"{_word} ");
        }
    }
    public bool GetHidden(){
        return _hide;
    }
    public void IsHidden(){
        _hide = true;
    }
}