using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
	class Program
	{
		static void Main(string[] args)
		{
			string s1 = "pukPukaPurejjJ";
			string s2 = "pkpuukaPurejjJ";
			Console.WriteLine(AreAnagrams(s1,s2)); 
			Console.ReadKey();
		}

		static bool AreAnagrams(string s1, string s2)
		{
			s1 = s1.ToLower();
			s2 = s2.ToLower();
			if (s1.Length != s2.Length)
			{
				return false;
			}
			for (int i = 0; i < s1.Length; i++)
			{
				if (s2.Contains(s1[i]))
				{
					s2 = s2.Remove(s2.IndexOf(s1[i]), 1);
					continue;
				}
				else
				{
					return false;
				}
			}
			return true;

		}
	}
}
