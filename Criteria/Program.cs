using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Criteria.Criteria;

namespace Criteria
{
    class Program
    {
        public static void ListarPersonas (List<Person> pLista)
        {
            int i = 1;
            Console.WriteLine("Listando {0} Personas", pLista.Count);
            foreach (Person lPerson in pLista)
            {
                
                Console.WriteLine("{0}\t"+lPerson.ToString(),(i++).ToString("D3"));
            }
        }

        static void Main(string[] args)
        {
            List<Person> lPeople = new List<Person>();

            lPeople.Add(new Person("Robert", Gender.Male, MaritalStatus.Single,20));
            lPeople.Add(new Person("John", Gender.Male, MaritalStatus.Married,36));
            lPeople.Add(new Person("Laura", Gender.Female, MaritalStatus.Married,40));
            lPeople.Add(new Person("Diana", Gender.Female, MaritalStatus.Single,20));
            lPeople.Add(new Person("Mike", Gender.Male, MaritalStatus.Single,50));
            lPeople.Add(new Person("Bobby", Gender.Male, MaritalStatus.Single,70));



            ICriteria<Person> male = new CriterionMales();
            ICriteria<Person> edadMayor30 = new CriterionEdadMayor(30);
            ICriteria<Person> female = new CriterionFemales();
            ICriteria<Person> single = new CriterionSingles();
            ICriteria<Person> foreigner = new CriterionForeigners();

           
            ICriteria<Person>  criteria = male.And(edadMayor30).Or(male.And(edadMayor30.Not()));

            ListarPersonas(criteria.MeetCriteria(lPeople));
           
               

            Console.ReadLine();
        }
    }

    
}
