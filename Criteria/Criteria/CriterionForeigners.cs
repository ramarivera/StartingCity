using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria.Criteria
{
    public class CriterionForeigners : ICriteria<Person>
    {
        public List<Person> MeetCriteria(List<Person> entities)
        {
            var persons = from h in entities
                          where h.Nationality == Nationality.Foreigner
                          select h;

            return persons.ToList();
        }
    }
}
