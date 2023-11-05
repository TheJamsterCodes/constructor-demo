namespace ConstructorDemo;

public class Instrument
{
    /// <summary>
    /// The type of instrument (e.g. grand piano, electric guitar, etc.).
    /// </summary>
    public string Type { get; set; }

    // Default, or parameterless constructor, explicity declared since there's a parameterized constructor declared as well.
    public Instrument() { }

    // Parameterized constructor
    public Instrument(string type)
    {
        Type = type;
    }
}
