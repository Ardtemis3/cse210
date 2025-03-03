using System.Xml.Serialization;
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
        foreach (Entry entry in _entries){
            entry.Display();
        }
    }

    public void SaveEntry(){
        System.Console.WriteLine("Name this file: ");
        string fileName = System.Console.ReadLine();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Entry>));
        StreamWriter writer = new StreamWriter($"{fileName}.xml");
        serializer.Serialize(writer, _entries);
        writer.Close();
    }

    public void LoadEntry(){
        System.Console.WriteLine("What is the name of the file: ");
        string fileName = System.Console.ReadLine();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Entry>));
        StreamReader reader = new StreamReader($"{fileName}.xml");
        _entries = (List<Entry>)serializer.Deserialize(reader);
    }
}