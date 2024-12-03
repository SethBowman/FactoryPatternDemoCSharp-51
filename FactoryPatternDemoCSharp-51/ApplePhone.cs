namespace FactoryPatternDemoCSharp_51;

public class ApplePhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Making a call with an iPhone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an iPhone..");
    }
}