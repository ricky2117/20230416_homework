using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		//題目from leetcode 題庫第一題，指定陣列，並指定陣列2位數總和，打印出此2位數。
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入任一陣列(請用\",\"分隔):");
			string input_list = Console.ReadLine();
			Console.WriteLine("請輸入陣列中某2位相加的總和:");
			int input_target = int.Parse(Console.ReadLine());
			List_target.List_two(input_list,input_target);

			Console.ReadLine();
		}
	}
	public static class List_target
	{
		public static void List_two(string list, int target)
		{
			bool flag = false;
			List<int> arr = list.Split(',').Select(int.Parse).ToList();
            for (int i = 0; i < arr.Count; i++)
			{
				for (int k = i+1; k < arr.Count; k++)
				{
					if (arr[i] + arr[k] == target)
					{
                        Console.WriteLine($"[{i},{k}]");
						flag = true;
                    }
				}	
			}
			if (!flag) { Console.WriteLine("陣列中無符合的數字"); }
		}

	}


}
