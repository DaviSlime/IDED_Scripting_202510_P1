using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            foreach (uint num in stack)
            {
                if (IsPrime(num))
                    return num;
            }
            return 0;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {
            return null;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)
        {
            Queue<uint> queue = new Queue<uint>();

            foreach (uint num in stack)
            {
                queue.Enqueue(num);
            }

            return queue;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {
            return null;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            return false;
        }

        private static bool IsPrime(uint num)
        {
            if (num < 2) return false;
            for (uint i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}