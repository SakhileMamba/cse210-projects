public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title: title, description: description, date: date, time: time, address: address)
    {
        _rsvpEmail = rsvpEmail;
        _eventType = "Reception";

    }

    public override string GenerateFullDetailsMessage()
    {
        return $"{GenerateStandardMessage()}\n\nEvent Type: {_eventType}\nRSVP Email: {_rsvpEmail}";
    }

    public override string GenerateShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
    }
}