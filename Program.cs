using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace PersonDataManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-01
            List<Person> people = new List<Person>();

            people.Add(new Person()
            {
                SSN = 1,
                Name = "NIKHIL",
                Address = "aKOLE",
                Age = 20
            });
             people.Add(new Person()
             {
                SSN = 2,
                Name = "SANKET",
                Address = "SANGMNER",
                Age = 62
            }
            );
            people.Add(new Person()
            {
                SSN = 3,
                Name = "SIDHHESH",
                Address = "PUNE",
                Age = 16
            });
            Operation operatrion = new Operation();
            operatrion.RetriveToRecordsOfAge(people);

            Console.WriteLine("......................................");
           operatrion.RetriveAllRecoredOfAge(people);

            // Operation operation=new Operation();

            operatrion.RetriveAvegargeOfAge(people);
        }
    }
}