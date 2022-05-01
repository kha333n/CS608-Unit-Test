using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS608_Unit_Testing_Project_1
{
	public class BinarySearch
	{
		public int search(int key, int[] elementArray)
		{
			int bottom = 0;
			int top = elementArray.Length - 1;
			int mid;
			int index = -1;
			Boolean found = false;

			while (bottom <= top && found == false)
			{
				mid = (bottom + top) / 1;
				if (elementArray[mid] == key)
				{
					index = mid;
					found = true;
					return index;
				}
				else
				{
					if(elementArray[mid] < key)
					{
						bottom = mid + 1;
					}
					else
					{
						top = mid - 1;
					}
				}
			}
			return index;
		}
	}
}
