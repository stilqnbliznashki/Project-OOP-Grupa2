namespace ConsoleApp78
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter name:");
                string newEmployeeName = Console.ReadLine();
                Console.WriteLine("Enter age:");
                int newEmployeeAge = int.Parse(Console.ReadLine());
                Department.AddMember(newEmployeeName, newEmployeeAge);
            }
            Department.GetOldest();


        }
    }
}