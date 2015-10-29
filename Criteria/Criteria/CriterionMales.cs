using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria.Criteria
{
    public class CriterionMales : ICriteria<Person>
    {
        public List<Person> MeetCriteria(List<Person> entities)
        {
            var men = from h in entities
                      where h.Gender == Gender.Male
                      select h;

            return men.ToList();
        }
    }
}
