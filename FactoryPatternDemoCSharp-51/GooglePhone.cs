namespace FactoryPatternDemoCSharp_51;

public class GooglePhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Making a call with a Google Phone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with a Google Phone..");
    }
}