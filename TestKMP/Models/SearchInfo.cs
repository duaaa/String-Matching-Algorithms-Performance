using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestKMP.Models
{
    public class Performance
    {
        public SearchInfo SearchTerm { get; set; }
        public List<SearchInfo> Indexes { get; set; }
        public List<Statement> NoTimesStatementExecuted { get; set; }
        public long TotalRunningTime { get; set; }

        public long MemoryConsumedByProcess { get; set; }
        public long InitialMemory { get; set; }
        public long TotalMemoryConsumed { get; set; }

        public int GetTotalNumberStatements()
        {
            List<int> temp = new List<int>();
            int TotalCount = 0;
            foreach (var item in NoTimesStatementExecuted)
            {
                if (!temp.Contains(item.StatementNumber))
                {
                    temp.Add(item.StatementNumber);
                    TotalCount = TotalCount + NoTimesStatementExecuted.Where(x => x.StatementNumber == item.StatementNumber).Count();
                }

            }
            return TotalCount;
        }

    }
    public class SearchInfo
    {
        public string Index { get; set; }
        public string SearchText { get; set; }
        public int Algorithm { get; set; }

    }
    public class Statement
    {
        public int StatementNumber { get; set; }
    }
  
}