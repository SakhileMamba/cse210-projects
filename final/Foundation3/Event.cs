public abstract class Event
{
    protected string _title;
    private string _description;
    protected string _date;
    private string _time;
    protected string _eventType;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GenerateStandardMessage()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\n\nAddress:\n{_address.GetAddress()}";
    }

    public abstract string GenerateFullDetailsMessage();

    public abstract string GenerateShortDescription();

    /*
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetEventType()
    {
        return _eventType;
    }
    */
}