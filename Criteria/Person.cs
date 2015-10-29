using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum Nationality
    {
        Argentino,
        Foreigner
    }

    public enum MaritalStatus
    {
        Viudo,
        Casado,
        Soltero,
        Single,
        Divorciado,
        Married
    }

    public enum Occupation
    {
        RelacionDependencia,
        Emprendedor,
        Desempleado
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public Nationality Nationality { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Occupation Occupation { get; set; }

        public Person(String pName, Gender pGender, MaritalStatus pMaritalStatus) : this(pName, pGender, pMaritalStatus, 0) { }
        public Person(String pName, Gender pGender, MaritalStatus pMaritalStatus, int pEdad)
        {
            this.Name = pName;
            this.Gender = pGender;
            this.MaritalStatus = pMaritalStatus;
            this.Age = pEdad;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0}\tGenero: {1}\tEstado Civil: {2}\tEdad:{3}",this.Name,this.Gender.ToString(),this.MaritalStatus.ToString(), this.Age.ToString());
        }

    }
}
