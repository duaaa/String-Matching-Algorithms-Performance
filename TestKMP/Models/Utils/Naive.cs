using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TestKMP.Models.Utils
{
    public class Naive
    {
        List<Statement> NoOfTimesStatementsExecuted = new List<Statement>();
        public Performance Search(String pat, String txt)
        {
            Performance p = new Performance();
            Stopwatch stopwatch = Stopwatch.StartNew();

            List<SearchInfo> result = new List<SearchInfo>();

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 1 });
            int M = pat != null? pat.Length : 0;
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 2 });
            int N = txt != null? txt.Length : 0;

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 3 });
            /* A loop to slide pat one by one */
            for (int i = 0; i <= N - M; i++)
            {
                NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 4 });
                int j;

                /* For current index i, check for pattern  
                match */
                for (j = 0; j < M; j++)
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 5 });
                    if (txt != null && pat != null)
                    {
                        NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 6 });
                        if (txt[i + j] != pat[j])
                        {
                            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 7 });
                            break;
                        }
                    }
                }

                NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 8 });
                // if pat[0...M-1] = txt[i, i+1, ...i+M-1] 
                if (j == M)
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 9 });
                    result.Add(new SearchInfo { Index = "" + i });
                }
                 
            }

            stopwatch.Stop();
            p.TotalRunningTime = stopwatch.ElapsedMilliseconds;
            p.Indexes = result;
            p.NoTimesStatementExecuted = NoOfTimesStatementsExecuted;

            return p;
        }
    }
}