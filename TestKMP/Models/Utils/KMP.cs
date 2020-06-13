using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace TestKMP.Models.Utils
{
    public class KMP
    {
        List<Statement> NoOfTimesStatementsExecuted = new List<Statement>();
        public Performance Search(string pattern, string text)
        {
            Performance p = new Performance();
            Stopwatch stopwatch = Stopwatch.StartNew();
           
            List<SearchInfo> result = new List<SearchInfo>();

            var sMemory = GC.GetTotalMemory(false);

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 1 });

            int pattern_length = pattern != null ? pattern.Length : 0;

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 2 });

            int text_length = text != null ? text.Length : 0;

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 3 });

            int[] prefix_array = Get_Prefix_array(pattern ?? null, pattern_length);

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 4 });

            int index_pattern = 0;

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 5 });

            int index_text = 0;

            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 6 });

            while ( index_text < text_length )
            {
                NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 7 });
                if (text != null)
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 8 });
                    if ( pattern[index_pattern] == text[index_text] )
                    {
                        NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 9 });
                        index_pattern++;
                        NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 10 });
                        index_text++;
                    }

                }
                NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 11 });
                if ( index_pattern == pattern_length )
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 12 });
                    result.Add(new SearchInfo { Index = "" + (index_text - index_pattern) });
                    index_pattern = prefix_array[index_pattern - 1];
                }
                else if (index_text < text_length && pattern[index_pattern] != text[index_text])
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 13 });
                    if (index_pattern != 0)
                    {
                        NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 14 });
                        index_pattern = prefix_array[index_pattern - 1];
                    }
                    else
                    {
                        NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 15 });
                        index_text++;
                    }
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

        private int[] Get_Prefix_array(string pattern, int pattern_length)
        {
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 16 });
            int[] prefix_array = new int[pattern_length];
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 17 });
            prefix_array[0] = 0;
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 18 });
            int previous_prefix = 0;
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 19 });
            int previous_sufix = 1;
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 20 });
            while (previous_sufix != pattern_length)
            {
                NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 21 });
                if (pattern[previous_sufix] == pattern[previous_prefix])
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 22 });
                    previous_prefix++;
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 23 });
                    prefix_array[previous_sufix] = previous_prefix;
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 24 });
                    previous_sufix++;
                }
                else if (previous_prefix != 0)
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 25 });
                    previous_prefix = prefix_array[previous_prefix - 1];
                }
                else
                {
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 26 });
                    prefix_array[previous_sufix] = previous_prefix;
                    NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 27 });
                    previous_sufix++;
                }
            }
            NoOfTimesStatementsExecuted.Add(new Statement { StatementNumber = 28 });
            return prefix_array;

        }


    }
}