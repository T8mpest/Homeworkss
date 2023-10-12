using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            // Вибір методу для виклику через параметр командного рядка або взаємодію з користувачем
            string methodName;
            if (args.Length > 0)
            {
                methodName = args[0];
            }
            else
            {
                Console.Write("Введіть назву методу для виклику (Print): ");
                methodName = Console.ReadLine();
            }

            try
            {
                MethodInfo method = typeof(MyClass).GetMethod(methodName);
                if (method != null)
                {
                    method.Invoke(obj, new object[] { "Hello World" });
                }
                else
                {
                    Console.WriteLine("Метод не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}