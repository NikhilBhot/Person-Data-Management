using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class Operation
    {
        //UC-02
        public void RetriveToRecordsOfAge(List<Person> persons) 
        {
            var data =persons.Where(x => x.Age < 60).ToList().Take(2);
            foreach (var result in data) 
            {
                Console.WriteLine(result.SSN);
            }
        }

        //UC-03
        public void RetriveAllRecoredOfAge(List<Person> persons)
        {
            var data = persons.Where(x => x.Age > 13 && x.Age < 18).ToList();
            foreach (var result in data)
            {
                Console.WriteLine(result.SSN);
            }
        }

        //UC-04
        public void RetriveAvegargeOfAge(List<Person> persons)
        {
            Console.WriteLine("\nGetting Average of all the person's age...");  
            double avgAge = persons.Average(e => e.Age);
            Console.WriteLine("The average of all the person's age is: " + avgAge);
        }
       
    }
}
