public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title: title, description: description, date: date, time: time, address: address)
    {
        _speaker = speaker;
        _capacity = capacity;
        _eventType = "Lecture";
    }

    public override string GenerateFullDetailsMessage()
    {
        return $"{GenerateStandardMessage()}\n\nEvent Type: {_eventType}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string GenerateShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
}