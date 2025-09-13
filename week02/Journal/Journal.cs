using System.Data;
using System.IO;
using System.Security.Cryptography.X509Certificates;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            i.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry i in _entries)
            {
                writer.WriteLine($"{i._date} | {i._promptText} | {i._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] parts = line.Split('|');

                Entry e = new Entry();
                e._date = parts[0];
                e._promptText = parts[1];
                e._entryText = parts[2];

                _entries.Add(e);

                line = reader.ReadLine();
            }
        }
    }
}
    
   