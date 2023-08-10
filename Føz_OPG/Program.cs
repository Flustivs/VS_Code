namespace Opgave_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Please enter in this format DD.MM.Year)\n" +
                "Please Enter your Birthday: ");
            string readin = Console.ReadLine();
            DateTime birthday = DateTime.ParseExact(readin, "dd.MM.yyyy", null);
            
            Console.WriteLine("Your birthday is: " + birthday);

            DateTime now = DateTime.Now;

            TimeSpan diff = now - birthday;

            int years = (int)Math.Floor(diff.TotalDays / 365.2425);
            
            birthday = birthday.AddYears(years);
            diff = now - birthday;

            int days = (int)Math.Floor(diff.TotalDays);

            Console.WriteLine("Your this "+years+" years old and "+days+" days old");
        }
    }
}