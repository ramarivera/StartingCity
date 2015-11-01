using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ07.Criteria
{

    internal class NotCriteria<T> : ICriteria<T>
    {
        private ICriteria<T> iUnCriterio;

        internal NotCriteria(ICriteria<T> x)
        {
            iUnCriterio = x;
        }

        public List<T> MeetCriteria(List<T> entities)
        {
            List<T> notCriteriaItems = iUnCriterio.MeetCriteria(entities);
            // ensure original list is not modified, otherwise compound Or will use an already filtered list
            List<T> notEntities = entities.ToList();

            foreach (E notCriteriaItem in notCriteriaItems)
            {
                notEntities.Remove(notCriteriaItem);
            }

            return notEntities;
        }
    }
}
