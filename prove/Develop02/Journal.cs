
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new System.IO.StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
            
        }
    }

    public void LoadFromFile(string file)
    {
        /*foreach(Entry entry in _entries)
        {
            _entries.Remove(entry);
        }*/
        _entries.Clear();

        string[] loadedEntries = System.IO.File.ReadAllLines(file);
        foreach(string line in loadedEntries)
        {
            string[] splitEntryInfo = line.Split(',');
            Entry newEntry = new Entry();
            newEntry._date = splitEntryInfo[0];
            newEntry._promptText = splitEntryInfo[1];
            newEntry._entryText = splitEntryInfo[2];

           AddEntry(newEntry);
        }
    }


}