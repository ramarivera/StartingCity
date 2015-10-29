using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
{
    internal class OrCriteria<E> : ICriteria<E>
    {
        private ICriteria<E> _criteria;
        private ICriteria<E> _otherCriteria;

        internal OrCriteria(ICriteria<E> criteria, ICriteria<E> otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<E> MeetCriteria(List<E> entities)
        {
            List<E> firstCriteriaItems = _criteria.MeetCriteria(entities);
            List<E> otherCriteriaItems = _otherCriteria.MeetCriteria(entities);

            foreach (E otherCriteriaItem in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(otherCriteriaItem))
                    firstCriteriaItems.Add(otherCriteriaItem);
            }

            return firstCriteriaItems;
        }
    }
}
