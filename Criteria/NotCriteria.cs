using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
{

    internal class NotCriteria<E> : ICriteria<E>
    {
        private ICriteria<E> _criteria;

        internal NotCriteria(ICriteria<E> x)
        {
            _criteria = x;
        }

        public List<E> MeetCriteria(List<E> entities)
        {
            List<E> notCriteriaItems = _criteria.MeetCriteria(entities);
            // ensure original list is not modified, otherwise compound Or will use an already filtered list
            List<E> notEntities = entities.ToList();

            foreach (E notCriteriaItem in notCriteriaItems)
            {
                notEntities.Remove(notCriteriaItem);
            }

            return notEntities;
        }
    }
}
