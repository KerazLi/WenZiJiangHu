namespace Test
{
    public class Codes
    {
        
    }

    public enum OpCode
    {
        Dialog,
        BuyThing
    }

    public enum EventCode
    {
        GetAge,SendThingName
    }

    public class ParameterCode
    {
        public const short Age = 6;
        public const short ThingName = 4;
    }
}