namespace Homework30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide data as command line arguments.");
                return;
            }

            
            MyObject obj = new MyObject();
            obj.Run();

            
            MyOtherObject otherObj = new MyOtherObject(args);

            
            otherObj.Dispose();
        }
    }
}