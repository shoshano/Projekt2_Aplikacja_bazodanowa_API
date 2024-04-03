namespace Projekt2_Aplikacja_bazodanowa_API
{
    
    

    internal class Program
    {
        static void Main(string[] args)
        {
            APITest test = new APITest();
            test.GetData().Wait();
        }
    }
}
