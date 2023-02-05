namespace ConsoleApp64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Naim", "Rahimov",2345685,RegistrationMonth.January);
            Console.WriteLine(user.GetDetails());

        Kayword: int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case (int)RegistrationMonth.January:
                    Console.WriteLine("Yanvar");
                    break;
                case (int)RegistrationMonth.February:
                    Console.WriteLine("Fevral");
                    break;
                case (int)RegistrationMonth.March:
                    Console.WriteLine("Mart");
                    break;
                case (int)RegistrationMonth.April:
                    Console.WriteLine("Aprel");
                    break;
                case (int)RegistrationMonth.May:
                    Console.WriteLine("May");
                    break;
                case (int)RegistrationMonth.June:
                    Console.WriteLine("Iyun");
                    break;
                case (int)RegistrationMonth.July:
                    Console.WriteLine("Iyul");
                    break;
                case (int)RegistrationMonth.August:
                    Console.WriteLine("Avqust");
                    break;
                case (int)RegistrationMonth.September:
                    Console.WriteLine("Sentyabr");
                    break;
                case (int)RegistrationMonth.October:
                    Console.WriteLine("Oktyabr");
                    break;
                case (int)RegistrationMonth.November:
                    Console.WriteLine("Noyabr");
                    break;
                case (int)RegistrationMonth.December:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("Enter keyword correctly,please");
                    break;
            }
        }
    }
}
