using ConsoleApp7;

Assistant assistant = new Assistant();
assistant.GetFeedback(assistant);
Console.WriteLine($"{assistant.IsSuccessful}");

Manager manager1 = new Manager();
manager1.GetPromotion(manager1);
Console.WriteLine(manager1.Salary);

namespace ConsoleApp7
{
    public class Employee
    {
        public string Name;
        public bool IsSuccessful;
        public int Salary;
    }

}