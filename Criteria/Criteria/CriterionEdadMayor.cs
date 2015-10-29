using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria.Criteria
{
    internal class CriterionEdadMayor : ICriteria<Person>
    {
        private int v;

        public CriterionEdadMayor(int v)
        {
            this.v = v;
        }

        List<Person> ICriteria<Person>.MeetCriteria(List<Person> entities)
        {
            List<Person> lResultado = new List<Person>();

            foreach (Person lPerson in entities)
            {
                if (lPerson.Age>this.v)
                {
                    lResultado.Add(lPerson);
                }
            }

            return lResultado;
        }
    }
}
