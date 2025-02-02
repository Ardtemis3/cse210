class Journal{

    public string _entries = "";

    public string _fileName = "";

        Entry entry = new Entry();
        
    public void Display(){
        Console.WriteLine(_entries);
        Console.WriteLine(_fileName);
    }
}