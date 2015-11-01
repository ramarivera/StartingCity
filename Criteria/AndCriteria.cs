using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criteria
{
    internal class AndCriteria<E> : ICriteria<E>
    {
        private ICriteria<E> _criteria;
        private ICriteria<E> _otherCriteria;

        internal AndCriteria(ICriteria<E> criteria, ICriteria<E> otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
        }

        public List<E> MeetCriteria(List<E> entities)
        {
            var result = _criteria.MeetCriteria(entities);
            // If it returns 1 is because only 1 met the criterion
            // and the inherited ands are not executed
            // If it returns 0 is because none met the criterion
            // and the inherited ands are not executed

            if (result.Count == 0 /* Bug :|| result.Count == 1*/ )
                return result;

            return _otherCriteria.MeetCriteria(result);
        }
    }
}
