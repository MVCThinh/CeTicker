using Cognex.VisionPro.Implementation.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.PLC
{
    public class PLCLoad
    {


        //public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        //{
        //    IList<IList<int>> result = new List<IList<int>>();

        //    if (nums1 == null || nums2 == null || nums1.Length == 0 || nums2.Length == 0)
        //    {
        //        return result;
        //    }

        //    PriorityQueue<IntPair> minHeap = new PriorityQueue<IntPair>();

        //    for (int i = 0; i < Math.Min(nums1.Length, k); i++)
        //    {
        //        minHeap.Enqueue(new int[] { nums1[i], nums2[0], 0 });
        //    }

        //    // Lấy k cặp có tổng nhỏ nhất từ hàng đợi ưu tiên
        //    while (k > 0 && minHeap.Count > 0)
        //    {
        //        int[] pair = minHeap.Dequeue();
        //        int num1 = pair[0];
        //        int num2 = pair[1];
        //        int index2 = pair[2];

        //        result.Add(new List<int> { num1, num2 });

        //        // Thêm cặp tiếp theo từ nums1 và nums2 nếu có
        //        if (index2 < nums2.Length - 1)
        //        {
        //            minHeap.Enqueue(new int[] { num1, nums2[index2 + 1], index2 + 1 });
        //        }

        //        k--;
        //    }

        //    return result;

        //}

        public class IntPair : IComparable<IntPair>
        {
            public int First { get; set; }
            public int Second { get; set; }

            public int CompareTo(IntPair other)
            { 
                int sum1 = First + Second;
                int sum2 = other.First + other.Second;
                return sum1.CompareTo(sum2);
            }
        }

        // Lớp hàng đợi ưu tiên tự định nghĩa
        public class PriorityQueue<T> where T : IComparable<T>
        {
            private List<T> heap;
            private Comparison<T> comparison;

            public PriorityQueue()
            {
                heap = new List<T>();
                comparison = Comparer<T>.Default.Compare;
            }

            public PriorityQueue(Comparison<T> comparison)
            {
                heap = new List<T>();
                this.comparison = comparison;
            }

            public void Enqueue(T item)
            {
                heap.Add(item);
                int childIndex = heap.Count - 1;
                while (childIndex > 0)
                {
                    int parentIndex = (childIndex - 1) / 2;
                    if (comparison(heap[childIndex], heap[parentIndex]) >= 0)
                    {
                        break;
                    }
                    T temp = heap[childIndex];
                    heap[childIndex] = heap[parentIndex];
                    heap[parentIndex] = temp;
                    childIndex = parentIndex;
                }
            }

            public T Dequeue()
            {
                int lastIndex = heap.Count - 1;
                T frontItem = heap[0];
                heap[0] = heap[lastIndex];
                heap.RemoveAt(lastIndex);

                lastIndex--;
                int parentIndex = 0;

                while (true)
                {
                    int childIndex = parentIndex * 2 + 1;
                    if (childIndex > lastIndex)
                    {
                        break;
                    }
                    int rightChild = childIndex + 1;
                    if (rightChild <= lastIndex && comparison(heap[rightChild], heap[childIndex]) < 0)
                    {
                        childIndex = rightChild;
                    }
                    if (comparison(heap[parentIndex], heap[childIndex]) <= 0)
                    {
                        break;
                    }
                    T temp = heap[parentIndex];
                    heap[parentIndex] = heap[childIndex];
                    heap[childIndex] = temp;
                    parentIndex = childIndex;
                }

                return frontItem;
            }

            public T Peek()
            {
                T frontItem = heap[0];
                return frontItem;
            }

            public int Count()
            {
                return heap.Count;
            }

            public bool IsEmpty()
            {
                return heap.Count == 0;
            }
        }

    }

    // Class define priority queue
    //public class PriorityQueue<T> where T : IComparable<T>
    //{
    //    private List<T> heap;
    //    private Comparison<T> comparison;

    //    public PriorityQueue()
    //    {
    //        heap = new List<T>();
    //        comparison = Comparer<T>.Default.Compare;
    //    }

    //    public PriorityQueue(Comparison<T> comparison)
    //    {
    //        heap = new List<T>();
    //        this.comparison = comparison;
    //    }

    //    public void Enqueue(T item)
    //    {
    //        heap.Add(item);
    //        int childIndex = heap.Count - 1;
    //        while(childIndex > 0)
    //        {
    //            int parentIndex = (childIndex - 1) / 2;
    //            if (comparison(heap[childIndex], heap[parentIndex]) >= 0)
    //            {
    //                break;
    //            }
    //            T temp = heap[childIndex];
    //            heap[childIndex] = heap[parentIndex];
    //            heap[parentIndex] = temp;
    //            childIndex = parentIndex;
    //        }
    //    }
    //}
}
