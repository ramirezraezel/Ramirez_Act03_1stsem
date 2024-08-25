namespace Ramirez_Act03_1stsem 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            string firstName = "", middleName, lastName, address, dateOfbirth, gender, religion, nationality, birthOfplace,email,fatherName,motherName;
            int age;
            long contactNumber, MotherContactNumber, FatherContactNumber;

            Console.Write("What's your First Name?"); 
            firstName = Console.ReadLine() ?? "";

            Console.Write("What's your Middle Name?");
            middleName = Console.ReadLine()?? "";

            Console.Write("What's your Lastname?");
            lastName = Console.ReadLine()??"";

            Console.Write("Where do you live?");
            address = Console.ReadLine()??"";

            Console.Write("\nHow old are you?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nWhat's your date of birth?");
            dateOfbirth = Console.ReadLine()??"";

            Console.Write("male or female?");
            gender = Console.ReadLine()??"";

            Console.Write("What's your religion?");
            religion = Console.ReadLine()??"";

            Console.Write("What's your nationality?");
            nationality = Console.ReadLine()??"";

            Console.Write("Where were you born?");
            birthOfplace = Console.ReadLine()??"";

            Console.Write("What's my email?");
            email = Console.ReadLine()??"";

            Console.Write("My contact number?");
            contactNumber = Convert.ToInt32 (Console.ReadLine());

            Console.Write("My father's name?");
            fatherName = Console.ReadLine()??"";

            Console.Write("My mother's name?");
            motherName = Console.ReadLine()??"";

            Console.Write("My mother contact number?");
            MotherContactNumber =  Convert.ToInt32(Console.ReadLine());

            Console.Write("My father contact number");
            FatherContactNumber =  Convert.ToInt32(Console.ReadLine());
        }
    }    
}