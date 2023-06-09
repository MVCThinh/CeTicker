using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.PLC
{
    public class PLCLoad
    {


        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
            {
                return result;
            }

            PriorityQueue

        }

    }

    // Class define priority queue
    public class PriorityQueue<T> where T : IComparable<T>
    {

    }
}
