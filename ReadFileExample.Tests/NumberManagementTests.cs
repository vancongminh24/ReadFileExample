using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ReadFileExample.Tests
{
	[TestClass()]
	public class NumberManagementTests
	{
		[TestMethod()]
		public void GetHighestNumberAndLineTest1()
		{
			NumberManagement numberManagement = new NumberManagement();
			int[][] test = new int[2][];
			test[0] = new int[]{3,6,8,5};
			test[1] = new int[]{48,4,5,3,1};
			string result = numberManagement.GetHighestNumberAndLine(test);
			
			Assert.AreEqual("48. Line: 2", result, "Get highest number");
		}
		[TestMethod()]
		public void GetHighestNumberAndLineTest2()
		{
			NumberManagement numberManagement = new NumberManagement();
			int[][] test = new int[2][];
			test[0] = new int[] { 3, 4, 8, 48 };
			test[1] = new int[] { 48, 4, 6, 43 };
			string result = numberManagement.GetHighestNumberAndLine(test);

			Assert.AreEqual("48. Line: 1 2", result, "Get highest number");
		}
		[TestMethod()]
		public void GetHighestNumberAndLineTest3()
		{
			NumberManagement numberManagement = new NumberManagement();
			int[][] test = new int[3][];
			test[0] = new int[] { 48, 48, 1, 2, 3 };
			test[1] = new int[] { 2, 2, 4, 2 };
			test[2] = new int[] { 2, 4, 32, 3, 48 };
			string result = numberManagement.GetHighestNumberAndLine(test);

			Assert.AreEqual("48. Line: 1 3", result, "Get highest number");
		}
	}
}