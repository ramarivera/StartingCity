using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ07.Criteria
{
    internal class OrCriteria<T> : ICriteria<T>
    {
        private ICriteria<T> iUnCriterio;
        private ICriteria<T> iOtroCriterio;

        internal OrCriteria(ICriteria<T> pUnCriterio, ICriteria<T> pOtroCriterio)
        {
            iUnCriterio = pUnCriterio;
            iOtroCriterio = pOtroCriterio;
        }

        public IList<T> MeetCriteria(IList<T> entities)
        {
            IList<T> firstCriteriaItems = iUnCriterio.MeetCriteria(entities);
            IList<T> otherCriteriaItems = iOtroCriterio.MeetCriteria(entities);

            foreach (E otherCriteriaItem in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(otherCriteriaItem))
                    firstCriteriaItems.Add(otherCriteriaItem);
            }

            return firstCriteriaItems;
        }
    }
}
