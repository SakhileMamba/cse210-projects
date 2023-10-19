public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title: title, description: description, date: date, time: time, address: address)
    {
        _weather = weather;
        _eventType = "Reception";

    }

    public override string GenerateFullDetailsMessage()
    {
        return $"{GenerateStandardMessage()}\n\nEvent Type: {_eventType}\nWeather: {_weather}";
    }

    public override string GenerateShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
}