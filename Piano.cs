namespace ConstructorDemo;

public class Piano : Instrument
{
    // Private static variable declared
    private static int _numberOfKeys;

    public bool IsElectonic { get; set; }

    // Static constructor to initialize private static variable at runtime
    // Upon declaration, can also set _numberOfKeys to value without using static constructor 
    static Piano()
    {
        _numberOfKeys = 88;
    }
    
    public static void ChangeNumberOfKeys(int numberOfKeys) => _numberOfKeys = numberOfKeys;
    public static int NumberOfKeys => _numberOfKeys;

    // Parameterized constructor
    public Piano(string type) : base(type)
    {
    }

    // Type property from Instrument base class is unnecessary since it has a default constructor.
    public Piano(bool isElectonic)
    {
        IsElectonic = isElectonic;
    }
}
