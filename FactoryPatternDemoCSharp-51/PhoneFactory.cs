namespace FactoryPatternDemoCSharp_51;

public static class PhoneFactory
{
    public static IMobilePhone BuildMobilePhone(string phoneType)
    {
        switch (phoneType.ToLower())
        {
            case "android":
                return new AndroidPhone();
            case "iphone":
            case "apple":
                return new ApplePhone();
            case "google":
                return new GooglePhone();
            default:
                return new AndroidPhone();                
        }
    }
}