using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileExample
{
	public class NumberManagement
	{
		public int[][] GetFileAndConvertIntoArray(string path)
		{
			//TODO
			throw new NotImplementedException();
		}

		public string GetHighestNumberAndLine(int[][] numArr)
		{
			var maxValue = 0;
			var lines = new List<int>();
			for (int i = 0; i < numArr.Length; i++)
			{
				for (int j = 0; j < numArr[i].Length; j++)
				{
					if (numArr[i][j] > maxValue)
					{
						maxValue = numArr[i][j];
						lines.Clear();
						lines.Add(i);
					}
					else if (numArr[i][j] == maxValue)
					{
						if (!lines.Contains(i))
						{
							lines.Add(i);
						}						
					}
				}
			
			}
			var linesString = "";
			foreach (var i in lines)
			{
				linesString += " " + (i + 1);
			}
			var result = "" + maxValue + ". Line:" + linesString;
			return result;
		}
	}
}
