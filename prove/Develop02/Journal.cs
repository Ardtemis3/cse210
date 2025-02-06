class Journal{

    public List<Entry> _entries = new List<Entry>();

    public string _fileName = "";

        Entry entry = new Entry();

    public void AddEntry(string date, string prompt, string response) {
        var entry = new Entry();

        entry._date = date;
        entry._prompt = prompt;
        entry._response = response;

        _entries.Add(entry);
    }

    public void Display(){
        Console.WriteLine(_entries);
        Console.WriteLine(_fileName);
    }
}