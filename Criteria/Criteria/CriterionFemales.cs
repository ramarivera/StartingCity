using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria.Criteria
{
    public class CriterionFemales : ICriteria<Person>
    {
        public List<Person> MeetCriteria(List<Person> entities)
        {
            var women = from m in entities
                        where m.Gender == Gender.Female
                        select m;

            return women.ToList();
        }
    }
}
