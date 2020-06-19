using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TestKMP.Models.Utils
{
    public class BM
    {
		List<Statement> NoOfTimesStatementsExecuted = new List<Statement>();
		public Performance Search(string pat, string text)
		{
			Performance p = new Performance();
			Stopwatch stopwatch = Stopwatch.StartNew();

			List<SearchInfo> result = new List<SearchInfo>();

			var sMemory = GC.GetTotalMemory(false);

			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 1 });
			int m = pat.Length;
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 2 });
			int n = text.Length;
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 3 });
			int[] badChar = new int[256];
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 4 });
			BadCharHeuristic(pat, m, ref badChar);
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 5 });
			int s = 0;
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 6 });
			while (s <= (n - m))
			{
				NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 7 });
				int j = m - 1;
				NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 8 });
				while (j >= 0 && pat[j] == text[s + j])
				{
					NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 9 });
					--j;
				}
				NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 10 });
				if (j < 0)
				{
					NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 11 });
					result.Add(new SearchInfo { Index = "" + s });
					NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 12 });
					s += (s + m < n) ? m - badChar[text[s + m]] : 1;
				}
				else
				{
					NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 13 });
					s += Math.Max(1, j - badChar[text[s + j]]);
				}
			}
			stopwatch.Stop();

			var s2Memory = GC.GetTotalMemory(false);

			var MemoryConsumedByProcess = (s2Memory - sMemory) / 1000000;
			var InitialMemory = (sMemory) / 1000000;
			var TotalMemoryConsumed = (s2Memory) / 1000000;

			p.MemoryConsumedByProcess = MemoryConsumedByProcess;
			p.InitialMemory = InitialMemory;
			p.TotalMemoryConsumed = TotalMemoryConsumed;

			p.TotalRunningTime = stopwatch.ElapsedMilliseconds;
			p.Indexes = result;
			p.NoTimesStatementExecuted = NoOfTimesStatementsExecuted;
			return p;
		}
		private void BadCharHeuristic(string str, int size, ref int[] badChar)
		{
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 14 });
			int i;
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 15 });
			for (i = 0; i < 256; i++)
			{
				NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 16 });
				badChar[i] = -1;
			}
			NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 17 });
			for (i = 0; i < size; i++)
			{
				NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 18 });
				badChar[(int)str[i]] = i;
			}
		}
	}
}