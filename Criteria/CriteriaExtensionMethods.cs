using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ07.Criteria
{
    public static class CriteriaExtensionMethods
    {
        public static ICriteria<E> And<E>(this ICriteria<E> criteria, ICriteria<E> otherCriteria)
        {
            return new AndCriteria<E>(criteria, otherCriteria);
        }

        public static ICriteria<E> Or<E>(this ICriteria<E> criteria, ICriteria<E> otherCriteria)
        {
            return new OrCriteria<E>(criteria, otherCriteria);
        }

        public static ICriteria<E> Not<E>(this ICriteria<E> criteria)
        {
            return new NotCriteria<E>(criteria);
        }
    }
}
