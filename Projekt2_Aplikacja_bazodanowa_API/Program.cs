namespace Projekt2_Aplikacja_bazodanowa_API
{
    
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Average { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} \tName: {Name, -15} \tAverage: {Average:0.00}" + Environment.NewLine;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            APITest test = new APITest();
            test.GetData().Wait();
        }
    }
}
