using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS608_Unit_Testing_Project_1;

namespace Unit_Test_Project_1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			int key = 1;
			int[] array = {1,2,3,4,5,6,7,8,9};
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(0, binarySearch.search(key,array));
		}

		[TestMethod]
		public void TestMethod2()
		{
			int key = 2;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(1, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod3()
		{
			int key = 3;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(2, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod4()
		{
			int key = 4;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(3, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod5()
		{
			int key = 5;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(4, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod6()
		{
			int key = 6;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(5, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod7()
		{
			int key = 7;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(6, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod8()
		{
			int key = 0;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(-1, binarySearch.search(key, array));
		}

		[TestMethod]
		public void TestMethod10()
		{
			int key = 10;
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			BinarySearch binarySearch = new BinarySearch();
			Assert.AreEqual(-1, binarySearch.search(key, array));
		}
	}
}