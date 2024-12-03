namespace FactoryPatternDemoCSharp_51;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What type of phone do you have? (apple/iphone, google, or android)");
        var input = Console.ReadLine();
        var phone = PhoneFactory.BuildMobilePhone(input);
        phone.Call();
        phone.Text();
    }
}
