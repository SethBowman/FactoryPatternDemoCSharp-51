namespace FactoryPatternDemoCSharp_51;

public class AndroidPhone : IMobilePhone
{
    public void Call()
    {
        Console.WriteLine("Making a call with an Android Phone..");
    }

    public void Text()
    {
        Console.WriteLine("Texting with an Andriod Phone..");
    }
}