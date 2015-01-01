
using System;

namespace LinkedListdemo
{
	public class LinkedList2<T>
	{
		class Cell
		{
			public T Value { get; set; }
			public Cell NextCell { get; set; }
		}

		private Cell HeadCell { get; set; }

		public void AddToHead(T value)
		{
			Cell newCell = new Cell();
			newCell.Value = value;
			newCell.NextCell = HeadCell;
			HeadCell = newCell;
		}

		public T RemoveFromHead()
		{
			if (HeadCell == null)
			{
				throw new InvalidOperationException("Cannot remove from head because list is empty");
			}

			T value = HeadCell.Value;
			Cell nextCell = HeadCell.NextCell;
			HeadCell = nextCell;

			return value;
		}

		public void AddToTail(T value)
		{
			Cell newCell = new Cell();
			newCell.Value = value;

			Cell nextCell = HeadCell;
			Cell previousCell = HeadCell;

			// find the end of the list
			while (nextCell != null)
			{
				previousCell = nextCell;
				nextCell = nextCell.NextCell;
			}

			// add the new cell to the end of the list
			if (previousCell == null)
			{
				HeadCell = newCell;
			}
			else
			{
				previousCell.NextCell = newCell;
			}
		}

		public T RemoveFromTail()
		{
			if (HeadCell == null)
			{
				throw new InvalidOperationException("Cannot remove from tail because list is empty");
			}

			Cell nextCell = HeadCell;
			Cell previousCell = HeadCell;

			// find the end of the list
			while (nextCell != null)
			{
				previousCell = nextCell;
				nextCell = nextCell.NextCell;
			}

			// remove the last cell from the end of the list
			if (previousCell == HeadCell)
			{
				HeadCell = null;
			}
			else
			{
				previousCell.NextCell = null;
			}

			return previousCell.Value;
		}

		public int Count
		{
			get
			{
				int count = 0;
				Cell currentCell = HeadCell;

				while (currentCell != null)
				{
					count++;
					currentCell = currentCell.NextCell;
				}

				return count;
			}
		}

		public T this[int n]
		{
			get
			{
				Cell cell = FindByIndex(n);
				return cell.Value;
			}

			set
			{
				Cell cell = FindByIndex(n);
				cell.Value = value;

			}
		}

		// 0-based index
		private Cell FindByIndex(int n)
		{
			if (n < 0 || n > Count - 1)
			{
				throw new InvalidOperationException("Index is out of range");
			}

			int index = 0;
			Cell currentCell = HeadCell;

			while (currentCell != null)
			{
				if (index == n)
				{
                    break;
				}

                currentCell = currentCell.NextCell;
                index++;
            }

            return currentCell;
        }
	}
}
