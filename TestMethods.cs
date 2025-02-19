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
            Stack<uint> tempStack = new Stack<uint>();
            bool removed = false;

            while (stack.Count > 0)
            {
                uint num = stack.Pop();
                if (!removed && IsPrime(num))
                {
                    removed = true;
                    continue;
                }
                tempStack.Push(num);
            }

            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }
            return stack;
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
            List<uint> resultList = new List<uint>();

            foreach (uint num in stack)
            {
                resultList.Add(num);
            }

            return resultList;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            // Ordenamiento burbuja implementado a mano
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        // Intercambiar list[j] y list[j+1]
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            return BuscarNum(list, value);
        }

        private static bool BuscarNum(List<int> list, int target)
        {
            int left = 0, right = list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] == target)
                    return true;
                else if (list[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
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