using System.Linq;
using System.Collections.Generic;

namespace RepeatedContent
{
    class RepetitionSearcher
    {
        public List<string> Lines;

        public RepetitionSearcher(List<string> lines)
        {
            Lines = lines;
        }

        public void RemoveRepeatedLines()
        {
            Lines = Lines.Distinct().ToList();
        }

        public List<string> GetRepeatedLines()
        {
            return Lines.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key).ToList();
        }
    }
}