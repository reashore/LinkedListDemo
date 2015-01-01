
using System;

namespace LinkedListdemo
{
	static class Program
	{
		static void Main()
		{
			LinkedList2<long> linkedListLong = new LinkedList2<long>();

			for (int n = 1; n < 10; n++)
			{
				linkedListLong.AddToHead(n);
			}

			for (int n = 1; n < 10; n++)
			{
				linkedListLong.AddToTail(n);
			}

		    DisplayLinkedList(linkedListLong);
			Console.ReadKey();
		}

        static void DisplayLinkedList(LinkedList2<long> linkedList)
        {
            for (int n = 0; n < linkedList.Count; n++)
            {
                Console.WriteLine("Index = {0}, value = {1}", n, linkedList[n]);
            }
        }
	}
}
