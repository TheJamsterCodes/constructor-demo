using ConstructorDemo;

var babyGrand = new Piano("Baby grand");

Console.WriteLine(Piano.NumberOfKeys);
Piano.ChangeNumberOfKeys(44);

var casioKeyboard = new Piano(true)
{
    Type = "Casio Keyboard"
};

Console.WriteLine(Piano.NumberOfKeys);
Console.WriteLine($"Type of instrument: {babyGrand.Type}");
Console.WriteLine($"Type of instrument: {casioKeyboard.Type}");