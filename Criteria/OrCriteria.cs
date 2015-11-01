using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
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

        
        List<T> ICriteria<T>.MeetCriteria(List<T> entities)
        {
            IList<T> firstCriteriaItems = iUnCriterio.MeetCriteria(entities);
            IList<T> otherCriteriaItems = iOtroCriterio.MeetCriteria(entities);

            foreach (T otherCriteriaItem in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(otherCriteriaItem))
                    firstCriteriaItems.Add(otherCriteriaItem);
            }

            return (List < T > ) firstCriteriaItems;
        }
    }
}
